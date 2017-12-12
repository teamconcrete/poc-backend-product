using Ecommerce.Domain.Entities;
using Ecommerce.Domain.ExternalServices;
using Ecommerce.Domain.ExternalServices.Requests;
using Ecommerce.Domain.Interfaces.Service;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Ecommerce.Domain.ExternalServices.Models;

namespace Ecommerce.Domain.Services
{
    public class ProductService : IProductService
    {
        IProductExternalService _externalService;

        public ProductService(IProductExternalService externalService)
        {
            _externalService = externalService;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var random = new Random();
            var ids = new List<int>();

            for (var i = 0; i < 20; i++)
                ids.Add(random.Next(10000, 20000));

            var obterProdutosPorIdsRequest = new ObterProdutosPorIdsRequest()
            {
                IdsProdutos = ids.ToArray(),
                Composicao = new Composicao()
                {
                    Imagens = true
                }
            };

            var serviceResult = await _externalService.ObterProdutosPorIds(obterProdutosPorIdsRequest);

            var products = serviceResult.Produtos?.Select(p => new Product()
            {
                Id = p.IdProduto,
                Description = p.Descricao,
                Name = p.Nome,
                ImageUrl = p.Imagens?.FirstOrDefault()?.Url
            });

            return products;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var obterProdutoRequest = new ObterProdutoRequest()
            {
                IdProduto = id,
                Composicao = new Composicao()
                {
                    Imagens = true
                }
            };

            var result = await _externalService.ObterProduto(obterProdutoRequest);

            return new Product()
            {
                Id = result.Produto.IdProduto,
                Description = result.Produto.Descricao,
                Name = result.Produto.Nome,
                ImageUrl = result.Produto?.Imagens?.FirstOrDefault()?.Url
            };
        }

        public async Task<Product> GetBySkuAsync(int sku)
        {
            var obterProdutoRequest = new ObterProdutoRequest()
            {
                IdSku = sku,
                Composicao = new Composicao()
                {
                    Imagens = true
                }
            };

            var result = await _externalService.ObterProduto(obterProdutoRequest);

            return new Product()
            {
                Id = result.Produto.IdProduto,
                Description = result.Produto.Descricao,
                Name = result.Produto.Nome,
                ImageUrl = result.Produto?.Imagens?.FirstOrDefault()?.Url
            };
        }
    }
}

