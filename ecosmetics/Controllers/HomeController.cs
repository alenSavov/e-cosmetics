using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ecosmetics.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using ecosmetics.Services.Categories.Models;
using Microsoft.Extensions.Localization;
using ecosmetics.Services.Interfaces;

namespace ecosmetics.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ICategoryService _categoryService;
        private readonly IPictureService _pictureService;

        public HomeController(ICategoryService categoryService,
            IPictureService pictureService, IStringLocalizer<HomeController> localizer)
        {
            this._categoryService = categoryService;
            this._pictureService = pictureService;
            _localizer = localizer;
        }


        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl = "/")
        {
            ViewData["ReturnUrl"] = returnUrl;

            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

        public IActionResult Index(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            ViewData["Culture"] = culture.Name;
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

        [HttpGet]
        public IActionResult About()
        {

            return this.View();
        }
    }
}