using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecosmetics.Data;
using ecosmetics.Models;
using ecosmetics.Services.Categories.Models;
using ecosmetics.Services.Interfaces;
using ecosmetics.Services.Pictures.Models;
using ecosmetics.Services.Products.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ecosmetics.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ApplicationDbContext _dbContext;
        private readonly IPictureService _pictureService;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;


        public CategoryController(ICategoryService categoryService,
            ApplicationDbContext dbContext,
            IMapper mapper,
            IPictureService pictureService,
            IProductService productService)
        {
            this._categoryService = categoryService;
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._pictureService = pictureService;
            this._productService = productService;
        }

        [TempData]
        public string ErrorMessage { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            var categories = this._categoryService
                .GetAll();

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            ViewData["Culture"] = culture.Name;

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

        [HttpGet]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public IActionResult Create(string returnUrl = null)
        {
            if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> Create(CreateCategoryInputModel model, string returnUrl = null)
        {
            if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            if (!this.ModelState.IsValid)
            {
                TempData[GlobalConstants.TempDataErrorMessageKey] = GlobalConstants.InvalidData;
                return this.View();
            }

            var categoryCreateResult = await this._categoryService.CreateAsync(model);

            //var imageDeleteResult = this._cloudinaryService.DeletePicture(category.GetType(), categoryPictureId);
            //var imageDeleteResult = this._pictureService.DeletePicture(category.GetType(), categoryPictureId);

            TempData[GlobalConstants.TempDataSuccessMessageKey] = GlobalConstants
                                                                    .CategoryMessage
                                                                    .CreateCategorySuccess;
            return View();
        }


        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return View();
            }

            //TODO Add validations

            var category = this._categoryService
                .GetById(id);


            var success = await this._categoryService
                .DeleteAsync(id);

            TempData[GlobalConstants.TempDataSuccessMessageKey] = GlobalConstants
                                                                    .CategoryMessage
                                                                    .DeleteCategorySuccess;
            return Redirect("/");
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return this.View();
            }

            var category = this._categoryService
                .GetById(id);

            var categoryView = this._mapper
                .Map<EditCategoryViewModel>(category);

            categoryView.Picture = this._pictureService
               .GetCategoryPicturesById(category.Id);

            categoryView.Picture.Url = this._pictureService.BuildCategoryPictureUrl(categoryView.Picture.Id, categoryView.Picture.VersionPicture);


            return View(categoryView);
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

            var products = this._productService
                .GetAllProductsForCategoryById(id);

            foreach (var product in products)
            {
                var pictures = this._pictureService.GetAllProductPicturesById(product.Id);
                product.Pictures = pictures;

            }

            var productsView = new ProductCollectionViewModel
            {
                Products = products

            };


            return this.View(productsView);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> EditAsync(EditCategoryInputModel model)
        {
            if (model.Id == null)
            {
                TempData[GlobalConstants.TempDataErrorMessageKey] = GlobalConstants.InvalidId;
                return Redirect("/");
            }

            if (model.Name == null)
            {
                TempData[GlobalConstants.TempDataErrorMessageKey] = GlobalConstants
                                                                     .CategoryMessage
                                                                     .EditCategoryNameRequired;
                return RedirectToAction("Edit", new { id = model.Id });
            }

            var success = await this._categoryService
                .EditAsync(model);

            return RedirectToAction("GetAll");
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> ChangePicture(EditCategoryInputModel model)
        {
            if (model.Id == null || model.Picture == null)
            {
                return this.RedirectToAction("Edit", new { id = model.Id });
            }

            var currentPicture = _pictureService.GetCategoryPicturesById(model.Id);
            var entityType = typeof(Category);
            var categoryPictureId = string.Format(GlobalConstants.CategoryPicture, model.Name);

            //Delete the old picture from cloudinary
            _pictureService.DeletePicture(entityType, currentPicture.Id);

            //Delete old picture from DB
            DeletePictureFromDB(currentPicture);


            //Add new picture to Cloudinary
            var pictures = new List<IFormFile>();
            pictures.Add(model.Picture);
            await this._pictureService.UploadPicturesAsync(pictures, entityType, categoryPictureId, model.Id);


            return Redirect("/");
        }

        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        private void DeletePictureFromDB(BasePictureViewModel currentPicture)
        {
            var picture = this._dbContext
                           .CategoryPictures
                           .FirstOrDefault(p => p.Id == currentPicture.Id);

            try
            {
                this._dbContext
               .CategoryPictures
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