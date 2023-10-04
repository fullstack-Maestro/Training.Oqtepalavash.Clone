namespace Project.Backend.Domain.Entity;

public class User
{
    public Guid Id { get; set; }

    public int RoleId { get; set; }

    public string Name { get; set; }

    public string PhoneNumber { get; set; }

    public DateTime? BirthDate { get; set; }

    public List<Location>? Location;

    public User(){}

    public User(Guid id, int roleId, string name, string phoneNumber, DateTime? birthDate)
    {
        Id = id;
        RoleId = roleId;
        Name = name;
        PhoneNumber = phoneNumber;
        BirthDate = birthDate;
    }
}