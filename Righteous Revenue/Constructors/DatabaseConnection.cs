using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace FinanceSite.Constructors
{
    public static class DatabaseConnection
    {
        public static string CnnVal(string name) 
        {
          return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}