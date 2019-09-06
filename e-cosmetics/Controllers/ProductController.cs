using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

        public ProductController(IHostingEnvironment appEnvironment)
        {
            this._appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductInputModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Picture != null)
                {
                    uniqueFileName = SavePictureInImageFolder(uniqueFileName, model);

                    var result = this._productService
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