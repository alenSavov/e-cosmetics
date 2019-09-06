using AutoMapper;
using e_cosmetics.Models;
using e_cosmetics.Services.Categories.Models;

namespace e_cosmetics.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            //CreateMap<Product, CategoryViewModel>().ReverseMap();
        }
    }
}
