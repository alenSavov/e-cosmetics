using e_cosmetics.Services.Pictures.Models;
using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Services.Categories.Models
{
    public class EditCategoryViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public BasePictureViewModel Picture { get; set; }
    }
}
