using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace e_cosmetics.Services.Products.Models
{
    public class CreateProductInputModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryId { get; set; }

        public ICollection<IFormFile> PictFormFiles { get; set; }
    }
}
