using System;
using AutoMapper;
using System.Linq;
using e_cosmetics.Data;
using e_cosmetics.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using e_cosmetics.Services.Interfaces;

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

            article.CreatedOn = DateTime.Now;

            await this._dbContext.Articles.AddAsync(article);
            await this._dbContext.SaveChangesAsync();

            var pictures = new List<IFormFile>();
            pictures.Add(model.Picture);

            await this._pictureService.UploadPicturesAsync(pictures, article.GetType(), articlePictureId, article.Id);

            return true;
        }

        public IEnumerable<ArticleViewModel> GetAll()
        {
            var articles = this._dbContext
                .Articles;

            var articlesView = _mapper
                .Map<List<ArticleViewModel>>(articles);

            return articlesView;
        }

        public Article GetById(string id)
        {
            return this._dbContext
                 .Articles
                 .FirstOrDefault(x => x.Id == id);

        }

        public async Task<bool> DeleteAsync(string id)
        {
            var article = this._dbContext.Articles
                .FirstOrDefault(c => c.Id == id);

            if (article == null)
            {
                return false;
            }

            try
            {
                var pictures = this._dbContext.ArticlePictures
                   .Where(x => x.ArticleId == article.Id)
                   .ToList();

                foreach (var picture in pictures)
                {
                    this._pictureService.DeletePicture(article.GetType(), picture.Id);
                    this._dbContext.ArticlePictures.Remove(picture);
                }

                this._dbContext.Articles.Remove(article);
                await this._dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {

                return false;
            }

        }

        public async Task<bool> EditAsync(EditArticleInputModel model)
        {
            var article = this._dbContext.Articles
                .FirstOrDefault(x => x.Id == model.Id);

            if (article == null)
            {
                return false;
            }

            try
            {
                article.Title = model.Title;
                article.Content = model.Content;

                await this._dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
