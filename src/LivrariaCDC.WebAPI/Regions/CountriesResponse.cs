namespace LivrariaCDC.WebAPI.Regions;

public class CountriesResponse
{
    public IEnumerable<CountryResponse> Countries { get; }
    public CountriesResponse(List<Country> countries)
    {
        Countries = countries.Select(c => new CountryResponse(c));
    }
}

public class CountryResponse
{
    public Guid Id { get; }
    public string Name { get; }
    public IEnumerable<StateResponse> States { get; }

    public CountryResponse(Country country)
    {
        Id = country.Id;
        Name = country.Name;
        States = country.States.Select(s => new StateResponse(s));
    }
}

public class StateResponse
{
    public Guid Id { get; }
    public string Name { get; }

    public StateResponse(State state)
    {
        Id = state.Id;
        Name = state.Name;
    }
}