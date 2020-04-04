using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozgunneonCom.Models
{
    public class PhotoAndTypeViewModel
    {
        public Photo Photo { get; set; }
        public PhotoType PhotoType { get; set; }

        public IQueryable<Photo> photos { get; set; } 
        public IQueryable<PhotoType> types { get; set; } 
    }
}
