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
*This class is used produce all the visuals you will see on the Product and Suppliers (form1)
* 
*/
namespace Workshop2V2
{
    public partial class frmProduct_Supplier : Form
    {
        public static string supNameSelected;
        public static int supplierIdSelected;
        public static string prodNameSelected;
        public static int prodIdSelected;

        //On form level a list of the products and suppliers are created to hold all the products and suppliers in the database
        List<Products> products = ProductsDB.GetProducts();//All the products are retreived using ProductsDB.GetProducts()
        List<Suppliers> suppliers = SuppliersDB.GetSuppliers();//All the suppliers are retreived using SuppliersDB.GetSuppliers()

        public frmProduct_Supplier()
        {
            InitializeComponent();
        }

        //This method controls what will happen on load to the form. On load the products and suppliers are shown in the listboxes
        private void frmProduct_Supplier_Load(object sender, EventArgs e)
        {
            ReloadListboxes();
        }

        //This method controls what happens when someone selects a product in the products listbox. When a product is selected
        //the supplier list box is populated with the suppliers associated with the product.
        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSuppliers.Items.Clear();//clear all the items in the list box for the suppliers
            try
            {
                string prodName = lbProducts.GetItemText(lbProducts.SelectedItem);//Get the product name for the selected product
                int productId = ProductsDB.getProductId(prodName);//find the productId of the selected item
                //Get a list of supppiers for the selected product
                List<Suppliers> suppliersSel = Products_SuppliersDB.GetSupForProd(productId);

                //Display the suppliers for the selected product
                foreach (Suppliers supplier in suppliersSel)
                {
                    lbSuppliers.Items.Add(supplier.SupName);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            // Button controls            
            btnModifyProd.Visible = true;
            btnDeleteProd.Visible = true;
            btnDeleteData.Visible = true;
            btnAddSupToProd.Visible = true;
            btnAddProdToSup.Visible = false;
            btnModifySup.Visible = false;
            btnDeleteSup.Visible = false;
        }

        //This method controls what happens when someone selects a supplier in the supplier listbox. When a supplier is selected
        //the product list box is populated with the products associated with the supplier.
        private void lbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProducts.Items.Clear();//clear all the items in the list box for the products
            try
            {
                string supName = lbSuppliers.GetItemText(lbSuppliers.SelectedItem);//get the supplier name for the selected supplier
                int supplierId = SuppliersDB.getSupplierId(supName);//get the supplier id from the supplier name
                //use that supplierId to get all the products that are associated with the supplier Id
                List<Products> productsSel = Products_SuppliersDB.GetProdForSup(supplierId);

                //Display the products for the selected supplier
                foreach (Products product in productsSel)
                {
                    lbProducts.Items.Add(product.ProdName);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            // Button controls
            btnModifyProd.Visible = false;
            btnDeleteProd.Visible = false;
            btnDeleteData.Visible = true;
            btnAddSupToProd.Visible = false;
            btnAddProdToSup.Visible = true;
            btnModifySup.Visible = true;
            btnDeleteSup.Visible = true;
        }


        private void frmProduct_Supplier_Activated(object sender, EventArgs e)
        {
            products = ProductsDB.GetProducts();//All the products are retreived using ProductsDB.GetProducts()
            suppliers = SuppliersDB.GetSuppliers();//All the suppliers are retreived using SuppliersDB.GetSuppliers()

            ReloadListboxes();
        }

        private void ReloadListboxes()
        {
            //Clear both lists boxes
            lbProducts.Items.Clear();
            lbSuppliers.Items.Clear();

            //For each product display its product name in the products listbox
            foreach (Products product in products)
            {
                lbProducts.Items.Add(product.ProdName);
            }

            //For each supplier display its supplier name in the supplier listbox
            foreach (Suppliers supplier in suppliers)
            {
                lbSuppliers.Items.Add(supplier.SupName);
            }

            //Disable modify and delete buttons

            btnModifyProd.Visible = false;
            btnDeleteProd.Visible = false;

            btnDeleteData.Visible = false;
            btnDeleteProd.Visible = false;
            btnAddSupToProd.Visible = false;
            btnAddProdToSup.Visible = false;
            btnModifySup.Visible = false;
            btnDeleteSup.Visible = false;
        }

        //* Overall button controls *//
        //This method controls the show all button. When this button is clicked all the products and suppliers will be shown in the 
        //listboxes
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            products = ProductsDB.GetProducts();//All the products are retreived using ProductsDB.GetProducts()
            suppliers = SuppliersDB.GetSuppliers();//All the suppliers are retreived using SuppliersDB.GetSuppliers()

            ReloadListboxes();
        }

        // Opens delete Product Supplier ID
        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            prodNameSelected = lbProducts.GetItemText(lbProducts.SelectedItem);
            supNameSelected = lbSuppliers.GetItemText(lbSuppliers.SelectedItem);
            frmDeleteProdSup prodSupDelete = new frmDeleteProdSup();
            prodSupDelete.Show();
        }

        // Takes you back to main menu
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Continue?", "Moving to Main menu", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //* Product button controls *//
        // Opens product form
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //Need to pass back the ProdID to the form, to avoid errors
            frmAddProd addProd = new frmAddProd();
            addProd.Show();
        }

        // Opens Add Supplier to product form
        private void btnAddSupToProd_Click(object sender, EventArgs e)
        {
            prodNameSelected = lbProducts.GetItemText(lbProducts.SelectedItem);
            frmAddSupToProd addSuppToProd = new frmAddSupToProd();
            addSuppToProd.Show();
        }

