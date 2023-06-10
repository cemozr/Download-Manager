using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download_Manager
{
    public static class AppHelper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["Download_Manager.Properties.Settings.connectionString"].ConnectionString;
    }
}
