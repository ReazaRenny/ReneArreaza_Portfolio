using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReneArreaza_CPRG214_LAB_3.App_Code
{
    [DataObject(true)]
    public class IncidentDB
    {
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Incident> GetOpenTechIncidents(int techID)
        {
            Incident incident; // for reading
            List<Incident> incidentList = new List<Incident>();
            SqlConnection connection = TechSupportDB.GetConnection();
            string selectQuery = "select i.IncidentID, i.CustomerID, c.Name, i.TechID, i.DateOpened, i.DateClosed, i.Title, i.Description " +
                                 "from Incidents i " +
                                 "INNER JOIN Customers c " +
                                 "ON i.CustomerID = c.CustomerID " +
                                 "WHERE i.TechID = @TechID and DateClosed is null";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@TechID", techID);
            try
            {
                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read()) // if there is customer
                {

                    incident = new Incident();
                    incident.IncidentID = (int)reader["IncidentID"];
                    incident.CustomerID = (int)reader["CustomerID"];
                    incident.Name = reader["Name"].ToString();
                    incident.TechID = (int)reader["TechID"];
                    incident.DateOpened = Convert.ToDateTime(reader["DateOpened"]);
                    incident.DateClosed = (reader["DateClosed"] as DateTime?);
                    incident.Title = reader["Title"].ToString();
                    incident.Description = reader["Description"].ToString();
                    incidentList.Add(incident);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return incidentList; 
        }
            

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["TechSupport"].ConnectionString;
        }
    }
}
