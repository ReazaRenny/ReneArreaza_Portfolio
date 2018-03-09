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
*This form is used to delete a supplier from the database
* 
*/
namespace Workshop2V2
{
    public partial class DeleteSuppliers : Form
    {
        int supplierId = frmProduct_Supplier.supplierIdSelected;
        string supName = frmProduct_Supplier.supNameSelected;
        public DeleteSuppliers()
        {
            InitializeComponent();
        }
        private void DeleteSuppliers_Load(object sender, EventArgs e)
        {
            txtSupplierId.Text = supplierId.ToString();
            txtSupplierName.Text = supName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSupplierId))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool attempt = false;
                    try
                    {
                        attempt = SuppliersDB.DeleteSupplier(supplierId);
                    }
                    catch
                    {
                        MessageBox.Show("Cannot delete " + supName + " when it is currently linked a Supplier." +
                            " Please remove all links for " + supName + " in order to delete the product");
                    }

                    if (attempt)
                    {
                        MessageBox.Show("Successfully deleted " + supName);
                        this.Close();
                    }
                }
            }
        }

        private void DeleteSuppliers_KeyDown(object sender, KeyEventArgs e)
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
