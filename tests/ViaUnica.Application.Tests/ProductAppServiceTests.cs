using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;
using ViaUnica.Domain.Entities;
using ViaUnica.Domain.Interfaces.Service;
using ViaUnica.Domain.Validation;
using ViaUnica.Tests.Helpers;
using Xunit;

namespace ViaUnica.Application.Tests
{
    public class ProductAppServiceTests
    {
        private MockRepository _mockRepository;
        private ProductAppService _productAppService;
        private Mock<IProductService> _productService;

        public ProductAppServiceTests()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _productService = _mockRepository.Create<IProductService>();
            _productAppService = new ProductAppService(_productService.Object);
        }

        [Fact]
        public async Task GetAsync_ShouldReturnSuccessfully()
        {
            var mockProduct = ProductHelper.GenerateProducts(1).ToList().FirstOrDefault();

            _productService.Setup(x => x.GetAsync(mockProduct.Id)).Returns(Task.FromResult(mockProduct));

            var product = await _productAppService.GetAsync(mockProduct.Id);

            Assert.NotNull(product);
            Assert.Equal(product.Id, mockProduct.Id);
            _mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnSuccessfully()
        {
            var mockProducts = ProductHelper.GenerateProducts(10);

            _productService.Setup(x => x.GetAllAsync()).Returns(Task.FromResult(mockProducts));

            var products = await _productAppService.GetAllAsync();

            Assert.NotNull(products);
            Assert.Equal(mockProducts.Count(), products.Count());
            _mockRepository.VerifyAll();
        }

        [Fact]
        public async Task FindAsync_ShouldReturnSuccessfully()
        {
            var mockProducts = ProductHelper.GenerateProducts(10);
            Func<Product, bool> predicate = x => x.Description != null;

            _productService.Setup(x => x.FindAsync(predicate)).Returns(Task.FromResult(mockProducts));

            var products = await _productAppService.FindAsync(predicate);

            Assert.NotNull(products);
            Assert.Equal(mockProducts.Count(), products.Count());
            _mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CreateAsync_ShouldCreateSuccessfully()
        {
            var mockProduct = ProductHelper.GenerateProducts(1).ToList().FirstOrDefault();

            _productService.Setup(x => x.AddAsync(mockProduct)).Returns(Task.FromResult(new ValidationResult()));

            var result = await _productAppService.CreateAsync(mockProduct);            
            
            _mockRepository.VerifyAll();
        }

        [Fact]
        public async Task UpdateAsync_ShouldCreateSuccessfully()
        {
            var mockProduct = ProductHelper.GenerateProducts(1).ToList().FirstOrDefault();

            _productService.Setup(x => x.UpdateAsync(mockProduct)).Returns(Task.FromResult(new ValidationResult()));

            var result = await _productAppService.UpdateAsync(mockProduct);

            _mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteAsync_ShouldCreateSuccessfully()
        {
            var mockProduct = ProductHelper.GenerateProducts(1).ToList().FirstOrDefault();

            _productService.Setup(x => x.DeleteAsync(mockProduct)).Returns(Task.FromResult(new ValidationResult()));

            var result = await _productAppService.DeleteAsync(mockProduct);

            _mockRepository.VerifyAll();
        }
    }
}
