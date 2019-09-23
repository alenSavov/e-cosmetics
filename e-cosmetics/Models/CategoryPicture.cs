namespace e_cosmetics.Models
{
    public class CategoryPicture
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string Folder { get; set; }

        public string VersionPicture { get; set; }

        public string CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
