using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Regions;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CountryController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetCountries")]
    public async Task<IActionResult> Get()
    {
        var countries = await _context.Countries.Include(c => c.States).ToListAsync();

        return Ok(new CountriesResponse(countries));
    }

    [HttpPost(Name = "PostCountry")]
    public async Task<IActionResult> Post(NewContryRequest newContry) // 1
    {
        await _context.Countries.AddAsync(newContry.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }
}
