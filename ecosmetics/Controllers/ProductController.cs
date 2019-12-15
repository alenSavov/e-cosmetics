using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecosmetics.Data;
using ecosmetics.Models;
using ecosmetics.Services.Interfaces;
using ecosmetics.Services.Pictures.Models;
using ecosmetics.Services.Products.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ecosmetics.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IPictureService _pictureService;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _dbContext;

        public ProductController(
                                 IProductService productService,
                                 ICategoryService categoryService,
                                  IPictureService pictureService,
                                  IMapper mapper,
                                  ApplicationDbContext dbContext)
        {
            this._productService = productService;
            this._categoryService = categoryService;
            this._pictureService = pictureService;
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var products = this._productService
                .GetAll();


            foreach (var product in products)
            {
                var pictures = this._pictureService.GetAllProductPicturesById(product.Id);
                product.Pictures = pictures;

            }

            var productCollection = new ProductCollectionViewModel
            {
                Products = products
            };

            return View(productCollection);
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public IActionResult Create()
        {
            var categoryList = this._categoryService
                .GetAll();

            ViewBag.ListOfCategories = categoryList;

            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> Create(CreateProductInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            var product = await this._productService.CreateAsync(model);

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

            var product = this._productService
                .GetById(id);

            //var pictures = this._pictureService.GetAllProductPicturesById(product.Id);
            //product.Pictures = pictures;

            var productView = this._mapper
                .Map<EditProductViewModel>(product);


            //categoryView.Picture.Url = this._pictureService.BuildCategoryPictureUrl(categoryView.Picture.Id, categoryView.Picture.VersionPicture);


            return View(productView);

        }


        [HttpPost]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> EditAsync(EditProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            var success = await this._productService
                .EditAsync(model);

            return RedirectToAction("GetById", new { id = model.Id });
        }

        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return View();
            }

            var product = this._productService
              .GetById(id);

            var success = await this._productService
                  .DeleteAsync(id);


            return Redirect("/");
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

            var product = this._productService
                .GetById(id);

            var pictures = this._pictureService.GetAllProductPicturesById(product.Id);
            product.Pictures = pictures;

            return this.View("Details", product);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        public async Task<IActionResult> ChangePicture(EditProductViewModel model)
        {
            if (model.Id == null || model.Pictures == null)
            {
                return this.RedirectToAction("Edit", new { id = model.Id });
            }

            var currentPicture = _pictureService.GetProductPicturesById(model.Id);
            var entityType = typeof(Product);
            var productPictureId = string.Format(GlobalConstants.ProductPicture, model.Name);

            //Delete the old picture from cloudinary
            _pictureService.DeletePicture(entityType, currentPicture.Id);

            //Delete old picture from DB
            DeletePictureFromDB(currentPicture);


            //Add new picture to Cloudinary
            var pictures = new List<IFormFile>();
            pictures.Add(model.Pictures.First());
            await this._pictureService.UploadPicturesAsync(pictures, entityType, productPictureId, model.Id);


            return Redirect("/");
        }

        [Authorize(Roles = GlobalConstants.ADMINISTRATOR_ROLE)]
        private void DeletePictureFromDB(ProductPictureViewModel currentPicture)
        {
            var picture = this._dbContext
                           .ProductPictures
                           .FirstOrDefault(p => p.Id == currentPicture.Id);

            try
            {
                this._dbContext
               .ProductPictures
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