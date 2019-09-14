using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Services.Categories.Models
{
    public class EditCategoryInputModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string FullPicturePath { get; set; }

        public string PictureName { get; set; }  

        public IFormFile Picture { get; set; }
    }
}
