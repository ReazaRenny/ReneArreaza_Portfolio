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
* This form is used to modify a product in the database
* 
*/
namespace Workshop2V2
{
    public partial class frmModifyProd : Form
    {
        int oldProductid = frmProduct_Supplier.prodIdSelected;
        string oldprodName = frmProduct_Supplier.prodNameSelected;
        public frmModifyProd()
        {
            InitializeComponent();
        }

        //populate the text box from the previous form
        private void frmModifyProd_Load(object sender, EventArgs e)
        {
            txtProductId.Text = oldProductid.ToString();
            txtProductName.Text = oldprodName;
        }

        //update the information 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtProductName))
            {
                //if the information is correct, check if the information is in the list
                string prodName = txtProductName.Text;
                bool exists = false;
                bool attempt = false;
                List<Products> products = ProductsDB.GetProducts();

                foreach (Products product in products)
                {
                    if (product.ProdName == prodName)
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    try
                    {
                        //if the name is unique , replace the other one
                        attempt = ProductsDB.updateProduct(prodName, oldprodName);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error modifying product\n" + ex);
                    }

                    if (attempt)
                    {
                        MessageBox.Show("Successfully modified");
                        this.Close();
                    }
                }
                else { MessageBox.Show("Product name is already in the database"); }
            }
        }

        // Closes the current form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Control buttons
        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Image = Resources.btnUpdate2;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Image = Resources.btnUpdate;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.Image = Resources.btnCancel2;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = Resources.btnCancel;
        }

        //close on esc key
        private void frmModifyProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
        }
    }
}
