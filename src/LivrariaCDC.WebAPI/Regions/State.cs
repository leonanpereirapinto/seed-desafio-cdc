using LivrariaCDC.WebAPI.Common;

namespace LivrariaCDC.WebAPI.Regions;

public class State : Entity
{
    public State(string name, Guid countryId)
    {
        Name = name;
        CountryId = countryId;
    }

    private State() { }

    public string Name { get; private set; }
    public Guid CountryId { get; private set; }
    public Country Country { get; private set; }
}
