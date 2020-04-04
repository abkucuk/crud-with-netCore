using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozgunneonCom.Models
{
    public class Photo
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string photoName { get; set; }
        public string description { get; set; }
        public string photoTypeId { get; set; }
        //public PhotoType photoType { get; set; }
    }
}
