using Microsoft.EntityFrameworkCore;

namespace FN.WorkShopNetCoreAngular.Data.EF;

public class WorkShopNetCoreAngularDbContext : DbContext
{
    public WorkShopNetCoreAngularDbContext()
    {
        this.Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(
                "Server=localhost,1433;Database=WorkShopAngularNetCore6DB;User ID=sa;Password=123456@qwerty"
                );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Maps.ClienteMap());
        modelBuilder.Seed();
    }
}