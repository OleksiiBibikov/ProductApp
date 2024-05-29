using ProductApp.Services.Responses;

namespace ProductApp.Services.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponse>> GetAllProducts();

        Task<IEnumerable<ProductResponse>> GetAllProductsByProvider(Guid providerId);

        Task<ProductResponse> GetById(Guid productId);

        //Task AddProduct(ProductResponse newProduct);

        //Task DeleteProduct(Guid productId);

        //Task<bool> CheckProductName(string productName);
    }
}
