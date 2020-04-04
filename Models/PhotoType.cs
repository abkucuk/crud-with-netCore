using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozgunneonCom.Models
{
    public class PhotoType
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public ICollection<Photo> Photos { get; set; }

        public PhotoType()
        {
            Photos = new List<Photo>();
        }
    }
}
