using LivrariaCDC.WebAPI.Books;
using LivrariaCDC.WebAPI.Common;

namespace LivrariaCDC.WebAPI.Authors;

public class Author : Entity
{
    public Author(string name, string email, string description)
    {
        CreatedAt = DateTime.Now;
        Name = name;
        Email = email;
        Description = description;
    }

    private Author()
    {

    }

    public DateTime CreatedAt { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Description { get; private set; }

    public List<Book>? Books { get; private set; }
}
