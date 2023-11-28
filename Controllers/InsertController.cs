using calculator40k.Models;
using calculator40k.DbModels;
using dmgCalculatorAPI.Models;
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
}