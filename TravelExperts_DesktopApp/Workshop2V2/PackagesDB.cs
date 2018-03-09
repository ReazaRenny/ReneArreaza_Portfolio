using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author: Rene
* 
*
* 
*/
namespace Workshop2V2
{
    public static class PackagesDB
    {
        public static List<Packages> GetPackages()
        {
            List<Packages> pkgList = new List<Packages>(); // start with new list 
            Packages packages = null; // set new packages object to null 

            SqlConnection con = TravelExpertsDB.GetConnection(); // get connection 
            string selectQuery = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                 "FROM Packages"; // select query to retrieve all relevant data from Packages
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            try
            {
                con.Open(); // open connection 
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    packages = new Packages(); // new packages object 
                    packages.PackageID = Convert.ToInt32(reader["PackageId"]);
                    packages.PkgName = (string)reader["PkgName"];
                    packages.PkgStartDate = reader["PkgStartDate"] as DateTime?;
                    packages.PkgEndDate = reader["PkgEndDate"] as DateTime?;
                    packages.PkgDesc = (string)reader["PkgDesc"];
                    packages.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                    packages.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]); // DATA BOUND TO RELATED NAME 
                    pkgList.Add(packages); // add data from packages object to the list 
                }
            }
            catch (SqlException ex)
            {
                throw ex; // if there is an error, throw exception 
            }
            finally
            {
                con.Close(); // close connection
            }
            return pkgList;
        }
        //gets the product supplier using the package 
        public static List<Package_Product_Suppliers> GetProductSuppliersByPackage(int pkgID)
        {
            if (pkgID == -1)  // if the packageID is negative , return null (dirty workaround) 
            return null;
            else
            {
                // create a new list of Package Product Suppliers 
                List<Package_Product_Suppliers> pps = new List<Package_Product_Suppliers>();
                SqlConnection con = TravelExpertsDB.GetConnection();
                string selectQuery = "SELECT pk.PackageID, pk.PkgName, pps.ProductSupplierID, p.ProdName, s.SupName " +
                                     "FROM Packages pk " +
                                     "INNER JOIN Packages_Products_Suppliers pps " +
                                     "ON pps.PackageID = pk.PackageID " +
                                     "INNER JOIN Products_Suppliers ps " +
                                     "ON pps.ProductSupplierID = ps.ProductSupplierID " +
                                     "INNER JOIN Products p " +
                                     "ON p.ProductID = ps.ProductID " +
                                     "INNER JOIN Suppliers s " +
                                     "ON s.SupplierID = ps.SupplierID " +
                                     "WHERE pk.PackageID = @PackageID"; // QUADRUPLE INNER JOIN -- This monster gets the Product Supplier by package ID
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                selectCommand.Parameters.AddWithValue("@PackageID", pkgID); // bind the data 
                try
                {
                    con.Open(); // open connection 
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Package_Product_Suppliers pps_o = new Package_Product_Suppliers();
                        pps_o.PackageID = Convert.ToInt32(reader["PackageID"]);
                        pps_o.PkgName = (string)reader["PkgName"];
                        pps_o.ProductSupplierID = Convert.ToInt32(reader["ProductSupplierID"]);
                        pps_o.ProdName = (string)reader["ProdName"];
                        pps_o.SupName = (string)reader["SupName"]; // Bind the data to relevant name 
                        pps.Add(pps_o); // add to list 
                    }
                }
                catch(SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close(); // close connection 
                }
                return pps;
            }
        }
        // Add package method 
        public static int AddPackage(Packages pkg)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Packages " + // Insert into packages table, these columns below -- data retrieved from input on addpackages form
                                     "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                     "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue("@PkgName", pkg.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);
            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery(); // for DML statements
                string selectQuery = "SELECT IDENT_CURRENT('Packages') FROM PACKAGES"; // gets a new packageID for package that is next in line 
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                int PackageID = Convert.ToInt32(selectCommand.ExecuteScalar()); // retrieves one value
                                                                                // (int) does not work
                return PackageID;
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
        // Add products to package method, takes two arguments -- Package Supplier ID and Package ID (This creates relationship between product/suppliers and packages
        public static bool AddProdToPackage(int ppsID, int PackageID)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO [Packages_Products_Suppliers] " +
                                     "(PackageID, ProductSupplierID) " +
                                     "VALUES (@PackageID, @ProductSupplierID)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, con);
            insertCommand.Parameters.AddWithValue("@PackageID", PackageID);
            insertCommand.Parameters.AddWithValue("@ProductSupplierID", ppsID);
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

        public static bool UpdatePacakge(Packages oldPackage, Packages newPackage)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection
            //Create a query for inserting a supplier into the suppliers table
            string updateQuery = "UPDATE Packages " +
                                 "SET PkgName=@newPkgName, PkgStartDate=@newPkgStartDate, PkgEndDate=@newPkgEndDate, " +
                                 "PkgDesc=@newPkgDesc, PkgBasePrice=@newPkgBasePrice, PkgAgencyCommission=@newPkgAgencyCommission " +
                                 "WHERE PackageID = @oldPackageID AND PkgName=@oldPkgName AND PkgStartDate=@oldPkgStartDate " +
                                 "AND PkgEndDate=@OldPkgEndDate AND PkgDesc=@oldPkgDesc AND PkgBasePrice=@oldPkgBasePrice " +
                                 "And PkgAgencyCommission=@oldPkgAgencyCommission";

            SqlCommand updateCommand = new SqlCommand(updateQuery, con);//Create a insert command using SqlCommand

            updateCommand.Parameters.AddWithValue("@newPkgName", newPackage.PkgName);
            updateCommand.Parameters.AddWithValue("@newPkgStartDate", newPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@newPkgEndDate", newPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@newPkgDesc", newPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue("@newPkgBasePrice", newPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@newPkgAgencyCommission", newPackage.PkgAgencyCommission);
            updateCommand.Parameters.AddWithValue("@oldPackageID", oldPackage.PackageID);
            updateCommand.Parameters.AddWithValue("@oldPkgName", oldPackage.PkgName);
            updateCommand.Parameters.AddWithValue("@oldPkgStartDate", oldPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@OldPkgEndDate", oldPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@oldPkgDesc", oldPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue("@oldPkgBasePrice", oldPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@oldPkgAgencyCommission", oldPackage.PkgAgencyCommission);

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

        public static Packages GetPackageDetails(int packageId) // Get Package Details with PackageID as an argument -- method written by Rene Arreaza
        {
            Packages packages = null; // set new packages object to null 

            SqlConnection con = TravelExpertsDB.GetConnection(); // get connection 
            string selectQuery = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                 "FROM Packages " +
                                 "WHERE PackageId =" + packageId; // select query to retrieve all relevant data from Packages
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            try
            {
                con.Open(); // open connection 
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    packages = new Packages(); // new packages object 
                    packages.PackageID = Convert.ToInt32(reader["PackageId"]);
                    packages.PkgName = (string)reader["PkgName"];
                    packages.PkgStartDate = reader["PkgStartDate"] as DateTime?;
                    packages.PkgEndDate = reader["PkgEndDate"] as DateTime?;
                    packages.PkgDesc = (string)reader["PkgDesc"];
                    packages.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                    packages.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]);

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
            return packages;
        }
        // Delete Package method -- written by Rene Arreaza
        public static bool DeletePackage(int PackageID)
        {
            // Delete query for SQL
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Packages_Products_Suppliers WHERE PackageId = @PackageId "
                + "DELETE FROM Packages WHERE PackageId = @PackageID";
            SqlCommand insertCommand = new SqlCommand(deleteStatement, con);
            insertCommand.Parameters.AddWithValue("@PackageID", PackageID); // Bind the data

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
        // Get packageID with ProductSupplierID as an argument -- written by Rene Arreaza
        public static int GetPackageIDBy_PsID(int PsID)
        {
            // initiate pkgID as 0
            int pkgID = 0;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT PackageID FROM Packages_Products_Suppliers " +
                                     "WHERE ProductSupplierID = @ProductSupplierID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, con);
            selectCommand.Parameters.AddWithValue("@ProductSupplierID", PsID); // bind the data
            try
            {
                con.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the query and store the result in reader
                if (reader.Read()) //read the products if it exists
                {

                    pkgID = Convert.ToInt32(reader["PackageID"]);
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
            return pkgID;
        }
    }
}
