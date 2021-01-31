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
    public class PastLeaderController : Controller
    {
        IDNTConnectionFactory _connectionFactory;
        private readonly IOptions<MyConfig> _myconfigs;

        public PastLeaderController(IDNTConnectionFactory connectionFactory, IOptions<MyConfig> myConfigs)
        {
            _connectionFactory = connectionFactory;
            _myconfigs = myConfigs;
        }

        public IActionResult Index()
        {
            var items = GetItemsAsync();
            return View(items);
        }

        private IEnumerable<PastLeadersModel> GetItemsAsync()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.GetConnection())
                {
                    if (!string.IsNullOrEmpty(_myconfigs.Value.ChapterId))
                    {
                        var result = conn.Query<PastLeadersModel>("select * from PastLeaders where ChapterId=" + _myconfigs.Value.ChapterId + " order by 1 desc");
                        return result;
                    }
                    else
                    {
                        var result = conn.Query<PastLeadersModel>("select * from PastLeaders");
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
