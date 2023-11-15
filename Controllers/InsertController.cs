using dmgCalculatorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace dmgCalculatorAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class InsertController : ControllerBase{

    private ApiContext _context;

    public InsertController(ApiContext context){
        _context = context;
    }

}