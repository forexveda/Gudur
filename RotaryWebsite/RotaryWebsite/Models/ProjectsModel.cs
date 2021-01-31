using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.Models
{

    public class ProjectCategoryModel
    {
        public ProjectCategoryModel()
        {
            ProjectsModel = new List<ProjectsModel>();
        }
        public int projectscategoryid { get; set; }
        public string Projecttype { get; set; }
        public string Chapterid { get; set; }

        public List<ProjectsModel> ProjectsModel { get; set; }
    }
    public class ProjectsModel
    {
        public ProjectsModel()
        {
            ProjectImageModel = new List<ProjectImageModel>();
        }
        public int projectsid { get; set; }
        public int projectcategoryid { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedAt { get; set; }

        public List<ProjectImageModel> ProjectImageModel { get; set; }
    }
}
