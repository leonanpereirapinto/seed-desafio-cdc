using LivrariaCDC.WebAPI.Entities;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace LivrariaCDC.WebAPI
{
    public class NewAuthorRequest
    {
        [Required]
        [NotNull]
        public string? Name { get; set; }

        [Required]
        [NotNull]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [NotNull]
        [MaxLength(400)]
        public string? Description { get; set; }

        public Author ToModel()
        {
            return new Author(Name, Email, Description);
        }
    }
}