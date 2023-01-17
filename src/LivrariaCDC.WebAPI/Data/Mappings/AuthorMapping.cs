using LivrariaCDC.WebAPI.Authors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaCDC.WebAPI.Data.Mappings;

public class AuthorMapping : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");

        builder.HasKey(a => a.Id);

        builder
            .Property(p => p.Name)
            .IsRequired();

        builder
            .Property(p => p.Email)
            .IsRequired();

        builder
            .Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(400);

        builder
            .Property(p => p.CreatedAt)
            .IsRequired();

        builder.HasMany(a => a.Books)
            .WithOne(b => b.Author)
            .HasForeignKey(b => b.AuthorId);

        builder
            .HasIndex(p => p.Email)
            .IsUnique();
    }
}
