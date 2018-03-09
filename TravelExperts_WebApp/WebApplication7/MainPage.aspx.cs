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
*This page is used add functionality of the main page.
* 
*/
namespace WebApplication7
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check to see if the login state is has been set. If it isn't set it to false
            if (string.IsNullOrEmpty((string)Session["loginState"]))
            {
                Session["loginState"] = "false";
            }
        }

        //this is used to change the state of login bar depending if you are logged in or not.
        protected string NavBarState()
        {
            if ((string)Session["loginState"] == "false")
            {
                string d1 = "<li class=\"active\"><a href=\"MainPage.aspx\" > Home </a></li>";
                string d2 = "<li><a href = \"Register.aspx\"> Register </a></li>";
                string d3 = "<li><a href =\"Login.aspx\"> Login </a></li>";

                return d1 + d2 + d3;
            }
            else
            {
                string d1 = "<li class=\"active\"><a href = \"MainPage.aspx\" > Home </a></li>";
                string d2 = "<li ><a href=\"PackageHistory.aspx\">Package History</a></li>";
                string d3 = "<li><a href=\"UpdateInfo.aspx\"> Update Info</a></li>";
                string d4 = "<li ><a href =\"LogoutRedirect.aspx\"> Logout </a></li>";

                return d1 + d2 + d3 + d4;
            }
        }
    }
}