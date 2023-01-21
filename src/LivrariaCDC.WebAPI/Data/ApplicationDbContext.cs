using LivrariaCDC.WebAPI.Authors;
using LivrariaCDC.WebAPI.Books;
using LivrariaCDC.WebAPI.Categories;
using LivrariaCDC.WebAPI.Regions;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<State> States { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
