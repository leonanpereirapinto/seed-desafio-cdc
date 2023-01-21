namespace LivrariaCDC.WebAPI.Regions;

public class NewContryRequest
{
    public string? Name { get; set; }

    public Country ToModel() => new(Name!);
}