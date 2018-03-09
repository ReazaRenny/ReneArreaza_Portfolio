using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/* 
* Author: Sean (Validation done by Tyler)
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*
* 
*/
namespace WebApplication7
{
    public partial class Register : System.Web.UI.Page
    {
        //create a new customer and list
        public Customer addCust;

        List<Agents> agentlistfullName = new List<Agents>();

        private void PutCustData(Customer addCust)
        {
            // if there is not selected agent, assign a random agent
            int randomagent;
            Random rdm = new Random();
            randomagent = rdm.Next(1, 9);


            if (chkAgents.Checked)
            {
                addCust.AgentID = Convert.ToInt32(ddlAgents.SelectedValue);

            }

            else if (!chkAgents.Checked)
            {
                addCust.AgentID = randomagent;

            }
            // adds all the information to the database
            addCust.CustFirstName = txtfirst.Text;
            addCust.CustLastName = txtlast.Text;
            addCust.CustAddress = txtaddress.Text;
            addCust.CustCity = txtcity.Text;
            addCust.CustProvince = ddlProvinces.Text;
            addCust.CustPostal = txtpostal.Text;
            addCust.CustCountry = txtcountry.Text;
            addCust.CustHomePhone = txthomephone.Text;
            addCust.CustBusPhone = txtbizphone.Text;
            addCust.CustEmail = txtemail.Text;
            addCust.CustPassword = SecurePasswordHasher.Hash(txtpassword.Text);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //on load, populate the drop down list for agents
                agentlistfullName = AgentDB.GetAgents();
                ddlAgents.DataSource = agentlistfullName;
                ddlAgents.DataTextField = "AgtFullName";
                ddlAgents.DataValueField = "AgentID";
                ddlAgents.DataBind();
            }
        }



        protected void chkAgents_CheckedChanged1(object sender, EventArgs e)
        {
            //if the box is checked, then display and enable the list to be selected
            if (chkAgents.Checked)
            {
                ddlAgents.Visible = true;
                ddlAgents.Enabled = true;
            }

            else if (!chkAgents.Checked)
            {

                ddlAgents.Visible = false;
                ddlAgents.Enabled = false;

            }
        }

        protected void btnToRegister_Click(object sender, EventArgs e)
        {
            //doublecheck the passwords match
            if (txtpassword.Text != txtconfirm.Text)
            {
                Response.Write("Passwords must match");
            }
            else
            {
                //check to make sure the email isn't in a database
                string checkEmail;
                bool emailPresent = true;
                checkEmail = txtemail.Text;

                emailPresent = customerDB.emailalreadyused(checkEmail);
                //if the email is present the respond with a warning
                if (emailPresent == true)
                {
                    Response.Write("Sorry that email is already registered");
                }
                else
                {
                    //if there is no email in the db then add the customer from 
                    addCust = new Customer();
                    this.PutCustData(addCust);
                    try
                    {
                        Session["NewUser"] = addCust;
                        customerDB.AddCustomer(addCust);
                    }
                    catch (Exception)
                    {
                        Response.Write("This is wrong");
                    }
                    //if it works out then send to registration page
                    Server.Transfer("RegistrationComfirmation.aspx", true);
                }
            }
        }

        protected void ddlAgents_Load(object sender, EventArgs e)
        {

            agentlistfullName = AgentDB.GetAgents();
            ddlAgents.DataSource = agentlistfullName;
            ddlAgents.DataTextField = "AgtFullName";
            ddlAgents.DataValueField = "AgentID";
        }
    }
}