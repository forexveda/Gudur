using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.Models
{
    public class PastLeadersModel
    {
        public int ID { get; set; }
        public string Years { get; set; }
        public string PRESIDENT { get; set; }
        public string SECRETORY { get; set; }
        public int SortOrder { get; set; }
        public int ChapterID { get; set; }
    }
}
