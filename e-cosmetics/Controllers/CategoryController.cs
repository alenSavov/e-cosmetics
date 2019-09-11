using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using e_cosmetics.Data;
using e_cosmetics.Services.Categories.Models;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Images.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace e_cosmetics.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ApplicationDbContext _dbContext;
        private readonly IImageService _imageService;


        public CategoryController(ICategoryService categoryService,
            ApplicationDbContext dbContext,
            IImageService imageService)
        {
            this._categoryService = categoryService;
            this._dbContext = dbContext;
            this._imageService = imageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var categories = this._categoryService
                .GetAll();

            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryInputModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Picture != null)
                {
                    uniqueFileName = await this._imageService.SavePictureAsync(uniqueFileName, model.Picture);

                    var result = await this._categoryService
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

        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return View();
            }

            //TODO Add validations

            var category = this._categoryService
                .GetById(id);


            var success = this._categoryService
                .DeleteAsync(id);

            var isDeletePictureSuccess = this._imageService.DeletePicture(category.PictureName);

            return RedirectToAction("GetAll");
        }

        //[HttpGet]
        //public IActionResult Edit(string id)
        //{


        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> EditAsync(string id)
        //{
        //    if (id == null)
        //    {
        //        return View();
        //    }

        //    //TODO Add validations

        //    var success = await this._categoryService
        //        .EditAsync(id);

        //    return RedirectToAction("GetAll");
        //}


    }
}