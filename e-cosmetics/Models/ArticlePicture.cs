namespace e_cosmetics.Models
{
    public class ArticlePicture
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string Folder { get; set; }

        public string VersionPicture { get; set; }

        public string ArticleId { get; set; }

        public Article Article { get; set; }
    }
}
