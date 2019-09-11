using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using System.Collections.Generic;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Categories.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Linq;

namespace e_cosmetics.Services.Categories.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IHostingEnvironment _appEnvironment;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CategoryService(ApplicationDbContext dbContext, IMapper mapper,
            IHostingEnvironment appEnvironment)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._appEnvironment = appEnvironment;
        }

        public async Task<bool> CreateAsync(string uniqueFileName, CreateCategoryInputModel model)
        {

            Category category = new Category
            {
                Name = model.Name,
                Description = model.Description,
                PictureName = uniqueFileName
            };

            this._dbContext.Categories.Add(category);
            await this._dbContext.SaveChangesAsync();


            return true;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            var categories = this._dbContext
                .Categories;

            var categoriesView = _mapper
                .Map<List<CategoryViewModel>>(categories);

            string uploadsFolder = Path.Combine(_appEnvironment.WebRootPath, GlobalConstants.imageFolderName);

            foreach (var category in categoriesView)
            {
                string filePath = Path.Combine(uploadsFolder, category.PictureName);
                category.PictureName = $"{GlobalConstants.imageFolderPath}{category.PictureName}";
            }

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
                this._dbContext.Categories.Remove(category);
               await this._dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {

                return false;
            }

        }

        public async Task<bool> EditAsync(string uniqueFileName, EditCategoryInputModel model)
        {
            var category = this._dbContext.Categories
                .FirstOrDefault(x => x.Id == model.Id);

            if (category == null)
            {
                return false;
            }

            try
            {
                category.PictureName = uniqueFileName;
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
