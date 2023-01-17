using LivrariaCDC.WebAPI.Authors;
using LivrariaCDC.WebAPI.Categories;
using LivrariaCDC.WebAPI.Common;

namespace LivrariaCDC.WebAPI.Books;

public class Book : Entity
{
    public string Title { get; private set; }
    public string Resume { get; private set; }
    public string Summary { get; private set; }
    public decimal Price { get; private set; }
    public int Pages { get; private set; }
    public string Isbn { get; private set; }
    public DateTime ReleaseDate { get; private set; }
    public Category Category { get; private set; }
    public Guid CategoryId { get; private set; }
    public Author Author { get; private set; }
    public Guid AuthorId { get; private set; }

    public Book(string title, string resume, string summary, decimal price, int pages, string isbn, DateTime releaseDate, Guid category, Guid author)
    {
        Title = title;
        Resume = resume;
        Summary = summary;
        Price = price;
        Pages = pages;
        Isbn = isbn;
        ReleaseDate = releaseDate;
        CategoryId = category;
        AuthorId = author;
    }

    private Book()
    {

    }
}
