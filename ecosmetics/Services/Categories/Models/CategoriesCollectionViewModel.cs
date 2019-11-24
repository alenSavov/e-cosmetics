using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Categories.Models
{
    public class CategoriesCollectionViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
