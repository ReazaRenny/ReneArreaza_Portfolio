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
*This class is used to query and access the Products_Suppliers table data from the database.
* 
*/
namespace Workshop2V2
{
    public static class Products_SuppliersDB
    {
        //This method is used to get the suppliers for a certain productId. It returns a List of suppliers
        public static List<Suppliers> GetSupForProd(int productId)
        {
            List<Suppliers> supplierList = new List<Suppliers>();//create a list of suppliers
            Suppliers supplier = null;//create a supplier and set it to null

            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection
            //Create a query that selects all the supplier ID's from the product suppliers where the product ID is given
            string selectQuery = "SELECT SupplierId " +
                                 "FROM Products_Suppliers "+
                                 "WHERE ProductId = @ProductId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);//Create a selectCommand using SqlCommand
            selectCommand.Parameters.AddWithValue("@ProductId", productId);//Bind the given productId to @ProductId

            try
            {
                con.Open();//Open connection
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read()) //read the supplierId's if they exist
                {
                    supplier = new Suppliers();//create a new supplier
                    supplier.SupplierId = (int)reader["SupplierId"];//Add the Id to the supplier
                    supplierList.Add(supplier);//Add the supplier to the list of suppliers
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
            //We now have all the id's for the suppliers but do not have there supplier names
            //Go through each of the suppliers in the supplier list and find there names
            foreach(Suppliers sup in supplierList)
            {
                //use getSupName which is from the SuppliersDB to find the names of the suppliers and add them to there
                //corresponding suppliers.
                sup.SupName = SuppliersDB.getSupName(sup.SupplierId);
            }
            return supplierList;//return the supplier list
        }

        //This method is used to get the Products for a specific supplier. It returns a list of products.
        public static List<Products> GetProdForSup(int supplierId)
        {
            List<Products> productsList = new List<Products>();//create a new productsList
            Products products = null;//create a null product

            SqlConnection con = TravelExpertsDB.GetConnection();//create a connection
            //Create a query which selects a productId from Products_Suppliers table where the supplierId is given
            string selectQuery = "SELECT ProductId " +
                                 "FROM Products_Suppliers " +
                                 "WHERE SupplierId = @SupplierId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);//create a select command using SqlCommand
            selectCommand.Parameters.AddWithValue("@SupplierId", supplierId);//Bind the supplierId to the @supplierId

            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the query and store the result in reader
                while (reader.Read()) //read the products if it exists
                {
                    products = new Products();//create new product
                    products.ProductId = (int)reader["ProductId"];//add productId to product
                    productsList.Add(products);//add product to product list
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();//close connection
            }
            //Right now all the products only have productIds and no product name. Run through each one and add product Name
            foreach (Products prod in productsList)
            {
                //Use the ProductsDB.getProdName to get the prod name using productId
                prod.ProdName = ProductsDB.getProdName(prod.ProductId);
            }
            return productsList;//Return the product list
        }

        public static Products_Suppliers AddSupToProd(Products_Suppliers prodSup)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            // Uses given variables to insert a new row to the table
            string insertStatement = "SET IDENTITY_INSERT Products_Suppliers ON " +
                "INSERT INTO Products_Suppliers " +
                "(ProductSupplierId, ProductId, SupplierId) " +
                "VALUES (@ProductSupplierId, @ProductId, @SupplierId) " +
                "SET IDENTITY_INSERT Products_Suppliers OFF";

            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            // Bind corresponding values
            insertCommand.Parameters.AddWithValue("@ProductSupplierId", prodSup.ProductSupplierId);
            insertCommand.Parameters.AddWithValue("@ProductId", prodSup.ProductId);
            insertCommand.Parameters.AddWithValue("@SupplierId", prodSup.SupplierId);

            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();

                return prodSup;
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

        public static int Get_PpsID(int productID, int supplierID)
        {
            int ppsID = 0;
            SqlConnection con = TravelExpertsDB.GetConnection();//create a connection
            //Create a query which selects a productId from Products_Suppliers table where the supplierId is given
            string selectQuery = "SELECT ProductSupplierId " +
                                 "FROM Products_Suppliers " +
                                 "WHERE ProductId = @ProductId AND SupplierId = @SupplierId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);//create a select command using SqlCommand
            selectCommand.Parameters.AddWithValue("@SupplierId", supplierID);//Bind the supplierId to the @supplierId
            selectCommand.Parameters.AddWithValue("@ProductId", productID);//Bind the supplierId to the @supplierId
            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the query and store the result in reader
                if (reader.Read()) //read the products if it exists
                {

                    ppsID = (int)reader["ProductSupplierId"];
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
            return ppsID;
        }

        // Deletes Product_supplier ID
        public static bool DeleteProdSup(int prodID, int supID)
        {
            SqlConnection con = TravelExpertsDB.GetConnection(); // Connection to DB

            string deleteStatement = "DELETE FROM Products_Suppliers " // SQL query
                + "WHERE ProductId = @ProductId "
                + "AND SupplierId = @SupplierId";

            // Deletes with given parameters of product ID and Supplier ID
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, con);
            deleteCommand.Parameters.AddWithValue("@ProductId", prodID);
            deleteCommand.Parameters.AddWithValue("@SupplierId", supID);

            try
            {
                con.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
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

        public static int getNextProducts_SupplierId()
        {
            int supplierId = 0;//Set the supplierId to 0, if the method return 0 then no supplierId is found for that supplier Name

            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection
            //Create a query for selecting the supplierId from the suppliers table where supplier name is given
            string selectQuery = "select top 1 ProductSupplierID from Products_Suppliers " +
                                 "order by ProductSupplierId desc";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);//Create a select command using SqlCommand
                                                                        // selectCommand.Parameters.AddWithValue("@SupName", supName);//Bind the supplier name to the @SupName

            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);//Execute the query and store the result in reader
                if (reader.Read()) //read the customer if exists
                {
                    supplierId = (int)reader["ProductSupplierId"];//save stored result in supplierId
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

        // Grabs all the Product ID that is not included in the suppliers
        public static List<Products> GetNotInProductsID(int supId)
        {
            List<Products> notIn = new List<Products>();
            Products prod;

            SqlConnection con = TravelExpertsDB.GetConnection();
            //Create a query that selects the productId from the products where product name is given
            string selectQuery = "SELECT DISTINCT ProductId "
                + "FROM Products_Suppliers "
                + "WHERE ProductId not in (SELECT ProductId from Products_Suppliers WHERE SupplierId = @SupplierId)";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@SupplierId", supId);

            try
            {
                con.Open();//open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the query and store it in reader
                while (reader.Read()) //read the products if they exist
                {
                    //create new product and add properties to them
                    prod = new Products();
                    prod.ProductId = (int)reader["ProductId"];
                    notIn.Add(prod);//Add the product to the list of products
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
            return notIn;//Return the product ID
        }

        // Grabs all the supplier Id that is not included in the products
        public static List<Suppliers> GetNotInSuppliersID(int prodId)
        {
            List<Suppliers> notIn = new List<Suppliers>();
            Suppliers supp;

            SqlConnection con = TravelExpertsDB.GetConnection();
            //Create a query that selects the productId from the products where product name is given
            string selectQuery = "SELECT DISTINCT SupplierId "
                + "FROM Products_Suppliers "
                + "WHERE SupplierId not in (SELECT SupplierId from Products_Suppliers WHERE ProductId = @ProductId)";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            selectCommand.Parameters.AddWithValue("@ProductId", prodId);

            try
            {
                con.Open();//open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the query and store it in reader
                while (reader.Read()) //read the products if they exist
                {
                    //create new product and add properties to them
                    supp = new Suppliers();
                    supp.SupplierId = (int)reader["SupplierId"];
                    notIn.Add(supp);//Add the product to the list of products
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
            return notIn;//Return the product ID
        }
    }
}

