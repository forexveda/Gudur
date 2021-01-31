using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.CommonServices
{
    public class NorthWindConfiguration
    {
        public string DbConnectionString { get; set; }
    }

    public class MyConfig
    {
        public string ChapterId { get; set; }
        public string SmtpClientHost { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string ToEmail { get; set; }
    }
}
