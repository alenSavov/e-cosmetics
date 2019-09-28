using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using System.Collections.Generic;
using e_cosmetics.Services.Categories.Models;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Linq;
using e_cosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Services.Categories.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IHostingEnvironment _appEnvironment;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IPictureService _pictureService;


        public CategoryService(ApplicationDbContext dbContext, IMapper mapper,
            IHostingEnvironment appEnvironment,
            IPictureService pictureService)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._appEnvironment = appEnvironment;
            this._pictureService = pictureService;
        }

        public async Task<bool> CreateAsync(CreateCategoryInputModel model)
        {

            var categoryPictureId = string.Format(GlobalConstants.CategoryPicture, model.Name);

            var category = this._mapper.Map<Category>(model);

            await this._dbContext.Categories.AddAsync(category);
            await this._dbContext.SaveChangesAsync();

            var pictures = new List<IFormFile>();
            pictures.Add(model.Picture);

            await this._pictureService.UploadPicturesAsync(pictures, category.GetType(), categoryPictureId, category.Id);

            return true;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            var categories = this._dbContext
                .Categories;

            var categoriesView = _mapper
                .Map<List<CategoryViewModel>>(categories);

            return categoriesView;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var category = this._dbContext.Categories
                .FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return false;
            }

            try
            {
                var pictures = this._dbContext.CategoryPictures
                   .Where(x => x.CategoryId == category.Id)
                   .ToList();

                foreach (var picture in pictures)
                {
                    this._pictureService.DeletePicture(category.GetType(), picture.Id);
                    this._dbContext.CategoryPictures.Remove(picture);
                }

                this._dbContext.Categories.Remove(category);
                await this._dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {

                return false;
            }

        }

        public async Task<bool> EditAsync(EditCategoryInputModel model)
        {
            var category = this._dbContext.Categories
                .FirstOrDefault(x => x.Id == model.Id);

            if (category == null)
            {
                return false;
            }

            try
            {
                category.Name = model.Name;
                category.Description = model.Description;

                await this._dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Category GetById(string id)
        {
            return this._dbContext
                 .Categories
                 .FirstOrDefault(x => x.Id == id);

        }

        
    }
}