using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.CommonServices
{
    public interface IDNTConnectionFactory
    {
        void CloseConnection();
        IDbConnection GetConnection();
    }
}
