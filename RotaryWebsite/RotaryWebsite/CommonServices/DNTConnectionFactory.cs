using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.CommonServices
{
    public class DNTConnectionFactory : IDNTConnectionFactory
    {
        private IDbConnection _connection;
        private readonly IOptions<NorthWindConfiguration> _configs;

        public DNTConnectionFactory(IOptions<NorthWindConfiguration> Configs)
        {
            _configs = Configs;
        }

        public IDbConnection GetConnection()
        {
            return GetConnectionProp;
        }
        public IDbConnection GetConnectionProp
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(_configs.Value.DbConnectionString);
                }
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
