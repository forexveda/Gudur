using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.Models
{
    public class EventsModel
    {
        public int eventsId { get; set; }
        public int chapterid { get; set; }
        public string eventtitle { get; set; }
        public string venue { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public string eventimage { get; set; }
    }
}
