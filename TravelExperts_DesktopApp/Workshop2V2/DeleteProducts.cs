using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop2V2.Properties;
/* 
* Author: Rene
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*
* 
*/
namespace Workshop2V2
{
    public partial class DeleteProducts : Form
    {
        //assign the information from the previous form in this form
        int productId = frmProduct_Supplier.prodIdSelected;
        string prodName = frmProduct_Supplier.prodNameSelected;
        public DeleteProducts()
        {
            InitializeComponent();
        }

        //on load, print the values to the text box
        private void DeleteProducts_Load(object sender, EventArgs e)
        {
            txtProductId.Text = productId.ToString();
            txtProductName.Text = prodName;
        }
        //delete the product selected from the previous form
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if valid
            if (Validator.IsPresent(txtProductName))
            {
                //send a confirmation message to delete
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Product?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool attempt = false;
                    try
                    {
                        //if yes delete
                        attempt = ProductsDB.deleteProduct(productId);
                    }
                    catch
                    {
                        MessageBox.Show("Cannot delete " + prodName + " when it is currently linked a Supplier." +
                            "Please remove all links for " + prodName + " in order to delete the product");
                    }

                    if (attempt)
                    {
                        MessageBox.Show("Successfully deleted " + prodName);
                        this.Close();
                    }
                }
            }
        }

        //close if esc key is pressed
        private void DeleteProducts_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // * Control buttons * //
        // Delete button
        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.Image = Resources.btnDelete2;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Image = Resources.btnDelete;
        }

        // Cancel button
        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.Image = Resources.btnCancel2;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = Resources.btnCancel;
        }
    }
}
