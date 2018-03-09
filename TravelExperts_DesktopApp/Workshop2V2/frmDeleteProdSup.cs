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
* Author:Rene
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
* Purpose: Deletes a row from Product_Supplier table
* 
*/
namespace Workshop2V2
{
    public partial class frmDeleteProdSup : Form
    {
        // Brings selected value from the list box from products_Suppliers Form
        string prodName = frmProduct_Supplier.prodNameSelected;
        string supName = frmProduct_Supplier.supNameSelected;

        public frmDeleteProdSup()
        {
            InitializeComponent();
        }

        // Disables the textbox if it isn't empty
        private void frmDeleteProdSup_Load(object sender, EventArgs e)
        {
            cbProdName.Text = prodName;
            cbSupName.Text = supName;

            if (cbProdName.Text == "") // choose from Supplier
            {
                cbSupName.Enabled = false;
                GetProd();
            }
            else // choose from Products
            {
                cbProdName.Enabled = false;
                GetSup();
            }
        }

        // Deletes the Product_Supplier ID
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            prodName = cbProdName.Text;
            supName = cbSupName.Text;

            // Grabs the ID through product and supplier names
            int prodID = ProductsDB.getProductId(prodName);
            int supID = SuppliersDB.getSupplierId(supName);

            // Confirmation message for delete
            DialogResult result = MessageBox.Show("Are you sure you want to delete link between "
                + prodName + " and " + supName + "?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!Products_SuppliersDB.DeleteProdSup(prodID, supID)) // Checks the DB
                    {
                        MessageBox.Show("Another user has updated or deleted " +
                            "that customer.", "Database Error");
                    }                    
                }
                catch 
                {
                    MessageBox.Show("Cannot delete current Product Supplier when it is added as a product in\n" +
                        "a package. Please remove the product from the package first");
                }
            }
            this.Close();
        }        

        private void GetSup()
        {
            try
            {
                int productId = ProductsDB.getProductId(prodName);//find the productId of the selected item
                //Get a list of supppiers for the selected product
                List<Suppliers> suppliersSel = Products_SuppliersDB.GetSupForProd(productId);

                //Display the suppliers for the selected product
                foreach (Suppliers supplier in suppliersSel)
                {
                    cbSupName.Items.Add(supplier.SupName);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void GetProd()
        {
            try
            {                
                int supplierId = SuppliersDB.getSupplierId(supName);//get the supplier id from the supplier name
                //use that supplierId to get all the products that are associated with the supplier Id
                List<Products> productsSel = Products_SuppliersDB.GetProdForSup(supplierId);

                //Display the products for the selected supplier
                foreach (Products product in productsSel)
                {
                    cbProdName.Items.Add(product.ProdName);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // Closes the current form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete canceled");
            this.Close();
        }

        // Closes the form
        private void frmDeleteProdSup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
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
