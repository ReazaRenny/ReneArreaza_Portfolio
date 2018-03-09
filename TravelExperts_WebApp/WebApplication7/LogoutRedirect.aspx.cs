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
*This page is used to change the user to blank and change the loginstate to false and then redirect you to the home page
* 
*/
namespace WebApplication7
{
    public partial class LogoutRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["loginState"] = "false";
            Session["user"] = "";
            Server.Transfer("MainPage.aspx", true);
        }
    }
}