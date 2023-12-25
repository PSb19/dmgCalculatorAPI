using calculator40k.Models;
using calculator40k.DbModels;
using dmgCalculatorAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dmgCalculatorAPI.Controllers;

[ApiController]
[Route("/Insert")]
public class InsertController : ControllerBase{

    private readonly ApiContext _context;

    public InsertController(ApiContext context){
        _context = context;
    }

    [HttpGet("/return")]
    public async Task<ActionResult<IEnumerable<DbUnit>>> GetAllUnits(){
        var units = await _context.Units.ToListAsync();

        if(units != null){
            return units;
        }
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<DbUnit>> AddNewUnit(DbUnit unit){
        //check unit validity
        // return unit;
        //TODO: validation etc
        _context.Units.Add(unit);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPost("/new")]
    public async Task<ActionResult<Unit>> AddNewFullUnit(Unit unit){
        if(unit.Model == null 
                || unit.Model.RangedWeapon == null 
                || unit.Model.MeleeWeapon == null){
            return NotFound();
        }
        DbUnit dbUnit = new(unit);
        _context.Units.Add(dbUnit);

        DbRangedWeapon dbRangedWeapon = new(unit.Model.RangedWeapon);
        _context.RangedWeapons.Add(dbRangedWeapon);

        DbMeleeWeapon dbMeleeWeapon = new(unit.Model.MeleeWeapon);
        _context.MeleeWeapons.Add(dbMeleeWeapon);

        await _context.SaveChangesAsync();

        DbModel dbModel = new(unit.Model, dbUnit.ID, dbRangedWeapon.ID, dbMeleeWeapon.ID);
        _context.Models.Add(dbModel);
        await _context.SaveChangesAsync();

        return unit;
    }
}