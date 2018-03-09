
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReneArreaza_CPRG214_LAB2
{
    public partial class CalendarWeb : System.Web.UI.Page
    {
        int count = 0;
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
        }

        
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            //current date is set to now
           
            DateTime currentdate = DateTime.Now;
            if(!e.Day.Date.DayOfWeek.ToString().Contains("Saturday") || count > 2 || e.Day.Date <= currentdate) // if the day does not contain saturday, does not have a count greater than 2 and is less than or equal to the current date then..
            {
                e.Cell.Font.Italic = true; // change font style
                e.Cell.Font.Size = FontUnit.XLarge; // change font size
                e.Cell.Font.Strikeout = true; // strikeout font
                e.Day.IsSelectable = false; // Do not make it selectable
                e.Cell.BackColor = System.Drawing.Color.Gray; // "Gray it out"
                e.Cell.Font.Name = "Courier";

            }
            else
            {
                count++;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
                DateTime sat1 = DateTime.Today.AddDays(6 - (int)DateTime.Today.DayOfWeek); // first saturday option
                DateTime sat2 = sat1.AddDays(7); // second saturday option
                DateTime sat3 = sat2.AddDays(7); // third saturday option

                if (Calendar1.SelectedDate == sat1)
                {
                    counter1++; //increment count for date selected
                }
                if (Calendar1.SelectedDate == sat2)
                {
                    counter2++; //increment count for date selected
            }
                if (Calendar1.SelectedDate == sat3) //increment count for date selected
            {
                    counter3++;
                }
                Application.Lock(); // needed only for application state, not view state nor session
                Application["counter1"] = counter1;
                Application["counter2"] = counter2;
                Application["counter3"] = counter3;// add variable to the view state
                Application.UnLock();

            Response.Redirect("~/resultspage.aspx"); // go to second page
        }
            

            

       

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
            lbl1.Text = "You Picked " + Calendar1.SelectedDate.ToShortDateString(); // you picked "Selected Date"
            lbl1.Visible = true; // make label visible
        }
    }
}