using LivrariaCDC.WebAPI.Authors;
using LivrariaCDC.WebAPI.Categories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LivrariaCDC.WebAPI.Books;

public class BookDetailResponse
{
    public BookDetailResponse(Book book)
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
        Category = new CategoryResponse(book.Category);
        Author = new AuthorResponse(book.Author);
    }

    public Guid? Id { get; }
    public string? Title { get; }
    public string? Summary { get; }
    public string? Indice { get; }
    public decimal? Price { get; }
    public int? Pages { get; }
    public string? Isbn { get; }
    public DateTime? ReleaseDate { get; }
    public Guid? CategoryId { get; }
    public Guid? AuthorId { get; }
    public CategoryResponse Category { get; }
    public AuthorResponse Author { get; }
}

public class CategoryResponse 
{
    public CategoryResponse(Category category)
    {
        Id = category.Id;
        Name = category.Name;
    }

    public Guid Id { get; }
    public string Name { get; }
}

public class AuthorResponse
{
    public AuthorResponse(Author author)
    {
        Id = author.Id;
        Name = author.Name;
        Email = author.Email;
        Description = author.Description;
    }

    public Guid Id { get; }
    public string Name { get; }
    public string Email { get; }
    public string Description { get; }
}

