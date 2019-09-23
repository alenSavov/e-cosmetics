using e_cosmetics.Services.Pictures.Models;
using System.Collections.Generic;

namespace e_cosmetics.Services.Products.Models
{
    public class ProductViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ProductId { get; set; }

        public IEnumerable<ProductPictureViewModel> Pictures { get; set; }

    }
}
