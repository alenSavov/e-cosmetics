using ecosmetics.Services.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateAsync(CreateProductInputModel model);

        IEnumerable<ProductViewModel> GetAll();

        Task<bool> DeleteAsync(string id);

        ProductViewModel GetById(string id);

        IEnumerable<ProductViewModel> GetAllProductsForCategoryById(string id);

        Task<bool> EditAsync(EditProductViewModel model);

        //Task AddPicturesAsync(ICollection<Picture> pictures, string productId);
    }
}
