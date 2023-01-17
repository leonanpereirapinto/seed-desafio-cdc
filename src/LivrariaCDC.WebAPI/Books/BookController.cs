using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Books;

[ApiController]
[Route("[controller]")]
// 1
public class BookController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public BookController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost(Name = "PostBook")]
    public async Task<IActionResult> Post(NewBookRequest newBook) // 1
    {
        await _context.AddAsync(newBook.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }
}