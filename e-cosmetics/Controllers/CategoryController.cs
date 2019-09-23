using System.Threading.Tasks;
using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using e_cosmetics.Services.Categories.Models;
using e_cosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace e_cosmetics.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ApplicationDbContext _dbContext;
        private readonly IPictureService _pictureService;
        private readonly IMapper _mapper;


        public CategoryController(ICategoryService categoryService,
            ApplicationDbContext dbContext,
            IMapper mapper,
            IPictureService pictureService)
        {
            this._categoryService = categoryService;
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._pictureService = pictureService;
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
                category.Picture = this._pictureService
                .GetAllPicturesById(category.Id);

                category.Picture.Url = this._pictureService.BuildCategoryPictureUrl(category.Picture.Id, category.Picture.VersionPicture);
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
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var categoryCreateResult = await this._categoryService.CreateAsync(model);

            //var imageDeleteResult = this._cloudinaryService.DeletePicture(category.GetType(), categoryPictureId);
            //var imageDeleteResult = this._pictureService.DeletePicture(category.GetType(), categoryPictureId);

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