using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using e_cosmetics.Data;
using e_cosmetics.Services.Categories.Models;
using e_cosmetics.Services.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace e_cosmetics.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly ApplicationDbContext _dbContext;

        public CategoryController(ICategoryService categoryService,
            IHostingEnvironment appEnvironment,
            ApplicationDbContext dbContext)
        {
            this._categoryService = categoryService;
            this._appEnvironment = appEnvironment;
            this._dbContext = dbContext;
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
                    uniqueFileName = SavePictureInImageFolder(uniqueFileName, model);

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

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return View();
            }

            //if (id == null)
            //{
            //    TempData[GlobalConstants.TempDataErrorMessageKey] = GlobalConstants.InvalidId;
            //    return Redirect("/");
            //}

          var success = await this._categoryService
                .DeleteAsync(id);

            return RedirectToAction("GetAll");
        }

        private string SavePictureInImageFolder(string uniqueFileName, CreateCategoryInputModel model)
        {
            string uploadsFolder = Path.Combine(_appEnvironment.WebRootPath, "img");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Picture.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            model.Picture.CopyTo(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
        }
    }
}