using Project.Backend.Domain.Enums;

namespace Project.Backend.Domain.Entity;

public class OrderHistory
{
    public Guid UserId { get; set; }

    public Product Order { get; set; }

    public decimal Summa { get; set; }

    public Status Status { get; set; }

    public OrderHistory(){}

    public OrderHistory(Guid userId, Product order, decimal summa, Status status)
    {
        UserId = userId;
        Order = order;
        Summa = summa;
        Status = status;
    }
}