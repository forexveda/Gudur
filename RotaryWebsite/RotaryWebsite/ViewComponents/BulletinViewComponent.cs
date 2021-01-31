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
    [ViewComponent(Name = "Bulletin")]
    public class BulletinViewComponent : ViewComponent
    {
        IDNTConnectionFactory _connectionFactory;
        private readonly IOptions<NorthWindConfiguration> _configs;
        private readonly IOptions<MyConfig> _myconfigs;
        public BulletinViewComponent(IDNTConnectionFactory connectionFactory, IOptions<NorthWindConfiguration> Configs, IOptions<MyConfig> myConfigs)
        {
            _connectionFactory = connectionFactory;
            _configs = Configs;
            _myconfigs = myConfigs;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private async Task<IEnumerable<BulletinModel>> GetItemsAsync()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.GetConnection())
                {
                    if (!string.IsNullOrEmpty(_myconfigs.Value.ChapterId))
                    {
                        var result = conn.Query<BulletinModel>("select * from bulletin where ChapterId=" + _myconfigs.Value.ChapterId);
                        return result;
                    }
                    else
                    {
                        var result = conn.Query<BulletinModel>("select * from bulletin");
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
