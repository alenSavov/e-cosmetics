using System;
using System.ComponentModel.DataAnnotations;
using e_cosmetics.Services.Pictures.Models;

namespace e_cosmetics.Services.Articles.Models
{
    public class ArticleViewModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Creator { get; set; }

        //.ToString("MMMM dd, yyyy")
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MMMM dd, yyyy}")]
        public DateTime CretedOn { get; set; }

        public string Content { get; set; }

        public BasePictureViewModel Picture { get; set; }
    }
}
