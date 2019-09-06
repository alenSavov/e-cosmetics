using e_cosmetics.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_cosmetics.Services.Products.Models
{
    public class CreateProductInputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public IFormFile Picture { get; set; }
    }
}
