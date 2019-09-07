using e_cosmetics.Services.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_cosmetics.Services.Products.Contracts
{
    public interface IProductService
    {
        Task<bool> CreateAsync(string uniqueFileName, CreateProductInputModel model);

        IEnumerable<ProductViewModel> GetAll();
    }
}
