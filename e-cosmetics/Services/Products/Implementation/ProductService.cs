using System.IO;
using AutoMapper;
using System.Linq;
using e_cosmetics.Data;
using e_cosmetics.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using e_cosmetics.Services.Interfaces;
using e_cosmetics.Services.Products.Models;
using e_cosmetics.Services.Products.Contracts;

namespace e_cosmetics.Services.Products.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly ApplicationDbContext _dbContext;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IMapper _mapper;
        private readonly IPictureService _pictureService;

        public ProductService(
                    ICategoryService categoryService,
                    ApplicationDbContext dbContext,
                    IMapper mapper,
                    IHostingEnvironment appEnvironment,
                     IPictureService pictureService
            )
        {
            this._categoryService = categoryService;
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._appEnvironment = appEnvironment;
            this._pictureService = pictureService;
        }

        public async Task<bool> CreateAsync(CreateProductInputModel model)
        {

            var file = model.PictFormFiles;
            var productPictureId = string.Format(GlobalConstants.ProductPicture, model.Name);

            var product = this._mapper.Map<Product>(model);

            await this._dbContext.Products.AddAsync(product);
            await this._dbContext.SaveChangesAsync();

            await this._pictureService.UploadPicturesAsync(model.PictFormFiles, product.GetType(), productPictureId, product.Id);


            return true;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            var products = this._dbContext
                .Products;

            var productsView = _mapper
                .Map<List<ProductViewModel>>(products);

            return productsView;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var product = this._dbContext.Products
                .FirstOrDefault(c => c.Id == id);

            if (product == null)
            {
                return false;
            }

            try
            {
                var pictures = this._dbContext.ProductPictures
                    .Where(x => x.ProductId == product.Id)
                    .ToList();

                foreach (var picture in pictures)
                {
                    this._pictureService.DeletePicture(product.GetType(), picture.Id);
                    this._dbContext.ProductPictures.Remove(picture);
                }

                this._dbContext.Products.Remove(product);

                await this._dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public ProductViewModel GetById(string id)
        {
            var product = this._dbContext
                 .Products
                 .FirstOrDefault(x => x.Id == id);

            var productView = this._mapper
                .Map<ProductViewModel>(product);

            return productView;
        }

        public IEnumerable<ProductViewModel> GetAllProductsForCategoryById(string id)
        {
            var products = this._dbContext
                .Products
                .Where(p => p.CategoryId == id)
                .ToList();

            var productsView = new List<ProductViewModel>();

            foreach (var product in products)
            {
                 productsView.Add(this._mapper
                    .Map<ProductViewModel>(product));

            }


            return productsView;
        }

        public async Task<bool> EditAsync(EditProductViewModel model)
        {
            var product = this._dbContext.Products
                .FirstOrDefault(x => x.Id == model.Id);

            if (product == null)
            {
                return false;
            }

            try
            {
                product.Name = model.Name;
                product.Description = model.Description;

                await this._dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //public async Task AddPicturesAsync(ICollection<Picture> pictures, string productId)
        //{
        //    var product = this.GetById(productId)
        //        .Pictures = pictures;

        //   await this._dbContext.SaveChangesAsync();
        //}
    }
}
