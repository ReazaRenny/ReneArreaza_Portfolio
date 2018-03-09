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
*This class is used to query the database for data from the products table.
* 
*/
namespace Workshop2V2
{
    public static class ProductsDB
    {
        //This method is used to get all the products from the database
        public static List<Products> GetProducts()
        {
            List<Products> productList = new List<Products>();//Create a new product list 
            Products product = null;//create a null product

            SqlConnection con = TravelExpertsDB.GetConnection();//get a connection to the database
            //Create a query to select productId, prodname from the products database
            string selectQuery = "SELECT ProductId, ProdName " +
                                 "FROM Products";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);

            try
            {
                con.Open();//open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the query and store it in reader
                while (reader.Read()) //read the products if they exist
                {
                    //create new product and add properties to them
                    product = new Products();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProdName = (string)reader["ProdName"];
                    productList.Add(product);//Add the product to the list of products
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
            return productList;//return the product list
        }

        //This method is used to get the product name using the productId. It returns the product name as a string
        public static string getProdName(int productId)
        {
            string prodName = "";//Create an empty prodName string

            SqlConnection con = TravelExpertsDB.GetConnection();
            //Create a query that selects the Prodname from the products where productId is given
            string selectQuery = "SELECT ProdName " +
                                 "FROM Products " +
                                 "WHERE ProductId = @ProductId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@ProductId", productId);

            try
            {
                con.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) 
                {
                    prodName = (string)reader["ProdName"];//set prod name to what was stored in the reader
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return prodName;//return the product name
        }

        //This method is used to get the productId when given the product name in the products table from the db. 
        //It returns an integer of the productId. If it returns 0 there are no productId's with that product name.
        public static int getProductId(string prodName)
        {
            int productId = 0;//Create a productId equal to 0

            SqlConnection con = TravelExpertsDB.GetConnection();
            //Create a query that selects the productId from the products where product name is given
            string selectQuery = "SELECT ProductId " +
                                 "FROM Products " +
                                 "WHERE ProdName = @ProdName";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@ProdName", prodName);

            try
            {
                con.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    productId = (int)reader["ProductId"];//set the productId to the value that was found when executed
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return productId;//Return the product ID
        }

        // add the product to the database
        public static bool addProduct(string ProdName)
        {
            //open the connect and insert the name (the number is picked automatically)
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "insert into Products (ProdName) values (@ProdName)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue("@ProdName", ProdName); //bind the new name
            try
            {
                con.Open();
                int count = insertCommand.ExecuteNonQuery();// execute
                Console.WriteLine("Rows Affected: " + count);
                if (count > 0)
                    return true; //return true if the 
                else
                    return false;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        //delete product from DB
        public static bool deleteProduct(int productId)
        {
            //connect to the db and delete where the product IDs match
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "delete from Products where (ProductId) = (@ProductId)";
            SqlCommand insertCommand = new SqlCommand(deleteStatement, con);
            insertCommand.Parameters.AddWithValue("@ProductId", productId); //bind the parameters
            try
            {
                con.Open();
                int count = insertCommand.ExecuteNonQuery(); //execute
                if (count > 0)
                    return true; //return true if successful
                else
                    return false;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        //update product 
        public static bool updateProduct(string newProdName, string oldProdName)
        {
            //open the connection and set the names equal to thhe the old name
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "Update Products set ProdName = @newProdName where ProdName = @OldProdName";
            SqlCommand insertCommand = new SqlCommand(updateStatement, con);
            insertCommand.Parameters.AddWithValue("@newProdName", newProdName); //bind parameter to the new name
            insertCommand.Parameters.AddWithValue("@oldProdName", oldProdName);
            try
            {
                con.Open();
                int count = insertCommand.ExecuteNonQuery(); //execute 
                Console.WriteLine("Rows Affected: " + count);
                if (count > 0)
                    return true; //return true if successful
                else
                    return false;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        // delete product from packages
        public static bool deleteProductFromPkg(int pkgID, int psID)
        {
            //connect to the db and delete where the package ID and ProductSupplierID match
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Packages_Products_Suppliers " +
                                     "WHERE PackageID = @PackageID " +
                                     "AND ProductSupplierID = @ProductSupplierID";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, con);
            deleteCommand.Parameters.AddWithValue("@PackageID", pkgID); //bind the parameters
            deleteCommand.Parameters.AddWithValue("@ProductSupplierID", psID);

            try
            {
                con.Open();
                int count = deleteCommand.ExecuteNonQuery(); //execute
                if (count > 0)
                    return true; //return true if successful
                else
                    return false;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }       
    }
}
