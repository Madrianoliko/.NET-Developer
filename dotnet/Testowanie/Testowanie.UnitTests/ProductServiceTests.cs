using Moq;
using Testowanie.App;
using FluentAssertions;
using AutoFixture.Xunit2;

namespace Testowanie.UnitTests
{
    //public class FakeProductRepository : IProductRepository
    //{
    //    public Product GetProduct(int id)
    //    {
    //        return new Product(id, "Fake Product Name");
    //    }
    //}

    public class ProductServiceTests
    {
        [Fact]
        public void GetProduct_ShouldReturnProduct()
        {
            int productId = 1;
            var productRepositoryMock = new Mock<IProductRepository>(); // inicjalizacja dependencji
            productRepositoryMock.Setup(x => x.GetProduct(productId)).Returns(new Product(1, "Product Name")); // konfiguracja mocka
            var productService = new ProductService(productRepositoryMock.Object);

            var product = productService.GetProduct(productId);

            Assert.Equal(productId, product.Id);
            Assert.IsType<Product>(product);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void GetProduct_ShouldReturnProduct_V2(int productId)
        {
            var productRepositoryMock = new Mock<IProductRepository>(); // inicjalizacja dependencji
            productRepositoryMock.Setup(x => x.GetProduct(productId)).Returns(new Product(productId, "Product Name")); // konfiguracja mocka
            var productService = new ProductService(productRepositoryMock.Object);

            var product = productService.GetProduct(productId);

            product.Id.Should().Be(productId);
            product.Name.Should().Be("Product Name");
            product.Should().BeOfType<Product>();
        }

        [Theory, AutoData]
        public void GetProduct_ShouldReturnProduct_V3(int productId)
        {
            var productRepositoryMock = new Mock<IProductRepository>(); // inicjalizacja dependencji
            productRepositoryMock.Setup(x => x.GetProduct(productId)).Returns(new Product(productId, "Product Name")); // konfiguracja mocka
            var productService = new ProductService(productRepositoryMock.Object);

            var product = productService.GetProduct(productId);

            product.Id.Should().Be(productId);
            product.Name.Should().Be("Product Name");
            product.Should().BeOfType<Product>();
        }
    }
}
