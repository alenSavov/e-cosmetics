﻿using AutoMapper;
using ecosmetics.Data;
using ecosmetics.Models;
using ecosmetics.Services.Articles.Models;
using ecosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Articles.Implementation
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

            var currentDatetimeNow = DateTime.UtcNow;
            article.CreatedOn = currentDatetimeNow.Date;


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
            var article = this._dbContext
                 .Articles
                 .FirstOrDefault(x => x.Id == id);


            return article;
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
                article.TitleEn = model.TitleEn;
                article.Content = model.Content;
                article.ContentEn = model.ContentEn;

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
