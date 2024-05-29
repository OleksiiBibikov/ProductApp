using ProductApp.Shared;

namespace ProductApp.Data;

public class Provider : IEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string Country { get; set; }

    public int ZipCode { get; set; }

    public IEnumerable<Product> Products { get; set; }

    public Guid ProviderCratedBy { get; set; }
}