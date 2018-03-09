using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
* Author: Rene
* 
*This code is used to validate the textboxes to make sure the data being passed is of the proper format and will not throw any errors.
* 
*/
namespace Workshop2V2
{

    public static class Validator
    {
        private static string title = "Entry Error";

        /// This title will appear in the dialog boxes which call on title.
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        //This code is used to make sure the textbox has data in it before submitting it to the query
        //Returns true if something is present in the textbox
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show("This is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag + " is a required field.", "Entry Error");
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool IsPkgPresent(Control control, string str)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show("This is a required field.", Title);
                    textBox.Text = str;
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag + " is a required field.", "Entry Error");
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }
        //This code is used to make sure the data entered into the textbox is a non negative integer and not to large
        public static bool NonNegativeInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                if(Convert.ToInt32(textBox.Text) <= 0)
                {
                    MessageBox.Show("Number must be a non-negative whole number", "Negative Number");
                    return false;
                }
                else
                    return true;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number WAYYYY TOOO LARGE", "Too Large");
                return false;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + "Must be a whole number.", Title);
                textBox.Focus();
                return false;
            }
        }
        
        //This code is used to check if the date entered is a valid date or if there is even a date entered in the textbox.
        //Also checks to see if the Datetime is between the min and max date values
        public static bool IsDateTimeValid(TextBox textbox, DateTime minDate, DateTime maxDate)
        {
            try
            {
                DateTime.Parse(textbox.Text); //if the DateTime can be parsed then to DateTime then it is good
                if (DateTime.Parse(textbox.Text) >= minDate && DateTime.Parse(textbox.Text) <= maxDate)
                    return true;
                else
                {
                    MessageBox.Show("The date must be on or between " + minDate.ToLongDateString() + " and " + maxDate.ToLongDateString());
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please use a valid Date format!\n\n Example: Month Day, Year", "Invalid Date Format");
                return false;
            }
        }

        //This code is used to make sure the data entered into the textbox is a non negative integer and not to large
        public static bool NonNegativeDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                if (Convert.ToDecimal(textBox.Text) <= 0)
                {
                    MessageBox.Show("Number must be a non-negative whole number", "Negative Number");
                    return false;
                }
                else
                    return true;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number WAYYYY TOOO LARGE", "Too Large");
                return false;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + "Must be a whole number.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool DateMin(DateTimePicker dateTimePicker, DateTime minDate)
        {
            if (dateTimePicker.Value > minDate)
                return true;
            else
            {
                MessageBox.Show("Your package end date must be after your package start date: \n" +
                    "Please pick a date after " + minDate.ToLongDateString());
                return false;
            }
        }

        public static bool isNonNegativeDecimal(TextBox textBox)
        {
            try
            {
                decimal.Parse(textBox.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
                if (decimal.Parse(textBox.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number) <= 0)
                {
                    MessageBox.Show("Number must be a non-negative whole number", "Negative Number");
                    return false;
                }
                else
                    return true;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number WAYYYY TOOO LARGE", "Too Large");
                return false;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + "Must be a valid dollar amount.", Title);
                textBox.Focus();
                return false;
            }
        }

        //public static bool commissionCheck(TextBox text, decimal )
        //{

        //}
    }
}