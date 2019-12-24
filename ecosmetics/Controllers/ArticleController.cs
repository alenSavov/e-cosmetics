using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecosmetics.Data;
using ecosmetics.Models;
using ecosmetics.Services.Articles.Models;
using ecosmetics.Services.Interfaces;
using ecosmetics.Services.Pictures.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ecosmetics.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IPictureService _pictureService;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _dbContext;

        public ArticleController(IArticleService articleService,
            IPictureService pictureService,
            IMapper mapper,
            ApplicationDbContext dbContext)
        {
            this._articleService = articleService;
            this._pictureService = pictureService;
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
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

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            ViewData["Culture"] = culture.Name;

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

        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
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
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
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
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> EditAsync(EditArticleInputModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

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

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;
            ViewData["Culture"] = culture.Name;

            var article = this._articleService
                .GetById(id);

            var articleView = this._mapper
                .Map<ArticleViewModel>(article);

            var pictures = this._pictureService.GetArticlePicturesById(articleView.Id);
            articleView.Picture = pictures;


            return this.View("Details", articleView);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> ChangePicture(EditArticleInputModel model)
        {
            if (model.Id == null || model.Picture == null)
            {
                return this.RedirectToAction("Edit", new { id = model.Id });
            }

            var currentPicture = _pictureService.GetArticlePicturesById(model.Id);
            var entityType = typeof(Article);
            var articlePictureId = string.Format(GlobalConstants.ArticlePicture, model.Title);

            //Delete the old picture from cloudinary
            _pictureService.DeletePicture(entityType, currentPicture.Id);

            //Delete old picture from DB
            DeletePictureFromDB(currentPicture);


            //Add new picture to Cloudinary
            var pictures = new List<IFormFile>();
            pictures.Add(model.Picture);
            await this._pictureService.UploadPicturesAsync(pictures, entityType, articlePictureId, model.Id);


            return Redirect("/");
        }

        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        private void DeletePictureFromDB(BasePictureViewModel currentPicture)
        {
            var picture = this._dbContext
                           .ArticlePictures
                           .FirstOrDefault(p => p.Id == currentPicture.Id);

            try
            {
                this._dbContext
               .ArticlePictures
               .Remove(picture);

                this._dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}