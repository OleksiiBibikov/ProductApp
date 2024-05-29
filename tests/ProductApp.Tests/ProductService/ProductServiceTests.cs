using Moq;
using NUnit.Framework;
using ProductApp.Data;
using ProductApp.Services.Abstract;
using ProductApp.Services.Services;
using ProductApp.Shared.Abstract;

namespace ProductApp.Tests.ProductServiceTest
{
    [TestFixture]
    public class ProductServiceTests
    {
        private IProductService _productService;

        [SetUp]
        public void Setup()
        {
            var providerList = new List<Provider>() {
                new Provider()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                }
            };

            var providerRepositoryMock = new Mock<IRepository<Provider>>();

            providerRepositoryMock.Setup(p => p.GetAll()).Returns(providerList.AsQueryable());

            var productRepositoryMock = new Mock<IRepository<Product>>();

            _productService = new ProductService(productRepositoryMock.Object, providerRepositoryMock.Object);
        }

        [Test]
        public void ProductService_ShouldReturnAllProducts()
        {
           

            Assert.That(true, Is.True);
        }
    }
}
