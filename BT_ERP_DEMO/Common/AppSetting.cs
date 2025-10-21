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
        public static string Database = "ERPDATAMODEL";
        public static string User = "admin";
        public static string Password = "ad@123";
        public static bool UseIntegratedSecurity = false;

        public static string GetConnectionString()
        {
            if (UseIntegratedSecurity)
                return $"Data Source={Server};Initial Catalog={Database};Integrated Security=True";
            else
                return $"Data Source={Server};Initial Catalog={Database};User ID={User};Password={Password}";
        }
    }
}
