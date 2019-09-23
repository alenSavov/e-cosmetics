using AutoMapper;
using e_cosmetics.Models;
using e_cosmetics.Services.Categories.Models;
using e_cosmetics.Services.Pictures.Models;
using e_cosmetics.Services.Products.Models;

namespace e_cosmetics.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Category, CreateCategoryInputModel>().ReverseMap();

            CreateMap<Category, EditCategoryInputModel>().ReverseMap();

            CreateMap<CategoryPicture, BasePictureViewModel>()
                .ForMember(d => d.CategoryId, x => x.MapFrom(s => s.CategoryId));




            CreateMap<Product, CreateProductInputModel>().ReverseMap();
            
            CreateMap<Product, ProductViewModel>()
                 .ForMember(d => d.Pictures, x => x.MapFrom(s => s.ProductPictures))
                .ReverseMap();

            CreateMap<ProductPicture, ProductPictureViewModel>()
           .ForMember(d => d.ProductId, x => x.MapFrom(s => s.ProductId));
        }
    }
}
