using AutoMapper;
using Supermarket.Core.Models;

namespace Supermarket.Core.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryUpdateDto, Category>();
        }
    }
}