using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using e_cosmetics.Services.Products.Models;
using e_cosmetics.Services.Products.Contracts;
using e_cosmetics.Services.Interfaces;

namespace e_cosmetics.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IPictureService _pictureService;

        public ProductController(
                                 IProductService productService,
                                 ICategoryService categoryService,
                                  IPictureService pictureService)
        {
            this._productService = productService;
            this._categoryService = categoryService;
            this._pictureService = pictureService;
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
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            var product = await this._productService.CreateAsync(model);

            return RedirectToAction("GetAll");
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

        public IActionResult GetById(string id)
        {
            if (id == null)
            {
                return this.View();
            }

            var product = this._productService
                .GetById(id);

            var pictures = this._pictureService.GetAllProductPicturesById(product.Id);
            product.Pictures = pictures;

            return this.View("Details",product);
        }
    }
}