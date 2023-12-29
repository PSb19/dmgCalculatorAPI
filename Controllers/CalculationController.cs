using calculator40k.Models;
using calculator40k.DbModels;
using dmgCalculatorAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dmgCalculatorAPI.Controllers;

[ApiController]
[Route("/Calculate")]
public class CalculationController : ControllerBase{

    private readonly ApiContext _context;

    public CalculationController(ApiContext context){
        _context = context;
    }


    [HttpGet("/{id}")]
    public async Task<ActionResult<Unit>> GetUnitById(int id){
        var dbUnit = await _context.Units.FindAsync(id);
        if(dbUnit == null){
            return NoContent();
        }
        
        var dbModel = await _context.Models.Where(m => dbUnit.ID == m.UnitID).FirstAsync();
        var dbRangedWeapon = await _context.RangedWeapons.Where(rw => dbModel.RangedWeaponId == rw.ID).FirstAsync();
        var dbMeleeWeapon = await _context.MeleeWeapons.FindAsync(dbModel.MeleeWeaponId);
        Unit unit = new Unit(dbUnit, dbModel, dbRangedWeapon, dbMeleeWeapon);

        return unit;
    }
    [HttpGet("/both/{attacker}/{defender}")]
    public async Task<ActionResult<IEnumerable<Unit>>> GetAttackerAndDefenderById(int attacker, int defender){
        var dbAttacker = await _context.Units.FindAsync(attacker);
        if(dbAttacker == null){
            return NoContent();
        }
        var dbDefender = await _context.Units.FindAsync(defender);
        if(dbDefender == null){
            return NoContent();
        }
        
        var dbModelAttacker = await _context.Models.Where(m => dbAttacker.ID == m.UnitID).FirstAsync();
        var dbModelDefender = await _context.Models.Where(m => dbDefender.ID == m.UnitID).FirstAsync();
        var dbRangedWeaponAttacker = await _context.RangedWeapons.Where(rw => dbModelAttacker.RangedWeaponId == rw.ID).FirstAsync();
        var dbMeleeWeaponAttacker = await _context.MeleeWeapons.FindAsync(dbModelAttacker.MeleeWeaponId);
        Unit unitAttacker = new(dbAttacker, dbModelAttacker, dbRangedWeaponAttacker, dbMeleeWeaponAttacker);
        Unit unitDefender = new(dbDefender, dbModelDefender);
        List<Unit> units = new();
        units.Add(unitAttacker);
        units.Add(unitDefender);
        return units;
    }
    
    private Values CalculateTotalHitsScored(int skill, ComplexValue attacks, ComplexValue sustainedHitsValue, bool hasTorrent){
        Values values = new();
        double totalAttacks = attacks.SolveValue();
        // hits from torrent (ranged weapons)
        if(hasTorrent){
            values.Normal = totalAttacks;
        }else{
            //normal hits + critical hits
            double normalHits = totalAttacks * (skill-1) / 6;
            values.Normal = normalHits;
            double criticalHits = totalAttacks / 6;
            values.Critical = criticalHits;
            // hits from sustained hits
            if(sustainedHitsValue.isNotZero()){
                double extraHits = criticalHits * sustainedHitsValue.SolveValue();
                values.Normal += extraHits;
            }
        }
        return values;
    }
    private Values CalculateTotalWoundsScored(int Strength, int Toughness, Values hits, bool hasLethalHits, int antiValue){
        //calculate toWound:
        Values values = new();
        int toWound = 4;
        if(Strength > Toughness){
            toWound = (Strength >= Toughness*2) ? 2 : 3;
        }else if(Strength < Toughness){
            toWound = (Strength*2 <= Toughness) ? 6 : 5;
        }
        if(hasLethalHits){
            values.Normal = hits.Critical;
        }else{
            values.Normal = hits.Critical * (toWound-1) / 6;
            values.Critical = hits.Critical / 6;
        }
        double normalWounds = hits.Normal * (toWound-1) / 6;
        values.Normal += normalWounds;
        double criticalWounds = hits.Normal / 6;
        values.Critical += criticalWounds;
        
        return values;
        //anti rule  to implement later
    }

}