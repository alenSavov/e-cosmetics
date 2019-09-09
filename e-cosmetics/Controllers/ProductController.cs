using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Products.Contracts;
using e_cosmetics.Services.Products.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace e_cosmetics.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IHostingEnvironment appEnvironment,
                                 IProductService productService,
                                 ICategoryService categoryService)
        {
            this._appEnvironment = appEnvironment;
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
                    uniqueFileName = SavePictureInImageFolder(uniqueFileName, model);

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

        public async Task<IActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return View();
            }
                       
            //TODO Add validations

            var success = await this._productService
                  .DeleteAsync(id);

            return RedirectToAction("GetAll");
        }

        public string SavePictureInImageFolder(string uniqueFileName, CreateProductInputModel model)
        {
            string uploadsFolder = Path.Combine(_appEnvironment.WebRootPath, "img");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Picture.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            model.Picture.CopyTo(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
        }
    }
}