namespace LivrariaCDC.WebAPI.Books;

public class NewBookRequest
{
    public string? Title { get; set; }
    public string? Resume { get; set; }
    public string? Summary { get; set; }
    public decimal? Price { get; set; }
    public int? Pages { get; set; }
    public string? Isbn { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? AuthorId { get; set; }

    public Book ToModel() => new (
        Title!,
        Resume!,
        Summary!,
        Price!.Value,
        Pages!.Value,
        Isbn!,
        ReleaseDate!.Value,
        CategoryId!.Value,
        AuthorId!.Value);
}