        // Opens Modify product form
        private void btnModifyProd_Click(object sender, EventArgs e)
        {
            prodNameSelected = lbProducts.GetItemText(lbProducts.SelectedItem);
            prodIdSelected = ProductsDB.getProductId(prodNameSelected);
            using (frmModifyProd modifyproduct = new frmModifyProd())
            {
                if (modifyproduct.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        // Opens Delete product form
        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            prodNameSelected = lbProducts.GetItemText(lbProducts.SelectedItem);
            prodIdSelected = ProductsDB.getProductId(prodNameSelected);
            using (DeleteProducts deleteproduct = new DeleteProducts())
            {
                if (deleteproduct.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        //* Supplier button controls *//
        // Opens add Supplier form
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier addsupplier = new AddSupplier();
            addsupplier.Show();
        }

        // Opens add product to supplier form
        private void btnAddProdToSup_Click(object sender, EventArgs e)
        {
            supNameSelected = lbSuppliers.GetItemText(lbSuppliers.SelectedItem);
            frmAddProdToSup addProdToSupp = new frmAddProdToSup();
            addProdToSupp.Show();
        }

        // Opens modify supplier form
        private void btnModifySup_Click_1(object sender, EventArgs e)
        {
            supNameSelected = lbSuppliers.GetItemText(lbSuppliers.SelectedItem);
            supplierIdSelected = SuppliersDB.getSupplierId(supNameSelected);
            using (ModifySupplier modifysupplier = new ModifySupplier())
            {
                if (modifysupplier.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        // Opens delete supplier form
        private void btnDeleteSup_Click_1(object sender, EventArgs e)
        {
            supNameSelected = lbSuppliers.GetItemText(lbSuppliers.SelectedItem);
            supplierIdSelected = SuppliersDB.getSupplierId(supNameSelected);
            using (DeleteSuppliers deletesupplier = new DeleteSuppliers())
            {
                if (deletesupplier.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }      

        //* Image Box Button Controls *//

        // Show All data button
        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            btnShowAll.Image = Resources.btnShowall2;
        }

        private void btnShowAll_MouseLeave(object sender, EventArgs e)
        {
            btnShowAll.Image = Resources.btnShowall;
        }

        // Delete Product Supplier button
        private void btnDeleteData_MouseHover(object sender, EventArgs e)
        {
            btnDeleteData.Image = Resources.btnDeletePS2;
        }

        private void btnDeleteData_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteData.Image = Resources.btnDeletePS;
        }

        // Main Menu button
        private void btnMainPage_MouseHover_1(object sender, EventArgs e)
        {
            btnMainPage.Image = Resources.btnMain2;
        }

        private void btnMainPage_MouseLeave(object sender, EventArgs e)
        {
            btnMainPage.Image = Resources.btnMain;
        }

        // Add new product button

        private void btnAddProduct_MouseHover(object sender, EventArgs e)
        {
            btnAddProduct.Image = Resources.btnAddProd2;
        }

        private void btnAddProduct_MouseLeave(object sender, EventArgs e)
        {
            btnAddProduct.Image = Resources.btnAddProd;
        }

        // Add a supplier to product button
        private void btnAddSupToProd_MouseHover(object sender, EventArgs e)
        {
            btnAddSupToProd.Image = Resources.btnLinkSup2;
        }

        private void btnAddSupToProd_MouseLeave(object sender, EventArgs e)
        {
            btnAddSupToProd.Image = Resources.btnLinkSup;
        }

        // Modify product supplier button
        private void btnModifyProd_MouseHover(object sender, EventArgs e)
        {
            btnModifyProd.Image = Resources.btnModifyProduct2;
        }

        private void btnModifyProd_MouseLeave(object sender, EventArgs e)
        {
            btnModifyProd.Image = Resources.btnModifyProduct;
        }

        // Delete product button
        private void btnDeleteProd_MouseHover(object sender, EventArgs e)
        {
            btnDeleteProd.Image = Resources.btnDeleteProd2;
        }

        private void btnDeleteProd_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteProd.Image = Resources.btnDeleteProd;
        }

        // Add new Supplier button
        private void btnAddSup_MouseHover(object sender, EventArgs e)
        {
            btnAddSupplier.Image = Resources.btnAddSupp2;
        }

        private void btnAddSup_MouseLeave(object sender, EventArgs e)
        {
            btnAddSupplier.Image = Resources.btnAddSupp;
        }

        private void btnAddProdToSup_MouseHover(object sender, EventArgs e)
        {
            btnAddProdToSup.Image = Resources.btnLinkProd2;
        }

        private void btnAddProdToSup_MouseLeave(object sender, EventArgs e)
        {
            btnAddProdToSup.Image = Resources.btnLinkProd;
        }

        // Modify Supplier button
        private void btnModifySupplier_MouseHover(object sender, EventArgs e)
        {
            btnModifySup.Image = Resources.btnModifySupplier2;
        }

        private void btnModifySupplier_MouseLeave(object sender, EventArgs e)
        {
            btnModifySup.Image = Resources.btnModifySupplier;
        }


        // Delete Supplier button
        private void btnDeleteSupplier_MouseHover(object sender, EventArgs e)
        {
            btnDeleteSup.Image = Resources.btnDeleteSup2;
        }

        private void btnDeleteSupplier_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteSup.Image = Resources.btnDeleteSup;
        }
        

        private void frmProduct_Supplier_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
        }
    }        
}
