using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ecosmetics.Services.Categories.Models
{
    public class EditCategoryInputModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string NameEn { get; set; }

        [Required]
        public string Description { get; set; }

        public string DescriptionEn { get; set; }

        [Required]
        public IFormFile Picture { get; set; }
    }
}
