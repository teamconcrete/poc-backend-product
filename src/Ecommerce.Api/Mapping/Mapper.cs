using AutoMapper;
using Ecommerce.Api.Requests;
using Ecommerce.Domain.Entities;
using System;

namespace Ecommerce.Api.Mapping
{
    public static class Map
    {
        private static MapperConfiguration config;

        public static IMapper GetMapper()
        {
            if (config == null)
                Configure();

            var mapper = config.CreateMapper();

            return mapper;
        }
            
        private static void Configure()
        {
            config = new MapperConfiguration(c => {
                c.CreateMap<ProductRequest, Product>();
            });
        }
    }
}
