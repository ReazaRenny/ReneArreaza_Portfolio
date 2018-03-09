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
* Author: Rene
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
* Purpose: Adds a Supplier to a Product and generates Product_Supplier ID 
* 
*/
namespace Workshop2V2
{
    public partial class frmAddSupToProd : Form
    {
        public Products_Suppliers suppProd;
        // Brings selected value from the list box from products_Suppliers Form
        string prodName = frmProduct_Supplier.prodNameSelected;

        public frmAddSupToProd()
        {
            InitializeComponent();
        }

        // Load the Products and Supplier data when the form opens for adding a new Product_Supplier
        private void frmAddSupToProd_Load(object sender, EventArgs e)
        {
            // Display selected product and load with suppliers to be added
            txtProdName.Text = prodName;
            LoadSupplierCB();
        }

        // This method populates the combo box with available Suppliers
        private void LoadSupplierCB()
        {
            int prodId = ProductsDB.getProductId(prodName);

            List<Suppliers> temp = new List<Suppliers>(); // Temp variable to store in order to convert string to int
            List<Suppliers> supplierList = new List<Suppliers>();
            // Grabs all supplier ID that doesn't have the particular supplier ID in Product_Supplier
            temp = Products_SuppliersDB.GetNotInSuppliersID(prodId);
            try
            {
                foreach (Suppliers supplier in temp)
                {
                    // Converts the Supplier IDs to Supplier Names 
                    supplier.SupName = SuppliersDB.getSupName(supplier.SupplierId);
                    supplierList.Add(supplier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            // Populate the combo box
            try
            {
                cbSupplierName.DataSource = supplierList;
                cbSupplierName.DisplayMember = "SupName";
                cbSupplierName.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Adds a new row for Product_Supplier table
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtProdSuppId) && Validator.IsPresent(txtProdName)
             && Validator.NonNegativeInt32(txtProdSuppId))
            {

                suppProd = new Products_Suppliers();
                this.PutInSuppToProd(suppProd); // Grabs the data and puts it in variable

                try // Adding through SQL, ProductSupplierDB
                {
                    suppProd = Products_SuppliersDB.AddSupToProd(suppProd);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("1 row added");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Provided Supplier ID already exists, please enter a different one");
                    txtProdSuppId.Focus();
                }
            }
        }
        // Grabbing the data needed to insert into Products_Suppliers Table
        private Products_Suppliers PutInSuppToProd(Products_Suppliers prodSupp)
        {
            prodSupp.ProductSupplierId = Convert.ToInt32(txtProdSuppId.Text);
            prodSupp.ProductId = ProductsDB.getProductId(txtProdName.Text); // Grabbing Product Id through Product name
            prodSupp.SupplierId = SuppliersDB.getSupplierId(cbSupplierName.Text); // Grabbing Supplier Id through Supplier name

            return prodSupp;
        }

        // Closes the current form when ESC is pressed
        private void frmAddSupToProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
        }

        // Gets the next available Product_Supplier ID
        private void btnGetNext_Click(object sender, EventArgs e)
        {
            int NextID = 0;

            NextID = Products_SuppliersDB.getNextProducts_SupplierId();
            txtProdSuppId.Text = NextID.ToString();
        }

        // Closes he current form
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
    }
}
