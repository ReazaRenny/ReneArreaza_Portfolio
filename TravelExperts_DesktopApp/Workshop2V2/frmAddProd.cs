using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmAddProd : Form
    {
        public frmAddProd()
        {
            InitializeComponent();
        }

        private void frmAddProd_Load(object sender, EventArgs e)
        {
            txtAddProd.Focus();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //if the add button is pressed and the text is valid
            if (Validator.IsPresent(txtAddProd))
            {
                // create a list 
                List<Products> products = ProductsDB.GetProducts(); //add the products information to the list
                bool exists = false;
                String newProdName = txtAddProd.Text;
                foreach (Products product in products) //for product in list, check if theres the same name in the list
                {

                    if (product.ProdName == newProdName)
                        exists = true;

                }
                if (!exists)
                {
                    MessageBox.Show("Successfully added " + newProdName + " to the database");
                    ProductsDB.addProduct(newProdName);
                }
                this.Close();
            }
        }

        //close form if esc key is pressed
        private void frmAddProd_KeyDown(object sender, KeyEventArgs e)
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

        // * Control Buttons * //
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
    }
}
