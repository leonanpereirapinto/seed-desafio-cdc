namespace LivrariaCDC.WebAPI.Books;

public class BooksResponse
{
    public BooksResponse(List<Book> books)
    {
        Books = books.Select(b => new BookResponse(b));
    }

    public IEnumerable<BookResponse> Books { get; set; }
}

public class BookResponse
{
    public BookResponse(Book book)
    {
        Id = book.Id;
        Title = book.Title;
        Summary = book.Summary;
        Indice = book.Indice;
        Price = book.Price;
        Pages = book.Pages;
        Isbn = book.Isbn;
        ReleaseDate = book.ReleaseDate;
        CategoryId = book.CategoryId;
        AuthorId = book.AuthorId;
    }

    public Guid? Id { get; set; }
    public string? Title { get; set; }
    public string? Summary { get; set; }
    public string? Indice { get; set; }
    public decimal? Price { get; set; }
    public int? Pages { get; set; }
    public string? Isbn { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? AuthorId { get; set; }
}
