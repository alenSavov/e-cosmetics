using System.Collections.Generic;
using e_cosmetics.Services.Categories.Models;

namespace e_cosmetics.Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();

        bool Create(string uniqueFileName, CreateCategoryInputModel model);

    }
}
