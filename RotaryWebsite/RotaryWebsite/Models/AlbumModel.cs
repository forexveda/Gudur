using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.Models
{
    public class AlbumModel
    {
        public AlbumModel()
        {
            Pictures = new List<PicturesModel>();
            AllPictures = new List<PicturesModel>();
        }
        public int albumId { get; set; }
        public int chapterid { get; set; }
        public string albumname { get; set; }
        public int sortingorder { get; set; }

        public List<PicturesModel> Pictures { get; set; }

        public List<PicturesModel> AllPictures { get; set; }
    }
}
