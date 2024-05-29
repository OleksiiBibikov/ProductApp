namespace ProductApp.Services.Responses
{
    public class ProductResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Guid ProviderId { get; set; }

        public int Quantity { get; set; }

        public ProductStateResponse State { get; set; }

        public Guid StateChangedBy { get; set; }
    }
}
