namespace Project.Backend.Domain.Entity;

public class Product
{
    public Guid Id { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public Enum Catalog { get; set; }

    public Product() { }

    public Product(Guid id, string productName, decimal productPrice, Enum catalog)
    {
        Id = id;
        ProductName = productName;
        ProductPrice = productPrice;
        Catalog = catalog;
    }   
}