using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Services.Categories.Models
{
    public class CreateCategoryInputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IFormFile Picture { get; set; }
    }
}
