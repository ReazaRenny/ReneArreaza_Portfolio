using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/* 
* Author: Tyler
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
* This page shows all the new users information that just registered
* 
*/
namespace WebApplication7
{
    public partial class RegistrationComfirmation : System.Web.UI.Page
    {
        //on load it gets the new users information from the session["NewUser"]
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer newUser = (Customer)Session["NewUser"];
            Customer custId = customerDB.GetCustInfoFromEmail(newUser.CustEmail);
            //Populate the lables with the proper information
            lblCustId.Text = custId.CustomerID.ToString();
            lblfirst.Text = newUser.CustFirstName;
            lbllast.Text = newUser.CustLastName;
            lbladdress.Text = newUser.CustAddress;
            lblcity.Text = newUser.CustCity;
            lblprovince.Text = newUser.CustProvince;
            lblcountry.Text = newUser.CustCountry;
            lblpostal.Text = newUser.CustPostal;
            lblhomephone.Text = newUser.CustHomePhone;
            //check to see if a business phone was given
            if (newUser.CustBusPhone == "")
            {
                lblbizphone.Text = "N/A";
            }else
            {
                lblbizphone.Text = newUser.CustBusPhone;
            }
            lblemail.Text = newUser.CustEmail;
            lblAgent.Text = newUser.AgentID.ToString();
        }
    }
}