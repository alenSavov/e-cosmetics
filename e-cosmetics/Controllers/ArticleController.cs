﻿using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using e_cosmetics.Services.Interfaces;
using e_cosmetics.Services.Articles.Models;

namespace e_cosmetics.Controllers
{
    public class ArticleController: Controller
    {
        private readonly IArticleService _articleService;
        private readonly IPictureService _pictureService;
        private readonly IMapper _mapper;

        public ArticleController(IArticleService articleService,
            IPictureService pictureService,
            IMapper mapper)
        {
            this._articleService = articleService;
            this._pictureService = pictureService;
            this._mapper = mapper;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var article = await this._articleService.CreateAsync(model);
            return View();
        }

        public IActionResult GetAll()
        {
            var articles = this._articleService
               .GetAll();


            foreach (var article in articles)
            {
                article.Picture = this._pictureService
                .GetArticlePicturesById(article.Id);

                article.Picture.Url = this._pictureService.BuildArticlePictureUrl(article.Picture.Id, article.Picture.VersionPicture);
            }

            var articleCollection = new ArticlesCollectionViewModel
            {
                Articles = articles
            };

            return View(articleCollection);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return View();
            }

            //TODO Add validations

            var article = this._articleService
                .GetById(id);


            var success = await this._articleService
                .DeleteAsync(id);


            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return this.View();
            }

            var article = this._articleService
                .GetById(id);

            var articleView = this._mapper
               .Map<EditArticleInputModel>(article);

            //var articleView = this._mapper
            //    .Map<ArticleInputModel>(article);

            //articleView.Picture = this._pictureService
            //   .GetArticlePicturesById(article.Id);

            //articleView.Picture.Url = this._pictureService.BuildArticlePictureUrl(articleView.Picture.Id, articleView.Picture.VersionPicture);


            return View(articleView);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(EditArticleInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var success = await this._articleService
                .EditAsync(model);

            return RedirectToAction("GetById", new { id = model.Id });
        }
                
        public IActionResult GetById(string id)

        {
            if (id == null)
            {
                return this.View();
            }

            var article = this._articleService
                .GetById(id);

            var articleView = this._mapper
                .Map<ArticleViewModel>(article);

            var pictures = this._pictureService.GetArticlePicturesById(articleView.Id);
            articleView.Picture = pictures;
            

            return this.View("Details",articleView);
        }
    }
}