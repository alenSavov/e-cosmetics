using System.Threading.Tasks;
using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using e_cosmetics.Services.Categories.Models;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace e_cosmetics.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ApplicationDbContext _dbContext;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IMapper _mapper;


        public CategoryController(ICategoryService categoryService,
            ApplicationDbContext dbContext,
            IMapper mapper,
            ICloudinaryService cloudinaryService)
        {
            this._categoryService = categoryService;
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._cloudinaryService = cloudinaryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var categories = this._categoryService
                .GetAll();

            foreach (var category in categories)
            {
                category.CategoryPictureUrl = this._cloudinaryService.BuildCategoryPictureUrl(category.Name, category.ProjectVersionPicture);
            }

            var categoryCollection = new CategoriesCollectionViewModel
            {
                Categories = categories
            };

            return View(categoryCollection);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryInputModel model)
        {
            Category category;
            var file = model.Picture;
            var categoryPictureId = string.Format(GlobalConstants.CategoryPicture, model.Name);
            var fileStream = file.OpenReadStream();

            category = this._mapper.Map<Category>(model);

            var imageUploadResult = this._cloudinaryService.UploadPicture(category.GetType(), categoryPictureId, fileStream);
            var categoryCreateResult = await this._categoryService.CreateAsync(model, imageUploadResult.Version);
            //    if (ModelState.IsValid)
            //    {
            //        string uniqueFileName = null;
            //        if (model.Picture != null)
            //        {
            //            uniqueFileName = await this._imageService.SavePictureAsync(uniqueFileName, model.Picture);

            //            var result = await this._categoryService
            //                .CreateAsync(uniqueFileName, model);

            //            return RedirectToAction();
            //        }
            //        else
            //        {
            //            var errors = ModelState.Values.SelectMany(v => v.Errors);

            //        }

            //    }
            //    else
            //    {
            //        var errors = ModelState.Values.SelectMany(v => v.Errors);
            //    }

            //    return View();
            return View();
        }

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


            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var category = this._categoryService
                .GetById(id);

            var categoryView = this._mapper
                .Map<EditCategoryInputModel>(category);

            return View(categoryView);
        }

        //[HttpPost]
        //public async Task<IActionResult> EditAsync(CreateCategoryInputModel model)
        //{
        //    if (!ModelState.IsValid)
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