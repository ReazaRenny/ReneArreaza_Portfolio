using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/* 
* Author: Rene (Help from Tyler)
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*
* 
*/
namespace WebApplication7
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Button to login event 
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // UserID is retrieved from database using CheckUserID method 
                var userID = SecurePasswordHasher.CheckUserID(txtCustID.Text);
                // if the UserID is not in the database then execute this block of code
                if (userID == 0)
                {
                    lblAlert.Text = "Please enter a valid CustomerID and Password";
                    txtCustID.Text = "";
                    txtPassword.Text = "";
                    txtCustID.Focus();
                }
                else
                {
                    // pass is equal to the GetHashPassword method using the CustomerID as the argument 
                    // this gets the hashed password from database 
                    var pass = SecurePasswordHasher.GetHashPassword(txtCustID.Text);

                    // result is equal to the Verify method being executed taking the Password input and hashed password as arguments
                    var result = SecurePasswordHasher.Verify(txtPassword.Text, pass);

                    //var result2 = SecurePasswordHasher.ComparePasswords(txtPassword.Text, pass);

                    // if the result is correct and the passwords match then execute this block of code
                    if (result == true)
                    {
                        Session["loginState"] = "true"; // loginstate is set to true
                        Session["user"] = txtCustID.Text; // custId is now the session 
                        Response.Redirect("MainPage.aspx"); // redirect to main page

                    }
                    else
                    {
                        // try again and resets all fields
                        lblAlert.Text = ("Please enter a valid CustomerID and Password");
                        txtCustID.Text = "";
                        txtPassword.Text = "";
                        txtCustID.Focus();
                    }
                }
            }
            catch (Exception)
            {
                lblAlert.Text = ("Please enter a valid CustomerID and Password");
                txtCustID.Text = "";
                txtPassword.Text = "";
                txtCustID.Focus();
            }

            }
        }
}
    