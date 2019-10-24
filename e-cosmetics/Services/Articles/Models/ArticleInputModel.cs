using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace e_cosmetics.Services.Articles.Models
{
    public class ArticleInputModel
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }
       
        [Required]
        public string Creator { get; set; }

        [Required(ErrorMessage = "Add Image")]
        public IFormFile Picture { get; set; }
    }
}
