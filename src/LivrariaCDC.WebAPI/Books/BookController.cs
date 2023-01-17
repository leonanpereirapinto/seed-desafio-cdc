using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Books;

[ApiController]
[Route("[controller]")]
// 7
public class BookController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public BookController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetBooks")]
    public async Task<IActionResult> Get()
    {
        var books = await _context.Books.ToListAsync();
        return Ok(new BooksResponse(books)); // 1
    }

    [HttpPost(Name = "PostBook")]
    public async Task<IActionResult> Post(NewBookRequest newBook) // 1
    {
        await _context.AddAsync(newBook.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("{id}", Name = "GetBook")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var book = await _context.Books
            .Include(b => b.Category) // 1
            .Include(b => b.Author) // 1
            .FirstOrDefaultAsync(b => b.Id == id); // 1

        if (book is null) // 1
            return NotFound();

        return Ok(new BookDetailResponse(book)); // 1
    }
}