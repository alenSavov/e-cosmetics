using ecosmetics.Services.Pictures.Models;

namespace ecosmetics.Services.Categories.Models
{
    public class CategoryViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string NameEn { get; set; }

        public string Description { get; set; }

        public string DescriptionEn { get; set; }

        public BasePictureViewModel Picture { get; set; }
    }
}
