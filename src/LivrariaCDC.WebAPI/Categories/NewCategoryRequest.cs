using System.ComponentModel.DataAnnotations;

namespace LivrariaCDC.WebAPI.Categories;

public class NewCategoryRequest
{
    [Required]
    public string? Name { get; set; }

    public Category ToModel()
    {
        return new Category(Name);
    }
}