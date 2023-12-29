using calculator40k.Models;
using calculator40k.DbModels;
using dmgCalculatorAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dmgCalculatorAPI.Controllers;

[ApiController]
[Route("/return")]
public class ReturnController : ControllerBase{

    private readonly ApiContext _context;

    public ReturnController(ApiContext context){
        _context = context;
    }

    [HttpGet("/db/units")]
    public async Task<ActionResult<IEnumerable<DbUnit>>> GetAllDbUnits(){
        var units = await _context.Units.ToListAsync();
        if(units != null){
            return units;
        }
        return NoContent();
    }

    [HttpGet("/db/models")]
    public async Task<ActionResult<IEnumerable<DbModel>>> GetAllDbModels(){
        var models = await _context.Models.ToListAsync();
        if(models != null){
            return models;
        }
        return NoContent();
    }
    [HttpGet("/db/melee-weapons")]
    public async Task<ActionResult<IEnumerable<DbMeleeWeapon>>> GetAllDbMeleeWeapons(){
        var meleeWeapons = await _context.MeleeWeapons.ToListAsync();
        if(meleeWeapons != null){
            return meleeWeapons;
        }
        return NoContent();
    }
    [HttpGet("/db/ranged-weapons")]
    public async Task<ActionResult<IEnumerable<DbRangedWeapon>>> GetAllDbRangedWeapons(){
        var rangedWeapons = await _context.RangedWeapons.ToListAsync();
        if(rangedWeapons != null){
            return rangedWeapons;
        }
        return NoContent();
    }
    [HttpGet("/units")]
    public async Task<ActionResult<IEnumerable<Unit>>> GetAllUnits(){
        var dbUnits = await _context.Units.ToListAsync();
        if(dbUnits == null){
            return NoContent();
        }
        List<Unit> units = new();
        foreach (var dbUnit in dbUnits)
        {
            var dbModel = await _context.Models.Where(m => dbUnit.ID == m.UnitID).FirstAsync();
            var dbRangedWeapon = await _context.RangedWeapons.Where(rw => dbModel.RangedWeaponId == rw.ID).FirstAsync();
            var dbMeleeWeapon = await _context.MeleeWeapons.FindAsync(dbModel.MeleeWeaponId);
            //change to use dbRW, dbMw
            Unit unit = new Unit(dbUnit, dbModel, dbRangedWeapon, dbMeleeWeapon);
            units.Add(unit);
        }
        return units;
    }

    
}