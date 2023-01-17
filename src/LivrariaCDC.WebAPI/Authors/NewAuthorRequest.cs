using System.ComponentModel.DataAnnotations;

namespace LivrariaCDC.WebAPI.Authors;

public class NewAuthorRequest
{
    [Required]
    public string? Name { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    [MaxLength(400)]
    public string? Description { get; set; }

    public Author ToModel()
    {
        return new Author(Name, Email, Description);
    }
}