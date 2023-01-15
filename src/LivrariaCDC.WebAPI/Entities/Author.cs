namespace LivrariaCDC.WebAPI.Entities;

public class Author
{
    public Author(string name, string email, string description)
    {
        // TODO: validations
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
        Name = name;
        Email = email;
        Description = description;
    }

    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Description { get; private set; }
}
