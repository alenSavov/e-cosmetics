using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using e_cosmetics.Services.Articles.Models;
using e_cosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_cosmetics.Services.Articles.Models
{
    public class ArticleService : IArticleService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IPictureService _pictureService;
        private readonly IMapper _mapper;

        public ArticleService(ApplicationDbContext dbContext,
            IPictureService pictureService,
            IMapper mapper)
        {
            this._dbContext = dbContext;
            this._pictureService = pictureService;
            this._mapper = mapper;
        }

        public async Task<bool> CreateAsync(ArticleInputModel model)
        {

            var articlePictureId = string.Format(GlobalConstants.ArticlePicture, model.Title);

            var article = this._mapper
                .Map<Article>(model);

            await this._dbContext.Articles.AddAsync(article);
            await this._dbContext.SaveChangesAsync();

            var pictures = new List<IFormFile>();
            pictures.Add(model.Picture);

            await this._pictureService.UploadPicturesAsync(pictures, article.GetType(), articlePictureId, article.Id);

            return true;
        }
    }
}
