using ProductApp.Data;
using ProductApp.Services.Abstract;
using ProductApp.Services.Responses;
using ProductApp.Shared.Abstract;

namespace ProductApp.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Provider> _providerRepository;

        public ProductService(IRepository<Product> productRepository, IRepository<Provider> providerRepository)
        {
            _productRepository = productRepository;
            _providerRepository = providerRepository;
        }

        public async Task<IEnumerable<ProductResponse>> GetAllProducts()
        {
            var products =  await _productRepository.GetAllAsync();

            return products.Select(p => new ProductResponse
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                StateChangedBy = p.StateChangedBy,
                Price = p.Price,
            });
        }

        public Task<IEnumerable<ProductResponse>> GetAllProductsByProvider(Guid providerId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponse> GetById(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
