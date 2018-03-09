using System;
using System.Collections.Generic;
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
*
* 
*/
namespace WebApplication7
{
    class AgentDB
    {
        public static List<Agents> GetAgents()
        {
            List<Agents> agentlist = new List<Agents>();//Create an empty list of Agents
            Agents agent = null;//Create a null agent

            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection to db

            //Build the query to access the AgentID and Names for the Agents Table
            string selectQuery = "SELECT AgentID, AgtFirstName, AgtLastName " +
                                 "FROM Agents";
            //Build the selectCommand by giving SqlCommand the query and the connection to the db
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);

            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the select command and store results in reader
                while (reader.Read()) //Read the agents if they still exist
                {
                    agent = new Agents();//Create a new agent for this iteration
                    //Add the agents properties
                    agent.AgentID = (int)reader["AgentID"];
                    agent.AgtFirstName = (string)reader["AgtFirstName"];
                    agent.AgtLastName = (string)reader["AgtlastName"];

                    agent.AgtFullName = agent.AgtFirstName + " " + agent.AgtLastName;

                    agentlist.Add(agent);//Add this agemt to the agent list
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
            //return List
            return agentlist;


        }

    }
}
