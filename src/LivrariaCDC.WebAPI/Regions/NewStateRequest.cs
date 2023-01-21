namespace LivrariaCDC.WebAPI.Regions;

public class NewStateRequest
{
    public string? Name { get; set; }
    public Guid CountryId { get; set; }

    public State ToModel() => new(Name!, CountryId);
}