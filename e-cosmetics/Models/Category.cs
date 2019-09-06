﻿using System.Collections.Generic;

namespace e_cosmetics.Models
{
    public class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PictureName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
