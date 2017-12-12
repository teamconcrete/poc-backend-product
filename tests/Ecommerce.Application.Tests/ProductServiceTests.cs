using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Tests.Helpers;
using Xunit;
using Ecommerce.Domain.ExternalServices;
using Ecommerce.Domain.ExternalServices.Requests;
using Ecommerce.Domain.ExternalServices.Responses;
using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Services;

namespace Ecommerce.Domain.Tests
{
    public class ProductServiceTests
    {
        private MockRepository _mockRepository;
        private Mock<IProductExternalService> _productExternalService;
        private IProductService _productService;

        public ProductServiceTests()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _productExternalService = _mockRepository.Create<IProductExternalService>();
            _productService = new ProductService(_productExternalService.Object);
        }

        [Fact(DisplayName = "ObterPorId_ShouldReturnSuccessfully")]
        public async Task ObterPorId_ShouldReturnSuccessfully()
        {
            var mockProduct = ProductHelper.GenerateExternalProdutos(1).ToList().FirstOrDefault();
            var response = new ObterProdutoResponse()
            {
                Produto = mockProduct
            };

            _productExternalService.Setup(x => x.ObterProduto(It.IsAny<ObterProdutoRequest>())).Returns(Task.FromResult(response));

            var product = await _productService.GetByIdAsync(mockProduct.IdProduto);

            Assert.NotNull(product);
            Assert.Equal(product.Id, mockProduct.IdProduto);
            _mockRepository.VerifyAll();
        }

        [Fact(DisplayName = "ObterPorSku_ShouldReturnSuccessfully")]
        public async Task ObterPorSku_ShouldReturnSuccessfully()
        {
            var mockProduct = ProductHelper.GenerateExternalProdutos(1).ToList().FirstOrDefault();
            var response = new ObterProdutoResponse()
            {
                Produto = mockProduct
            };

            _productExternalService.Setup(x => x.ObterProduto(It.IsAny<ObterProdutoRequest>())).Returns(Task.FromResult(response));

            var product = await _productService.GetByIdAsync(mockProduct.IdProduto);

            Assert.NotNull(product);
            Assert.Equal(product.Id, mockProduct.IdProduto);
            _mockRepository.VerifyAll();
        }

        [Fact(DisplayName = "ObterPorIds_ShouldReturnSuccessfully")]
        public async Task ObterPorIds_ShouldReturnSuccessfully()
        {
            var mockProducts = ProductHelper.GenerateExternalProdutos(10).ToList();
            var response = new ObterProdutosPorIdsResponse()
            {
                Produtos = mockProducts.ToArray()
            };

            _productExternalService.Setup(x => x.ObterProdutosPorIds(It.IsAny<ObterProdutosPorIdsRequest>())).Returns(Task.FromResult(response));

            var products = await _productService  .GetAllAsync();

            Assert.NotNull(products);
            Assert.Equal(mockProducts.Count(), products.Count());
            _mockRepository.VerifyAll();
        }
    }
}
