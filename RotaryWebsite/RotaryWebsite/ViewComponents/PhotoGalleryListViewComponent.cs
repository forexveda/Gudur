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
    [ViewComponent(Name = "PhotoGalleryList")]
    public class PhotoGalleryListViewComponent : ViewComponent
    {
        IDNTConnectionFactory _connectionFactory;
        private readonly IOptions<MyConfig> _myconfigs;
        public PhotoGalleryListViewComponent(IDNTConnectionFactory connectionFactory, IOptions<MyConfig> myConfigs)
        {
            _connectionFactory = connectionFactory;
            _myconfigs = myConfigs;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private async Task<IEnumerable<PicturesModel>> GetItemsAsync()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.GetConnection())
                {
                    if (!string.IsNullOrEmpty(_myconfigs.Value.ChapterId))
                    {
                        var result = conn.Query<PicturesModel>("select * from pictures p INNER JOIN album a on p.albumid=a.albumid where a.chapterid=" + _myconfigs.Value.ChapterId);
                        return result;
                    }
                    else
                    {
                        var result = conn.Query<PicturesModel>("select * from pictures");
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
