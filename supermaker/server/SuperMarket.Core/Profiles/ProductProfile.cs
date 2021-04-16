using AutoMapper;
using Supermarket.Core.Models;

namespace SuperMarket.Core.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductUpdateDto, Product>();
        }
    }
}