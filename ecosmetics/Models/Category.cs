using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Models
{
    public class Category
    {
        public Category()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Products = new List<Product>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string NameEn { get; set; }

        public string Description { get; set; }

        public string DescriptionEn { get; set; }

        public string CategoryPictureId { get; set; }

        public CategoryPicture CategoryPicture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

