namespace Project.Backend.Domain.Entity;

public class Card
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public bool IsOrdered { get; set; }

    public Location Location { get; set; }

    public Order Order { get; set; }
   
    public bool DeliveryStatus { get; set; }

    public Card() { }

    public Card(Guid id, Guid userId, bool isOrdered, Location location, Order order, bool deliveryStatus)
    {
        Id = id;
        UserId = userId;
        IsOrdered = isOrdered;
        Location = location;
        Order = order;
        DeliveryStatus = deliveryStatus;
    }
}