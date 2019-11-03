using e_cosmetics.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using e_cosmetics.Services.Interfaces;
using e_cosmetics.Services.Categories.Models;
using System;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IPictureService _pictureService;
        //private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ICategoryService categoryService,
            IPictureService pictureService
            /*IStringLocalizer<HomeController> localizer*/)
        {
            this._categoryService = categoryService;
            this._pictureService = pictureService;
            //this._localizer = localizer;
        }



        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

        public IActionResult Index()
        {

            var categories = this._categoryService
               .GetAll();


            foreach (var category in categories)
            {
                category.Picture = this._pictureService
                .GetCategoryPicturesById(category.Id);

                category.Picture.Url = this._pictureService.BuildCategoryPictureUrl(category.Picture.Id, category.Picture.VersionPicture);
            }

            var categoryCollection = new CategoriesCollectionViewModel
            {
                Categories = categories
            };

            return View(categoryCollection);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return this.View();
        }

        public IActionResult About()
        {

            return this.View();
        }
    }
}