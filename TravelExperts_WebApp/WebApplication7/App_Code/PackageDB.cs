using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/* 
* Author:Rene
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*This code is used to get the packages for a certain customer
* 
*/
namespace WebApplication7
{
    public static class PackageDB
    {
        public static List<CustomerPackage> GetCustPackages(int custID)
        {
            List<CustomerPackage> packageList = new List<CustomerPackage>();//Create an empty list of incidents
            CustomerPackage customerPackage = null;//creae a null incident

            SqlConnection con = TravelExpertsDB.GetConnection();//get a connection to the database

            string selectQuery = "SELECT Packages.PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, BookingId, BookingDate, TravelerCount " +
                                 "FROM Packages INNER JOIN Bookings ON Bookings.PackageId = Packages.PackageId " +
                                 "Where CustomerId = @CustomerId";

            SqlCommand selectCommand = new SqlCommand(selectQuery, con);//create the select command
            selectCommand.Parameters.AddWithValue("@CustomerId", custID);

            try
            {
                con.Open();//open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the query and store it in reader
                while (reader.Read()) //read the incidents if they exist
                {
                    //create new incident and add properties to them
                    customerPackage = new CustomerPackage();
                    customerPackage.PackageId = (int)reader["PackageId"];
                    customerPackage.PkgName = (string)reader["PkgName"];
                    customerPackage.PkgStartDate = reader["PkgStartDate"] as DateTime?;
                    customerPackage.PkgEndDate = reader["PkgEndDate"] as DateTime?;
                    customerPackage.PkgDesc = (string)reader["PkgDesc"];
                    customerPackage.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    customerPackage.BookingId = (int)reader["BookingId"];
                    customerPackage.BookingDate = reader["BookingDate"] as DateTime?;
                    customerPackage.TravelerCount = Convert.ToInt32(reader["TravelerCount"]);

                    packageList.Add(customerPackage);//add the incident to the incident list
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();//close the connection
            }
            return packageList;//return the incident list
        }
    }
}