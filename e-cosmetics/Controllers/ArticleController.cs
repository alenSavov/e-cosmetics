using e_cosmetics.Services.Articles.Models;
using e_cosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace e_cosmetics.Controllers
{
    public class ArticleController: Controller
    {
        private readonly IArticleService _articleService;
        private readonly IPictureService _pictureService;

        public ArticleController(IArticleService articleService,
            IPictureService pictureService)
        {
            this._articleService = articleService;
            this._pictureService = pictureService;
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
    }
}