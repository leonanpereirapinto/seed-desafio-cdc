using LivrariaCDC.WebAPI.Regions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Data.Mappings;

public class StateMapping : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("States");

        builder.HasKey(s => s.Id);

        builder
            .Property(s => s.Name)
            .IsRequired();

        builder.HasOne(s => s.Country)
            .WithMany(c => c.States)
            .HasForeignKey(s => s.CountryId);

        builder
            .HasIndex(s => s.Name)
            .IsUnique();
    }
}
