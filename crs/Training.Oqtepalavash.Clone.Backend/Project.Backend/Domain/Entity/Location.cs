namespace Project.Backend.Domain.Entity;

public class Location
{
    public Enum Hudud { get; set; }
    
    public string Town { get; set; }
    
    public string Street { get; set; }

    public string Podyez { get; set; }

    public Location() { }

    public Location(Enum hudud, string town, string street, string podyez)
    {
        Hudud = hudud;
        Town = town;
        Street = street;
        Podyez = podyez;
    }
}