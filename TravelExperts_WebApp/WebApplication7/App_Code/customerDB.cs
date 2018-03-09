using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author:Rene
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*
* 
*/
namespace WebApplication7
{
    public class customerDB
    {
        //checks the db to see if the email is in used, and if so, give an error about it.
        public static bool emailalreadyused(string given_email)
        {
            string SelectedEmail = ""; //get email
            bool emailpresent = true; // assume that email is in use

            SqlConnection connection = TravelExpertsDB.GetConnection(); //connect to db

            // create select command
            string selectString = "select CustEmail from Customers";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// process next row
                {
                    SelectedEmail = reader["CustEmail"].ToString();//if the row has an email equal to the selected email
                    if (SelectedEmail == given_email)
                        emailpresent = true; //set to true and send an error
                    else
                        emailpresent = false; //or ignore

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex; // throw it to the form to handle
            }
            finally
            {
                connection.Close();
            }

            return emailpresent; //return a alert if necessary or move on
        }



        // inserts new customer record into register
        public static bool AddCustomer(Customer cust) // returns generated customer id
        {

            // prepare connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // prepare the statement
            string insertString = "insert into Customers " +
                                  "(CustFirstName, CustLastName, CustAddress, CustCity, " +
                                  "  CustProv, CustPostal, CustCountry, CustHomePhone, " +
                                  "  CustBusPhone, CustEmail, AgentID, CustPassword) " +
                               
                                  "values( @CustFirstName, @CustLastName, @CustAddress, @CustCity, " +
                                         " @CustProv, @CustPostal, @CustCountry, @CustHomePhone, " +
                                         " @CustBusPhone, @CustEmail, @CustAgentID, @CustPassword)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);

            //bind with the information given
            insertCommand.Parameters.AddWithValue("@CustFirstName", cust.CustFirstName);
            insertCommand.Parameters.AddWithValue("@CustLastName", cust.CustLastName);
            insertCommand.Parameters.AddWithValue("@CustAddress", cust.CustAddress);
            insertCommand.Parameters.AddWithValue("@CustCity", cust.CustCity);
            insertCommand.Parameters.AddWithValue("@CustProv", cust.CustProvince);
            insertCommand.Parameters.AddWithValue("@CustPostal", cust.CustPostal);
            insertCommand.Parameters.AddWithValue("@CustCountry", cust.CustCountry);
            insertCommand.Parameters.AddWithValue("@CustHomePhone", cust.CustHomePhone);
            insertCommand.Parameters.AddWithValue("@CustBusPhone", cust.CustBusPhone);
            insertCommand.Parameters.AddWithValue("@CustEmail", cust.CustEmail);
            insertCommand.Parameters.AddWithValue("@CustAgentID", cust.AgentID);
            insertCommand.Parameters.AddWithValue("@Custpassword", cust.CustPassword);
          

            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery(); //for DML statements

                //return true the the command was successful
                if (count > 0)
                    return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //close connection
                connection.Close();
            }
            return false;
        }
        //updates a customer record 
        public static bool UpdateCustomerInfo(Customer customer, Customer updateCust)
        {
            SqlConnection con = TravelExpertsDB.GetConnection(); //connect to db
                                                                 //
            // prepare the string for updating
            string updateString = "UPDATE Customers "
                + "SET CustFirstName = @NewCustomerFirstName, "
                + "CustLastName = @NewCustLastName, "
                + "CustAddress = @NewCustAddress, "
                + "CustCity = @NewCustCity, "
                + "CustProv = @NewCustProv, "
                + "CustPostal = @NewCustPostal, "
                + "CustCountry = @NewcustCountry, "
                + "CustHomePhone = @NewCustHomePhone, "
                + "CustBusPhone = @NewCustBusPhone, "
                + "CustEmail = @NewCustEmail "
                + "WHERE CustomerId = @OldCustomerId "
                + "AND CustFirstName = @OldCustFirstName "
                + "AND CustLastName = @OldCustLastName "
                + "AND CustAddress = @OldCustAddress "
                + "AND CustCity = @OldCustCity "
                + "AND CustProv = @OldCustProv "
                + "AND CustPostal = @OldCustPostal "
                + "AND CustCountry = @OldcustCountry "
                + "AND CustHomePhone = @OldCustHomePhone "
                + "AND CustBusPhone = @OldCustBusPhone "
                + "AND CustEmail = @OldCustEmail";

            SqlCommand updateCmd = new SqlCommand(updateString, con);

            //bind parameters
            updateCmd.Parameters.AddWithValue("@NewCustomerFirstName", updateCust.CustFirstName);
            updateCmd.Parameters.AddWithValue("@NewCustLastName", updateCust.CustLastName);
            updateCmd.Parameters.AddWithValue("@NewCustAddress", updateCust.CustAddress);
            updateCmd.Parameters.AddWithValue("@NewCustCity", updateCust.CustCity);
            updateCmd.Parameters.AddWithValue("@NewCustProv", updateCust.CustProvince);
            updateCmd.Parameters.AddWithValue("@NewCustPostal", updateCust.CustPostal);
            updateCmd.Parameters.AddWithValue("@NewcustCountry", updateCust.CustCountry);
            updateCmd.Parameters.AddWithValue("@NewCustHomePhone", updateCust.CustHomePhone);
            updateCmd.Parameters.AddWithValue("@NewCustBusPhone", updateCust.CustBusPhone);
            updateCmd.Parameters.AddWithValue("@NewCustEmail", updateCust.CustEmail);

            updateCmd.Parameters.AddWithValue("@OldCustomerId", customer.CustomerID);
            updateCmd.Parameters.AddWithValue("@OldCustFirstName", customer.CustFirstName);
            updateCmd.Parameters.AddWithValue("@OldCustLastName", customer.CustLastName);
            updateCmd.Parameters.AddWithValue("@OldCustAddress", customer.CustAddress);
            updateCmd.Parameters.AddWithValue("@OldCustCity", customer.CustCity);
            updateCmd.Parameters.AddWithValue("@OldCustProv", customer.CustProvince);
            updateCmd.Parameters.AddWithValue("@OldCustPostal", customer.CustPostal);
            updateCmd.Parameters.AddWithValue("@OldcustCountry", customer.CustCountry);
            updateCmd.Parameters.AddWithValue("@OldCustHomePhone", customer.CustHomePhone);
            updateCmd.Parameters.AddWithValue("@OldCustBusPhone", customer.CustBusPhone);
            updateCmd.Parameters.AddWithValue("@OldCustEmail", customer.CustEmail);

            try
            {
                con.Open();
                int count = updateCmd.ExecuteNonQuery(); //execute
                if (count > 0) return true; //return true if successful
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();  //close connection
            }
        }

