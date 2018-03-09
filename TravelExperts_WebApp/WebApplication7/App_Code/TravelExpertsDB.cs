using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author: Rene
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*This class is used to get a connection to the database using the GetConnection() method.
* 
*/
namespace WebApplication7
{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            //get the connection through web.config connectionstrings
            string connectionString =
                ConfigurationManager.ConnectionStrings["TravelConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
