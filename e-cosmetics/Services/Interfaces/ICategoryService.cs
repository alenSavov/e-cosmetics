using e_cosmetics.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using e_cosmetics.Services.Categories.Models;

namespace e_cosmetics.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();

        Task<bool> CreateAsync(CreateCategoryInputModel model);

        Task<bool> DeleteAsync(string id);

        //Task<bool> EditAsync(string uniqueFileName, EditCategoryInputModel model);

        Category GetById(string id);

        //Task AddPicturesAsync(Picture picture, string categoryId);

    }
}