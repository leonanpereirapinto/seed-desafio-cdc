namespace LivrariaCDC.WebAPI.Authors;

public class NewAuthorRequest
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public Author ToModel() => new (Name!, Email!, Description!);
}
