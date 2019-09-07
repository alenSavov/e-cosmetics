using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Services.Products.Models
{
    public class CreateProductInputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }
        //public IEnumerable<Category> Categories { get; set; }

        public IFormFile Picture { get; set; }
    }
}
