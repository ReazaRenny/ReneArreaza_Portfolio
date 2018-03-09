using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReneArreaza_CPRG214_LAB2
{
    public partial class ResultsPage : System.Web.UI.Page
    {
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["counter1"] != null)
                counter1 = (int)Application["counter1"];
            if (Application["counter2"] != null)
                counter2 = (int)Application["counter2"];
            if (Application["counter3"] != null)
                counter3 = (int)Application["counter3"];

            txtDayOne.Text = counter1.ToString();
            txtDayTwo.Text = counter2.ToString();
            txtDayThree.Text = counter3.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CalendarWeb.aspx"); // go back to first page
        }
    }
}