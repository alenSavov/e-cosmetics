using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Images.Contracts;
using e_cosmetics.Services.Products.Contracts;
using e_cosmetics.Services.Products.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_cosmetics.Controllers
{
    public class ProductController : Controller
    {
        private readonly IImageService _imageService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IImageService imageService,
                                 IProductService productService,
                                 ICategoryService categoryService)
        {
            this._imageService = imageService;
            this._productService = productService;
            this._categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var products = this._productService
                .GetAll();

            return this.View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categoryList = this._categoryService
                .GetAll();

            ViewBag.ListOfCategories = categoryList;

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductInputModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Picture != null)
                {
                     uniqueFileName = await this._imageService.SavePictureAsync(uniqueFileName, model.Picture);

                    var result = await this._productService
                        .CreateAsync(uniqueFileName, model);

                    return RedirectToAction();
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }

            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }

            return View();

        }

        [HttpGet]
        public IActionResult Edit()
        {
            return this.View();
        }

        public async Task<IActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return View();
            }

            var product = this._productService
              .GetById(id);

            //TODO Add validations

            var success = await this._productService
                  .DeleteAsync(id);

            var isDeletePictureSuccess = this._imageService.DeletePicture(product.PictureName);

            return RedirectToAction("GetAll");
        }
    }
}