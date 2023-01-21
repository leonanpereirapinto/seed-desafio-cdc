using LivrariaCDC.WebAPI.Common;

namespace LivrariaCDC.WebAPI.Regions;

public class Country : Entity
{
    public string Name { get; private set; }

    public List<State> States { get; private set; }

    public Country(string name)
    {
        Name = name;
        States = new List<State>();
    }

    public void AddState(State state)
    {
        States.Add(state);
    }
}
