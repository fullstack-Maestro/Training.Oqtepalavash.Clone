namespace Project.Backend.Domain.Entity;

public class Branches
{
    public Guid Id { get; set; }
   
    public string Name { get; set; }
    
    public Location Location { get; set; }
    
    public string Schedule { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public DateOnly Open { get; set; }
    
    public DateOnly Close { get; set; }

    public Branches(){}

    public Branches(Guid id, string name, Location location, string schedule, string phoneNumber, DateOnly open, DateOnly close)
    {
       
        Id = id;
        Name = name;
        Location = location;
        Schedule = schedule;
        PhoneNumber = phoneNumber;
        Open = open;
        Close = close;
    }
}