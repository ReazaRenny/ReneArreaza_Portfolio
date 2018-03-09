using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReneArreaza_CPRG214_LAB_3.App_Code
{
    [DataObject(true)]
    public class TechnicianDB
    {
        
            [DataObjectMethod(DataObjectMethodType.Select)]
            public static List<Technician> GetAllTechnicians()
            {
                List<Technician> techList = new List<Technician>(); // empty list
                Technician tech; // reference to new tech object
                SqlConnection con = TechSupportDB.GetConnection();
                string selectQuery = "SELECT Name, TechID " +
                                     "FROM Technicians " +
                                     "Order by Name";
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        tech = new Technician();
                        tech.Name = reader["Name"].ToString();
                        tech.TechID = Convert.ToInt32(reader["TechID"].ToString());
                        techList.Add(tech);
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
                return techList;


            }
        }
}