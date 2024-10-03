using Domain.Entities.Global;
using Infrastructure.Data.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Extensions;

internal static class ModelBuilderExtensions
{
    public static void SeedsDatabase(this ModelBuilder builder)
    {
        var constants = ConstantSeed.InitialValues();
        builder.Entity<ConstantEntity>().HasData(constants);
    }
}
