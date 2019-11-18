using AutoMapper;
using e_cosmetics.Models;
using e_cosmetics.Services.Articles.Models;
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

            CreateMap<Category, EditCategoryViewModel>().ReverseMap();

            CreateMap<CategoryPicture, BasePictureViewModel>()
                .ForMember(d => d.EntityId, x => x.MapFrom(s => s.CategoryId));


            CreateMap<Product, CreateProductInputModel>().ReverseMap();

            CreateMap<Product, ProductViewModel>()
                 .ForMember(d => d.Pictures, x => x.MapFrom(s => s.ProductPictures))
                .ReverseMap();

            CreateMap<Product, EditProductViewModel>()
               .ForMember(d => d.Pictures, x => x.MapFrom(s => s.ProductPictures))
              .ReverseMap();

            CreateMap<ProductViewModel, EditProductViewModel>().ReverseMap();

            CreateMap<ProductPicture, ProductPictureViewModel>()
           .ForMember(d => d.ProductId, x => x.MapFrom(s => s.ProductId));



            CreateMap<Article, ArticleInputModel>().ReverseMap();

            CreateMap<Article, ArticleViewModel>().ReverseMap();
            
            CreateMap<ArticlePicture, BasePictureViewModel>()
             .ForMember(d => d.EntityId, x => x.MapFrom(s => s.ArticleId));

            CreateMap<Article, EditArticleInputModel>().ReverseMap();
            
        }
    }
}
