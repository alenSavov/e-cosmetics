using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace e_cosmetics.Services.ArticleService.Models
{
    public class ArticleInputModel
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }

        [Required]
        public string OwnerName { get; set; }

        [Required(ErrorMessage = "Add Image")]
        public IFormFile ArticlePicture { get; set; }
    }
}
