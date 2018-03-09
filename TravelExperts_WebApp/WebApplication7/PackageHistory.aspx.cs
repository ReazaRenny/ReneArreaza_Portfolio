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
*This code is used to decipher what user is logged in and gets the information from the db for its packages
* 
*/
namespace WebApplication7
{
    public partial class PackageHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //this fucntion gets the package history from the database for a customer
        protected String PackageHistoryDisplay()
        {
            //check which user is logged in
            int custId = Convert.ToInt32(Session["user"]);

            //create a list to hold all the package information
            List<CustomerPackage> customerPackageList = new List<CustomerPackage>();
            customerPackageList = PackageDB.GetCustPackages(custId);

            string packageCards = "";
            decimal sum = 0;
            string d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14;

            //create the html for the webiste to display
            foreach (CustomerPackage package in customerPackageList)
            {
                d1 = "<div class=\"row\">";
                d2 = "<div class=\"col-md-12 text-center\" >";
                d3 = "<div class=\"card\" style=\"background-color:lightgray;\">";
                d4 = "<div class=\"card-block\">";
                d5 = "<h3 class=\"card-title\">" + package.PkgName + "</h3>";
                d6 = "<p class=\"card-text\"><b>Description: </b>" + package.PkgDesc + "</p>";
                d7 = "<p class=\"card-text\"><b>Booking Date: </b>" + Convert.ToDateTime(package.BookingDate).ToLongDateString() + "</p>";
                d8 = "<p class=\"card-text\"><b>Traveler Count: </b>" + package.TravelerCount + "</p>";
                d9 = "<p class=\"card-text\"><b>Start Date: </b>" + Convert.ToDateTime(package.PkgStartDate).ToLongDateString() + "</p>";
                d10 = "<p class=\"card-text\"><b>End Date: </b>" + Convert.ToDateTime(package.PkgEndDate).ToLongDateString() + "</p>";
                d11 = "<p class=\"card-text\"><b>Price: </b>" + package.PkgBasePrice.ToString("c") + "</p>";
                d12 = "</div>";
                d13 = "</div>";
                d14 = "</div>";
                sum += package.PkgBasePrice;

                
                packageCards += d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10 + d11 + d12 + d13;
            }

            d1 = "<div class=\"row\">";
            d2 = "<div class=\"col-md-12 text-center\" >";
            d3 = "<div class=\"card\" style=\"background-color:lightgray;\">";
            d4 = "<div class=\"card-block\">";
            d5 = "<h4 class=\"card-title\">Total cost</h4>";
            d6 = "<p class=\"card-text\">" + sum.ToString("c") + "</p>";
            d7 = "</div>";
            d8 = "</div>";
            d9 = "</div>";
            packageCards += d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9;

            //return the html to the page
            return packageCards;
        }
    }
}