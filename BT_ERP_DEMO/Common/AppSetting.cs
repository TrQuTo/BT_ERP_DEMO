using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_ERP_DEMO.Common
{
    public static class AppSettings
    {
        public static string Server = "TQTN";
        public static string ErpDatabase = "ERPDATAMODEL";
        public static string SysDatabase = "DHSErpSys";
        public static string User = "admin";
        public static string Password = "ad@123";
        public static bool UseIntegratedSecurity = false;

        public static string GetConnectionString(string DatabaseName)
        {
            if (UseIntegratedSecurity)
                return $"Data Source={Server};Initial Catalog={DatabaseName};Integrated Security=True";
            else
                return $"Data Source={Server};Initial Catalog={DatabaseName};User ID={User};Password={Password}";
        }
    }
}
