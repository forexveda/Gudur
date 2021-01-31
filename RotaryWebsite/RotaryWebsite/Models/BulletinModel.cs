using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.Models
{
    public class BulletinModel
    {
        public int bulletinId { get; set; }
        public string bulletinname { get; set; }
        public string bulletindate { get; set; }
        public string bulletinurl { get; set; }
        public int sortorder { get; set; }
        public int ChapterId { get; set; }
    }
}