        //get customer info
        public static Customer GetCustInfo(int customerId)
        {
            Customer cust = new Customer(); //create a new customer
            SqlConnection con = TravelExpertsDB.GetConnection(); //connect to db
            // select values from customers based on ID
            string selectString = "SELECT CustomerId, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, "
                + "CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail "
                + "From Customers "
                + "WHERE CustomerId = @CustomerId "
                + "ORDER BY CustFirstName";
            // 
            SqlCommand cmd = new SqlCommand(selectString, con);
            cmd.Parameters.AddWithValue("@CustomerId", customerId); // bind customer id
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(); //execute query
                while (reader.Read()) // while the reader is reading 
                {
                    cust = new Customer(); //create a new cust and bind the information
                    cust.CustomerID = (int)reader["CustomerId"]; 
                    cust.CustFirstName = reader["CustFirstName"].ToString();
                    cust.CustLastName = reader["CustLastName"].ToString();
                    cust.CustAddress = reader["CustAddress"].ToString();
                    cust.CustCity = reader["CustCity"].ToString();
                    cust.CustProvince = reader["CustProv"].ToString();
                    cust.CustPostal = reader["CustPostal"].ToString();
                    cust.CustCountry = reader["CustCountry"].ToString();
                    cust.CustHomePhone = reader["CustHomePhone"].ToString();
                    cust.CustBusPhone = reader["CustBusPhone"].ToString();
                    cust.CustEmail = reader["CustEmail"].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return cust; //return the customer with attached information
        }

        // get customer information based on ID
        public static Customer GetCustInfoFromEmail (string customerEmail)
        {
            Customer cust = new Customer(); //create a customer 
            SqlConnection con = TravelExpertsDB.GetConnection();
            //get the customer based off of email 
            string selectString = "SELECT CustomerId, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, "
                + "CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail "
                + "From Customers "
                + "WHERE CustEmail = @CustomerEmail";

            SqlCommand cmd = new SqlCommand(selectString, con);
            cmd.Parameters.AddWithValue("@CustomerEmail", customerEmail); //bind to email
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) //for each record 
                {
                    cust = new Customer(); //create a customer and add the values to new customer 
                    cust.CustomerID = (int)reader["CustomerId"];
                    cust.CustFirstName = reader["CustFirstName"].ToString();
                    cust.CustLastName = reader["CustLastName"].ToString();
                    cust.CustAddress = reader["CustAddress"].ToString();
                    cust.CustCity = reader["CustCity"].ToString();
                    cust.CustProvince = reader["CustProv"].ToString();
                    cust.CustPostal = reader["CustPostal"].ToString();
                    cust.CustCountry = reader["CustCountry"].ToString();
                    cust.CustHomePhone = reader["CustHomePhone"].ToString();
                    cust.CustBusPhone = reader["CustBusPhone"].ToString();
                    cust.CustEmail = reader["CustEmail"].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return cust; //return that customer
        }
    }
}
        