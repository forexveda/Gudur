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
    public class boardmemberController : Controller
    {
        IDNTConnectionFactory _connectionFactory;
        private readonly IOptions<MyConfig> _myconfigs;

        public boardmemberController(IDNTConnectionFactory connectionFactory, IOptions<MyConfig> myConfigs)
        {
            _connectionFactory = connectionFactory;
            _myconfigs = myConfigs;
        }
        public IActionResult Index()
        {
            var items = GetItemsAsync();
            return View(items);
        }

        private IEnumerable<MemberModel> GetItemsAsync()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.GetConnection())
                {
                    if (!string.IsNullOrEmpty(_myconfigs.Value.ChapterId))
                    {
                        var result = conn.Query<MemberModel>("select * from member where ChapterId=" + _myconfigs.Value.ChapterId + " and isBoardMember!=0 order by isBoardMember desc, firstname");
                        return result;
                    }
                    else
                    {
                        var result = conn.Query<MemberModel>("select * from member where isBoardMember!=0");
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
