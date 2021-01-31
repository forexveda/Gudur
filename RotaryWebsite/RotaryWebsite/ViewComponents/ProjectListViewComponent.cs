using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RotaryWebsite.CommonServices;
using RotaryWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.ViewComponents
{
    [ViewComponent(Name = "ProjectList")]
    public class ProjectListViewComponent : ViewComponent
    {
        IDNTConnectionFactory _connectionFactory;
        private readonly IOptions<MyConfig> _myconfigs;
        public ProjectListViewComponent(IDNTConnectionFactory connectionFactory, IOptions<MyConfig> myConfigs)
        {
            _connectionFactory = connectionFactory;
            _myconfigs = myConfigs;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private async Task<IEnumerable<ProjectsModel>> GetItemsAsync()
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
                    return set1;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
