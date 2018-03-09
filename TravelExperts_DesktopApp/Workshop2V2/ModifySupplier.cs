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
*
* 
*/
namespace Workshop2V2
{
    public partial class ModifySupplier : Form
    {
        //get information from previous form
        int oldsupplierid = frmProduct_Supplier.supplierIdSelected;
        string oldsupName = frmProduct_Supplier.supNameSelected;
        public ModifySupplier()
        {
            InitializeComponent();
        }

        private void ModifySupplier_Load(object sender, EventArgs e)
        {
            //add values to the text boxes
            txtSupplierId.Text = oldsupplierid.ToString();
            txtSupplierName.Text = oldsupName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check if the information is valid and present
            if (Validator.IsPresent(txtSupplierId) && Validator.IsPresent(txtSupplierName)
                && Validator.NonNegativeInt32(txtSupplierId))
            {
                
                string supName = txtSupplierName.Text;
                int supplierId = Convert.ToInt32(txtSupplierId.Text);
                bool exists = false;
                bool attempt = false;
                List<Suppliers> suppliers = SuppliersDB.GetSuppliers();
                //for each supplier in suppliers list, check if the new name is present
                foreach (Suppliers supplier in suppliers)
                {
                    if (supplier.SupName == supName)
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    //if there is no name by the name
                    try
                    {
                        //replace the information
                        attempt = SuppliersDB.UpdateSupplier(supplierId, supName, oldsupplierid, oldsupName);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error modifying supplier\n" + ex);
                    }

                    if (attempt)
                    {
                        MessageBox.Show("Successfully modified");
                        this.Close();
                    }
                }else { MessageBox.Show("Supplier name is already in the database"); }
            }
        }


        //* Control buttons *//
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

        //close if esc key is pressed
        private void ModifySupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
        }

      
    }
}
