using AutoMapper;
using e_cosmetics.Models;
using e_cosmetics.Services.Categories.Models;
using e_cosmetics.Services.Products.Models;

namespace e_cosmetics.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Category, CreateCategoryInputModel>().ReverseMap()
                 .ForMember(dest => dest.Picture, opt => opt.Ignore()); ;

            CreateMap<Category, EditCategoryInputModel>().ReverseMap();

            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
