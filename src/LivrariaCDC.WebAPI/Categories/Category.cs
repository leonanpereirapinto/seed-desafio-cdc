using LivrariaCDC.WebAPI.Books;
using LivrariaCDC.WebAPI.Common;

namespace LivrariaCDC.WebAPI.Categories;

public class Category : Entity
{
    public string Name { get; private set; }

    public List<Book>? Books { get; private set; }

    public Category(string name)
    {
        Name = name;
    }

    private Category()
    {

    }
}
