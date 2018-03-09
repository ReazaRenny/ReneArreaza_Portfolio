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
* This page is used to show all the new information entered by the user after modifying the user
* 
*/
namespace WebApplication7
{
    public partial class UpdatedComfirmation : System.Web.UI.Page
    {
        //On page load the information of the update done by the user is showed
        protected void Page_Load(object sender, EventArgs e)
        {
            //The updatedUser is stored in a Session["updatedUser']
            Customer updatedUser = (Customer)Session["updatedUser"];
            //Display the info as labels 
            lblCustId.Text = updatedUser.CustomerID.ToString();
            lblfirst.Text = updatedUser.CustFirstName;
            lbllast.Text = updatedUser.CustLastName;
            lbladdress.Text = updatedUser.CustAddress;
            lblcity.Text = updatedUser.CustCity;
            lblprovince.Text = updatedUser.CustProvince;
            lblcountry.Text = updatedUser.CustCountry;
            lblpostal.Text = updatedUser.CustPostal;
            lblhomephone.Text = updatedUser.CustHomePhone;
            //check to see if the business phone was given or not
            if (updatedUser.CustBusPhone == "")
            {
                lblbizphone.Text = "N/A";
            }
            else
            {
                lblbizphone.Text = updatedUser.CustBusPhone;
            }
            lblemail.Text = updatedUser.CustEmail;
        }
    }
}