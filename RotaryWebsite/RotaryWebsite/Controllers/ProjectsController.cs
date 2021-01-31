using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RotaryWebsite.CommonServices;
using RotaryWebsite.Models;

namespace RotaryWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        IDNTConnectionFactory _connectionFactory;
        private readonly IOptions<MyConfig> _myconfigs;
        public ProjectsController(IDNTConnectionFactory connectionFactory, IOptions<MyConfig> myConfigs)
        {
            _connectionFactory = connectionFactory;
            _myconfigs = myConfigs;
        }
        public IActionResult Index()
        {
            return View(GetItemsAsync());
        }

        private IEnumerable<ProjectCategoryModel> GetItemsAsync()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.GetConnection())
                {
                    var result = conn.QueryMultiple("GetProjectsWithImages",
                         new { @chapterid = Convert.ToInt32(_myconfigs.Value.ChapterId) },
                                    commandType: CommandType.StoredProcedure);
                    var set0 = result.Read<ProjectCategoryModel>().ToList();
                    var set1 = result.Read<ProjectsModel>().ToList();
                    var set2 = result.Read<ProjectImageModel>().ToList();

                    foreach (var project in set0)
                    {
                        project.ProjectsModel = set1.Where(x => x.projectcategoryid == project.projectscategoryid).ToList();
                        foreach (var item in set1)
                        {
                            item.ProjectImageModel = set2.Where(x => x.projectsid == item.projectsid).ToList();
                        }
                    }
                    return set0;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
