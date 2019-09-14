using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Services.Categories.Models
{
    public class CreateCategoryInputModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IFormFile Picture { get; set; }

        public string ProjectVersionPicture { get; set; }

        public string ProjectPictureUrl { get; set; }
    }
}
