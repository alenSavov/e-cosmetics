using System.Collections.Generic;
using System.Threading.Tasks;
using e_cosmetics.Models;
using e_cosmetics.Services.Categories.Models;

namespace e_cosmetics.Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();

        Task<bool> CreateAsync(string uniqueFileName, CreateCategoryInputModel model);

        bool DeleteAsync(string id);

        Task<bool> EditAsync(string uniqueFileName, EditCategoryInputModel model);

        Category GetById(string id);

    }
}
