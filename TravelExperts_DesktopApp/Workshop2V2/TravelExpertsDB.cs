using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author: Rene
* 
*This class is used to get a connection to the database using the GetConnection() method.
* 
*/
namespace Workshop2V2
{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            //Add the @ symbol to take away the special meaning of the backslash
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TravelExperts.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
