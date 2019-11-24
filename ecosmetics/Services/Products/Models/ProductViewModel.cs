using ecosmetics.Services.Pictures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Products.Models
{
    public class ProductViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ProductId { get; set; }

        public string CategoryId { get; set; }

        public IEnumerable<ProductPictureViewModel> Pictures { get; set; }

    }
}
