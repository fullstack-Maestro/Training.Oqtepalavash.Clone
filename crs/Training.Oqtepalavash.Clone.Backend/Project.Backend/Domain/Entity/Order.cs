namespace Project.Backend.Domain.Entity;

public class Order
{
    public Guid Id { get; set; }

    public Product ProductId { get; set; }

    public int Count { get; set; }

    public Order(){}

    public Order(Guid id, Product productId, int count)
    {
        
        Id = id;
        
        ProductId = productId;
        
        Count = count;
    }
}
