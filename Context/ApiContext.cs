using calculator40k.DbModels;
using Microsoft.EntityFrameworkCore;

namespace dmgCalculatorAPI.Context;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
    {}

    public DbSet<DbUnit> Units { get; set; } = null!;
    public DbSet<DbModel> Models { get; set; } = null!;
    public DbSet<DbMeleeWeapon> MeleeWeapons { get; set; } = null!;
    public DbSet<DbRangedWeapon> RangedWeapons { get; set; } = null!;
}