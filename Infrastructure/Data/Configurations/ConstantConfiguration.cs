using Domain.Entities.Global;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

internal class ConstantConfiguration : IEntityTypeConfiguration<ConstantEntity>
{
    public void Configure(EntityTypeBuilder<ConstantEntity> builder)
    {
        builder.HasKey(e => e.Code);

        builder.Property(e => e.Code).ValueGeneratedNever();

        builder
            .HasIndex(new[]{
                        nameof(ConstantEntity.Type),
                        nameof(ConstantEntity.Name)
             })
            .IsUnique();
    }
}
