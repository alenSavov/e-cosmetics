using System;
using System.Collections.Generic;

namespace e_cosmetics.Models
{
    public class Product
    {
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
            this.ProductPictures = new List<ProductPicture>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public string CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<ProductPicture> ProductPictures { get; set; }
    }
}
