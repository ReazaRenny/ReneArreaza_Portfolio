using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/* 
* Author: Michael, Tyler
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*
* 
*/
namespace WebApplication7
{
    public partial class UpdateInfo : System.Web.UI.Page
    {
        // Public variables
        public int custId;
        public Customer custOld;
        public Customer custNew;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Displays the current logged in custoemr's data
            {
                custId = Convert.ToInt32(Session["user"]);
                custOld = customerDB.GetCustInfo(custId);
                DisplayCustomer();
            }
            else
            {
                custId = Convert.ToInt32(Session["user"]);
                custOld = customerDB.GetCustInfo(custId);
            }
        }

        // Displays the current logged in custoemr's data
        protected void DisplayCustomer()
        {
            lblID.Text = custOld.CustomerID.ToString();
            txtF.Text = custOld.CustFirstName;
            txtL.Text = custOld.CustLastName;
            txtA.Text = custOld.CustAddress;
            txtCi.Text = custOld.CustCity;
            ddlProvinces.Text = custOld.CustProvince;
            txtCo.Text = custOld.CustCountry;
            txtPo.Text = custOld.CustPostal;
            txtH.Text = custOld.CustHomePhone;
            txtB.Text = custOld.CustBusPhone;
            txtE.Text = custOld.CustEmail;
        }

        // Updates the customer's information
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            bool attempt = false;
            custNew = GetInfo(); // Assign info to new variable
            custNew.CustomerID = custOld.CustomerID;
            Session["updatedUser"] = custNew;

            try
            {
                // Replaces the old formation with new one
                attempt = customerDB.UpdateCustomerInfo(custOld, custNew);
                if (attempt)
                {
                    Server.Transfer("UpdatedComfirmation.aspx", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Gets the edited information from the textboxes
        private Customer GetInfo()
        {
            Customer cust = new Customer();
            cust.CustomerID = Convert.ToInt32(lblID.Text);
            cust.CustFirstName = txtF.Text;
            cust.CustLastName = txtL.Text;
            cust.CustAddress = txtA.Text;
            cust.CustCity = txtCi.Text;
            cust.CustProvince = ddlProvinces.Text;
            cust.CustCountry = txtCo.Text;
            cust.CustPostal = txtPo.Text;
            cust.CustHomePhone = txtH.Text;
            cust.CustBusPhone = txtB.Text;
            cust.CustEmail = txtE.Text;
            return cust;
        }
    }
}