using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReneArreaza_CPRG214_LAB_3.App_Code
{
    public static class TechSupportDB
    {
        public static SqlConnection GetConnection()
        {
            //Add the @ symbol to take away the special meaning of the backslash
            string connectionString =
                ConfigurationManager.ConnectionStrings["TechSupportConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}