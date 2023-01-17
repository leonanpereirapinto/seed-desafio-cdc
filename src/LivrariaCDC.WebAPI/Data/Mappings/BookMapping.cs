using LivrariaCDC.WebAPI.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaCDC.WebAPI.Data.Mappings;

public class BookMapping : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books");

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Title)
            .IsRequired();

        builder.Property(b => b.Summary)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(b => b.Price).IsRequired();
        builder.Property(b => b.Pages).IsRequired();
        builder.Property(b => b.Isbn).IsRequired();
        builder.Property(b => b.ReleaseDate).IsRequired();

        builder.HasOne(b => b.Category)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.CategoryId);

        builder.HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

        builder.HasIndex(b => b.Title).IsUnique();
        builder.HasIndex(b => b.Isbn).IsUnique();
    }
}
