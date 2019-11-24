using AutoMapper;
using ecosmetics.Models;
using ecosmetics.Services.Articles.Models;
using ecosmetics.Services.Categories.Models;
using ecosmetics.Services.Pictures.Models;
using ecosmetics.Services.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Infrastructure.AutoMapper
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
