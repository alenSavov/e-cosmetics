using ecosmetics.Services.Pictures.Models;
using System.ComponentModel.DataAnnotations;

namespace ecosmetics.Services.Articles.Models
{
    public class EditArticleInputModel
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string TitleEn { get; set; }

        [Required]
        public string Content { get; set; }


        public string ContentEn { get; set; }

              
        public BasePictureViewModel Picture { get; set; }
    }
}

