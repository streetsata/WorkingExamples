using AutoMapper;
using Streetsata.Restaurant.ProductAPI.Models;
using Streetsata.Restaurant.ProductAPI.Models.Dto;

namespace Streetsata.Restaurant.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
