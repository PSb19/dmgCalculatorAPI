using calculator40k.Models;
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
    public async Task<ActionResult<IEnumerable<Unit>>> GetAllUnits(){
        var units = await _context.Units.ToListAsync();

        if(units != null){
            return units;
        }
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Unit>> AddNewUnit(Unit unit){
        //check unit validity
        return unit;
        //TODO: Make this work - every class saved to db has to have key etc
        _context.Units.Add(unit);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}