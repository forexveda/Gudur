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
    [ViewComponent(Name = "HomeEventList")]
    public class HomeEventListViewComponent : ViewComponent
    {
        IDNTConnectionFactory _connectionFactory;
        private readonly IOptions<MyConfig> _myconfigs;
        public HomeEventListViewComponent(IDNTConnectionFactory connectionFactory, IOptions<MyConfig> myConfigs)
        {
            _connectionFactory = connectionFactory;
            _myconfigs = myConfigs;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private async Task<IEnumerable<EventsModel>> GetItemsAsync()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.GetConnection())
                {
                    if (!string.IsNullOrEmpty(_myconfigs.Value.ChapterId))
                    {
                        var result = conn.Query<EventsModel>("select * from events where date>=convert(date,GETDATE(),102) and ChapterId=" + _myconfigs.Value.ChapterId + " order by date desc, time desc");
                        return result;
                    }
                    else
                    {
                        var result = conn.Query<EventsModel>("select * from events");
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
