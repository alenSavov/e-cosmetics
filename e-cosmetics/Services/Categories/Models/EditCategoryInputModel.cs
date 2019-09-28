using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace e_cosmetics.Services.Categories.Models
{
    public class EditCategoryInputModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public IFormFile Picture { get; set; }
    }
}
