using Domain.Entities.Global;
using Domain.Entities.Service;
using Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext: DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ServiceEntity> Services { get; set; } = null!;
    public DbSet<ConstantEntity> Constants { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        modelBuilder.SeedsDatabase();

        base.OnModelCreating(modelBuilder);
    }
}
