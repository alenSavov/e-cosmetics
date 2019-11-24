using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Products.Models
{
    public class ProductCollectionViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
