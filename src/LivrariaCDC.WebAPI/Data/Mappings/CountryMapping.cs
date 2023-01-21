using LivrariaCDC.WebAPI.Categories;
using LivrariaCDC.WebAPI.Regions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaCDC.WebAPI.Data.Mappings;

public class CountryMapping : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Countries");

        builder.HasKey(c => c.Id);

        builder
            .Property(c => c.Name)
            .IsRequired();

        builder.HasMany(c => c.States)
            .WithOne(s => s.Country)
            .HasForeignKey(s => s.CountryId);

        builder
            .HasIndex(c => c.Name)
            .IsUnique();
    }
}
