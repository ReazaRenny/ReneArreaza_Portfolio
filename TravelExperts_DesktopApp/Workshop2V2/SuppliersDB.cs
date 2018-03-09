using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* Author: Rene
* 
*This class is used to query and access the Suppliers table data from the database.
* 
*/
namespace Workshop2V2
{
    public static class SuppliersDB
    {
        //This method is used to get all the suppliers from he Suppliers table in the db. It returns a list of Suppliers.
        public static List<Suppliers> GetSuppliers()
        {
            List<Suppliers> supplierList = new List<Suppliers>();//Create an empty list of suppliers
            Suppliers supplier = null;//Create a null supplier

            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection to db

            //Build the query to access the supplierId and SupName from the Suppliers table
            string selectQuery = "SELECT SupplierId, SupName " +
                                 "FROM Suppliers";
            //Build the selectCommand by giving SqlCommand the query and the connection to the db
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);

            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the select command and store results in reader
                while (reader.Read()) //Read the suppliers if they still exist
                {
                    supplier = new Suppliers();//Create a new supplier for this iteration
                    //Add the supplier properties
                    supplier.SupplierId = (int)reader["SupplierId"];
                    supplier.SupName = (string)reader["SupName"];
                    supplierList.Add(supplier);//Add this supplier to the supplier list
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();//Close the connection
            }
            return supplierList;//Return the supplier list
        }

        //This method is used to get the suppliers name when given the supplierId in the suppliers table from the db. 
        //It returns a string of the supplier name.
        public static string getSupName(int supplierId)
        {
            string supName = "";//Create an empty string for supplier name

            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection to the db
            //Create a query for selecting SupName form the suppliers table where the SuppliersId is known
            string selectQuery = "SELECT SupName " +
                                 "FROM Suppliers " +
                                 "WHERE SupplierId = @SupplierId";
            //Build the selectCommand by giving SqlCommand the query and the connection to the db
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            //Bind the supplierId to @SupplierId
            selectCommand.Parameters.AddWithValue("@SupplierId", supplierId);

            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) //read the customer if exists
                {
                    supName = (string)reader["SupName"]; // store the supplier name as supName
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

            return supName;//returnt he suppier name string
        }

        //This method is used to get the suppliersId when given the supplier name in the suppliers table from the db. 
        //It returns an integer of the supplierId.
        public static int getSupplierId(string supName)
        {
            int supplierId = 0;//Set the supplierId to 0, if the method return 0 then no supplierId is found for that supplier Name

            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection
            //Create a query for selecting the supplierId from the suppliers table where supplier name is given
            string selectQuery = "SELECT SupplierId " +
                                 "FROM Suppliers " +
                                 "WHERE SupName = @SupName";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);//Create a select command using SqlCommand
            selectCommand.Parameters.AddWithValue("@SupName", supName);//Bind the supplier name to the @SupName

            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);//Execute the query and store the result in reader
                if (reader.Read()) //read the customer if exists
                {
                    supplierId = (int)reader["SupplierId"];//save stored result in supplierId
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

            return supplierId;//return the supplierId
        }

        public static bool InsertSupplier(int supplierId,string supName)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection
            //Create a query for inserting a supplier into the suppliers table
            string insertQuery = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                 "VALUES (@SupplierId, @SupName)";

            SqlCommand insertCommand = new SqlCommand(insertQuery, con);//Create a insert command using SqlCommand

            insertCommand.Parameters.AddWithValue("@SupplierId", supplierId);//Bind the supplierId name to the @SupplierId
            insertCommand.Parameters.AddWithValue("@SupName", supName);//Bind the supplier name to the @SupName

            try
            {
                con.Open();
                int count = insertCommand.ExecuteNonQuery(); //for DML statements

                if (count > 0)
                    return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public static bool UpdateSupplier(int supplierId, string supName, int oldsupplierId, string oldsupName)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection
            //Create a query for inserting a supplier into the suppliers table
            string updateQuery = "UPDATE Suppliers " +
                                 "SET SupplierId=@SupplierId, SupName=@SupName "+
                                 "WHERE SupplierId = @oldsupplierId "+
                                 "AND SupName = @oldsupName";

            SqlCommand updateCommand = new SqlCommand(updateQuery, con);//Create a insert command using SqlCommand

            updateCommand.Parameters.AddWithValue("@oldsupplierId", oldsupplierId);//Bind the supplierId name to the @SupplierId
            updateCommand.Parameters.AddWithValue("@oldsupName", oldsupName);//Bind the supplier name to the @SupName
            updateCommand.Parameters.AddWithValue("@SupplierId", supplierId);//Bind the supplierId name to the @SupplierId
            updateCommand.Parameters.AddWithValue("@SupName", supName);//Bind the supplier name to the @SupName

            try
            {
                con.Open();
                int count = updateCommand.ExecuteNonQuery(); //for DML statements

                if (count > 0)
                    return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public static bool DeleteSupplier(int supplierId)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection
            //Create a query for inserting a supplier into the suppliers table
            string deleteQuery = "DELETE Suppliers " +
                                 "WHERE SupplierId = @SupplierId";

            SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);//Create a insert command using SqlCommand

            deleteCommand.Parameters.AddWithValue("@SupplierId", supplierId);//Bind the supplierId name to the @SupplierId

            try
            {
                con.Open();
                int count = deleteCommand.ExecuteNonQuery(); //for DML statements

                if (count > 0)
                    return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public static int getNextSupplierId()
        {
            int supplierId = 0;//Set the supplierId to 0, if the method return 0 then no supplierId is found for that supplier Name

            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection
            //Create a query for selecting the supplierId from the suppliers table where supplier name is given
            string selectQuery = "select top 1 SupplierID from Suppliers order by SupplierId DESC ";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);//Create a select command using SqlCommand
                                                                        // selectCommand.Parameters.AddWithValue("@SupName", supName);//Bind the supplier name to the @SupName

            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);//Execute the query and store the result in reader
                if (reader.Read()) //read the customer if exists
                {
                    supplierId = (int)reader["SupplierId"];//save stored result in supplierId
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

            supplierId = supplierId + 1;
            return supplierId;//return the supplierId
        }
    }
}
