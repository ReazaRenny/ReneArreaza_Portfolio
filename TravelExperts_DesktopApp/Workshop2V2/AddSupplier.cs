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
*This form is used to add suppliers to the database
* 
*/
namespace Workshop2V2
{
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSupplierId) && Validator.IsPresent(txtSupplierName) 
                && Validator.NonNegativeInt32(txtSupplierId))
            {
                string supName = txtSupplierName.Text;
                int supplierId = Convert.ToInt32(txtSupplierId.Text);
                bool exists = false;
                bool attempt = false;

                List<Suppliers> suppliers = SuppliersDB.GetSuppliers();
                foreach (Suppliers supplier in suppliers)
                {
                    if (supplier.SupName == supName)
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    try
                    {
                        attempt = SuppliersDB.InsertSupplier(supplierId, supName);
                    }
                    catch
                    {
                        MessageBox.Show("Provided Supplier ID already exists, please enter a different one");
                        txtSupplierId.Focus();
                    }

                    if (attempt)
                    {
                        MessageBox.Show("Successfully added " + supName + " to the database");
                        this.Close();
                    }
                }
            }

        }

        private void btnGetNext_Click(object sender, EventArgs e)
        {
            int NextID = 0;

            NextID = SuppliersDB.getNextSupplierId();
            txtSupplierId.Text = NextID.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // * Control buttons * //
        // Add button
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.Image = Resources.btnAdd2;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Image = Resources.btnAdd;
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

        private void AddSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
        }
    }
}
