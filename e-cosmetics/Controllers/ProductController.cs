using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Products.Models;
using e_cosmetics.Services.Products.Contracts;

namespace e_cosmetics.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(
                                 IProductService productService,
                                 ICategoryService categoryService)
        {
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
        public IActionResult Edit(string id)
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


            return RedirectToAction("GetAll");
        }
    }
}