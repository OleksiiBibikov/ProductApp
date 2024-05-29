using ProductApp.Shared;

namespace ProductApp.Data;

public enum ProductState
{
    None,
    Created,
    Approved,
    Deployed,
    Available,
    NotAvailable
}

public class Product : IEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public Guid ProviderId { get; set; }

    public int Quantity { get; set; }

    public ProductState State { get; set; }

    public Guid StateChangedBy { get; set; }

    public Provider Provider { get; set; }
}