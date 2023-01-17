using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LivrariaCDC.WebAPI.Categories;

namespace LivrariaCDC.WebAPI.Data.Mappings;

public class CategoryMapping : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(a => a.Id);

        builder
            .Property(p => p.Name)
            .IsRequired();

        builder
            .HasIndex(p => p.Name)
            .IsUnique();
    }
}
