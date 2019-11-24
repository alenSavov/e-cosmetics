using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Pictures.Models
{
    public class PictureCollectionViewModel
    {
        public ICollection<BasePictureViewModel> Pictures { get; set; }
    }
}
