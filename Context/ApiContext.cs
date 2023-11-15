using calculator40k.Models;
using Microsoft.EntityFrameworkCore;

namespace dmgCalculatorAPI.Models;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
    {
    }

    public DbSet<Unit> Units { get; set; } = null!;
}