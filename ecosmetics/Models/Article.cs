﻿using System;

namespace ecosmetics.Models
{
    public class Article
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string TitleEn { get; set; }

        public string Content { get; set; }

        public string ContentEn { get; set; }

        public string Creator { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ArticlePictureId { get; set; }

        public ArticlePicture ArticlePicture { get; set; }
    }
}
