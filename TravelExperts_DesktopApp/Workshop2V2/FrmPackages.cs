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
    public partial class FrmPackages : Form
    {
        public static string supNameSelected; // declare variable for supplier name selected
        public static int supplierIdSelected; // declare variable for supplierID Selected
        public static string prodNameSelected; // declare product name selected 
        public static int prodIdSelected; // declare product id selected 
        public static Packages selectedPackage;

        List<Products> products = ProductsDB.GetProducts();//All the products are retreived using ProductsDB.GetProducts()
        List<Suppliers> suppliers = SuppliersDB.GetSuppliers(); // all suppliers are retrieved
        List<Packages> packages = PackagesDB.GetPackages(); // all packages are retrieved 
        
        public FrmPackages()
        {
            InitializeComponent();
        }


        private void btnAdd_Click_1(object sender, EventArgs e) // opens the add package form 
        {
            FrmAddPkg addPkg = new FrmAddPkg();
            addPkg.Show();
            this.Refresh();
        }

        private void AddProd_Click(object sender, EventArgs e) // on click, allow user to see the controls for adding products to package
        {
            btnModify.Visible = false;
            btnDeletePackage.Visible = false;
            pbPic.Visible = false;
            cBProduct.Visible = true;
            btnAddProd.Visible = false;
            lblProducts.Visible = true;
            lblPkgName.Visible = true;
        }

        private void lvPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddPackage.Visible = true;
            btnModify.Visible = true;
            btnDeleteProduct.Visible = false; // remove visibility for delete product button to avoid errors
            btnDeletePackage.Visible = true; // make delete package button visible 
            btnAddProd.Visible = true;
            cBProduct.Visible = false;
            cBSupplier.Visible = false;
            lblProducts.Visible = false;
            lblSupplier.Visible = false;
            btnConfirm.Visible = false;
            pbPic.Visible = true;
            lblPkgName.Visible = true;
            cBProduct.Text = "";
            if (lvPackages.SelectedItems.Count > 0)
            {
                lblPkgName.Text = lvPackages.SelectedItems[0].SubItems[1].Text;
            }            
            lvPkgDetails.Items.Clear();
            try
            {
                if (lvPackages.SelectedItems.Count > 0)
                {
                    int i = 0;
                    //int pkgID = lvPackages.Items.IndexOf(lvPackages.SelectedItems[i]); -- this is an old logic used 
                    int pkgID = Convert.ToInt32(lvPackages.Items[lvPackages.SelectedItems[0].Index].Text);
                    selectedPackage = PackagesDB.GetPackageDetails(pkgID);
                    List<Package_Product_Suppliers> pps_o = PackagesDB.GetProductSuppliersByPackage(pkgID);
                    foreach (Package_Product_Suppliers pps in pps_o)
                    {
                        lvPkgDetails.Items.Add(pps.ProdName);
                        lvPkgDetails.Items[i].SubItems.Add(pps.SupName);
                        i += 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void cBProduct_SelectedIndexChanged(object sender, EventArgs e) // when a product index selected has changed
        {
            btnAddProd.Visible = false; // add product is not visible
            btnDeleteProduct.Visible = false; // delete product is not visible 
            cBSupplier.Items.Clear(); // clear items in list
            cBSupplier.Visible = true; // make supplier combo box visible 
            lblSupplier.Visible = true; // supplier label is visible 
            cBSupplier.SelectedText = ""; // clear selected text
            cBSupplier.Text = ""; // clear supplier text
            try
            {
                string prodName = cBProduct.GetItemText(cBProduct.SelectedItem);//Get the product name for the selected product
                int productId = ProductsDB.getProductId(prodName);//find the productId of the selected item
                //Get a list of supppiers for the selected product
                List<Suppliers> suppliersSel = Products_SuppliersDB.GetSupForProd(productId);

                //Display the suppliers for the selected product
                foreach (Suppliers supplier in suppliersSel)
                {
                    cBSupplier.Items.Add(supplier.SupName);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void FrmPackages_Load(object sender, EventArgs e)
        {
            foreach (Products product in products)
            {
                //  add products to the combo box for selection 
                cBProduct.Items.Add(product.ProdName);
            }
            ShowControl();
        }

        private void btnModify_Click_1(object sender, EventArgs e)  // opens modify package form 
        {
            frmModifyPackages modifyPkg = new frmModifyPackages();
            modifyPkg.Show();
            this.Refresh();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cBSupplier.SelectedText != "")
            {
                string prodNameSelected = cBProduct.GetItemText(cBProduct.SelectedItem);//Get the product name for the selected product
                int prodIdSelected = ProductsDB.getProductId(prodNameSelected);//find the productId of the selected item
                                                                               // get thee supplier name from the combo box selection 
                string supNameSelected = cBSupplier.GetItemText(cBSupplier.SelectedItem);
                // get the supplierID from the suppliername using the method in SuppliersDB
                int supplierIdSelected = SuppliersDB.getSupplierId(supNameSelected);
                // product supplier ID is equal to a method that retrieves it in a SQL Query
                int ppsID = Products_SuppliersDB.Get_PpsID(prodIdSelected, supplierIdSelected);
                // pkgID is equal to the selected ITEM at the index clicked to maintain consistency 
                int pkgID = Convert.ToInt32(lvPackages.Items[lvPackages.SelectedItems[0].Index].Text);

                bool exists = false;
                bool attempt = false;

                if (!exists) // if it does not exist, do this
                {
                    try
                    {
                        // attempt = add product to package method, taking product supplier id and package id as arguments
                        attempt = PackagesDB.AddProdToPackage(ppsID, pkgID);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error modifying package\n" + ex);
                    }

                    if (attempt)
                    {
                        MessageBox.Show("Succesfully modified");
                        int i = 0;
                        lvPkgDetails.Items.Clear();
                        List<Package_Product_Suppliers> pps_o = PackagesDB.GetProductSuppliersByPackage(pkgID);
                        foreach (Package_Product_Suppliers pps in pps_o)
                        {

                            lvPkgDetails.Items.Add(pps.ProdName);
                            lvPkgDetails.Items[i].SubItems.Add(pps.SupName);
                            i += 1;
                        }
                    }
                }
                else { MessageBox.Show("Package is already in the database"); }
            }
            else { MessageBox.Show("Please choose a valid supplier"); }

        }

        private void cBSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
        }

        private void FrmPackages_Activated(object sender, EventArgs e) // when the form is activated (loaded or brought back to after adding) write data to list
        {
            List<Packages> packages = PackagesDB.GetPackages();
            int i = 0; // start count at 0
            lvPackages.Items.Clear();
            foreach (Packages package in packages)
            {
                lvPackages.Items.Add(package.PackageID.ToString());
                lvPackages.Items[i].SubItems.Add(package.PkgName.ToString());
                lvPackages.Items[i].SubItems.Add(package.PkgStartDate.ToString());
                lvPackages.Items[i].SubItems.Add(package.PkgEndDate.ToString());
                lvPackages.Items[i].SubItems.Add(package.PkgDesc.ToString());
                lvPackages.Items[i].SubItems.Add(package.PkgBasePrice.ToString("c"));
                lvPackages.Items[i].SubItems.Add(package.PkgAgencyCommission.ToString("c"));
                i += 1;
            }
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            int pkgID = Convert.ToInt32(lvPackages.Items[lvPackages.SelectedItems[0].Index].Text);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this Product?",
               "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool exists = false;
                bool attempt = false;

                if (!exists) // if it does not exist, do this
                {
                    try
                    {
                        // attempt = add product to package method, taking product supplier id and package id as arguments
                        attempt = PackagesDB.DeletePackage(pkgID);
                        //reload the packages list by getting new list and clearing the old one and adding new items to listview
                        List<Packages> packages = PackagesDB.GetPackages();
                        lvPackages.Items.Clear();
                        int i = 0;
                        foreach (Packages package in packages)
                        {
                            lvPackages.Items.Add(package.PackageID.ToString());
                            lvPackages.Items[i].SubItems.Add(package.PkgName.ToString());
                            lvPackages.Items[i].SubItems.Add(package.PkgStartDate.ToString());
                            lvPackages.Items[i].SubItems.Add(package.PkgEndDate.ToString());
                            lvPackages.Items[i].SubItems.Add(package.PkgDesc.ToString());
                            lvPackages.Items[i].SubItems.Add(package.PkgBasePrice.ToString());
                            lvPackages.Items[i].SubItems.Add(package.PkgAgencyCommission.ToString());
                            i += 1;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error deleting package\n" + ex);
                    }

                    if (attempt)
                    {
                        MessageBox.Show("Successfully deleted");
                        FrmPackages.ActiveForm.Refresh();

                        btnAddProd.Visible = false;
                        lvPkgDetails.Items.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Package is already deleted");
                }
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //supName is equal to the selected items at index 0 to text
            string supName = (lvPkgDetails.Items[lvPkgDetails.SelectedItems[0].Index].Text);
            //suppID is equal to the result of the getProductId method taking supName as an argument
            int suppID = ProductsDB.getProductId(supName);

            //prodName is equal to the selected items at index 0, sub-item index 1 to text
            string prodName = lvPkgDetails.SelectedItems[0].SubItems[1].Text;
            //prodID is equal to the result of the getSupplierId method taking prodName as an argument 
            int prodID = SuppliersDB.getSupplierId(prodName);

            //productSupplierID is equal to the result of the get_PpsID method taking suppID and prodID as arguments
            int psID = Products_SuppliersDB.Get_PpsID(suppID, prodID);

            // pkgID is equal to the result of the GetPackageIDBy_PsID method taking PsID as an argument 
            int pkgID = PackagesDB.GetPackageIDBy_PsID(psID);

            bool exists = false;
            bool attempt = false;

            if (!exists) // if it does not exist, do this
            {
                try
                {
                    // attempt = add product to package method, taking product supplier id and package id as arguments
                    attempt = ProductsDB.deleteProductFromPkg(pkgID, psID);
                    //MessageBox.Show("Succesfully deleted");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error modifying package\n" + ex);
                }

                if (attempt)
                {
                    MessageBox.Show("Succesfully deleted");
                    lvPkgDetails.Items.Clear();
                    int i = 0;
                    //int pkgID = lvPackages.Items.IndexOf(lvPackages.SelectedItems[i]); -- this is an old logic used 

                    List<Package_Product_Suppliers> pps_o = PackagesDB.GetProductSuppliersByPackage(pkgID);
                    foreach (Package_Product_Suppliers pps in pps_o)
                    {

                        lvPkgDetails.Items.Add(pps.ProdName);
                        lvPkgDetails.Items[i].SubItems.Add(pps.SupName);
                        i += 1;
                    }

                }
            }
            else { MessageBox.Show("Unable to delete"); }

            btnAddPackage.Visible = true;
            btnDeleteProduct.Visible = false;
            lvPkgDetails.Items.Clear();
        }

        private void lvPkgDetails_SelectedIndexChanged(object sender, EventArgs e)  // on index changed for listview, change visibility for relevant information/buttons
        {
            btnAddPackage.Visible = false;
            btnModify.Visible = false;
            btnAddProd.Visible = false;
            btnDeleteProduct.Visible = true;
            btnDeletePackage.Visible = false;
            cBProduct.Visible = false;
            cBSupplier.Visible = false;
            lblProducts.Visible = false;
            lblSupplier.Visible = false;
            pbPic.Visible = true;
            btnConfirm.Visible = false;
        }

        // Controls
        private void ShowControl()
        {
            cBProduct.Visible = false;
            cBSupplier.Visible = false;
            btnModify.Visible = false;
            btnDeletePackage.Visible = false;
            btnAddProd.Visible = false;
            btnDeleteProduct.Visible = false;
            lblProducts.Visible = false;
            lblSupplier.Visible = false;
            btnConfirm.Visible = false;
            lblPkgName.Visible = false;
        }

        // Closes the current form and goes to main menu
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Continue?", "Moving to Main menu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmPackages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
        }

        // Control Buttons
        private void btnMainPage_MouseHover(object sender, EventArgs e)
        {
            btnMainPage.Image = Resources.btnMainP2;
        }

        private void btnMainPage_MouseLeave(object sender, EventArgs e)
        {
            btnMainPage.Image = Resources.btnMainP;
        }

        // Pacakges buttons
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAddPackage.Image = Resources.btnAddP2;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAddPackage.Image = Resources.btnAddP;
        }

        private void btnModify_MouseHover(object sender, EventArgs e)
        {
            btnModify.Image = Resources.btnModifyP2;
        }

        private void btnModify_MouseLeave(object sender, EventArgs e)
        {
            btnModify.Image = Resources.btnModifyP;
        }

        private void btnDeletePackage_MouseHover(object sender, EventArgs e)
        {
            btnDeletePackage.Image = Resources.btnDeletePP2;
        }

        private void btnDeletePackage_MouseLeave(object sender, EventArgs e)
        {
            btnDeletePackage.Image = Resources.btnDeletePP;
        }

        private void btnAddProd_MouseHover(object sender, EventArgs e)
        {
            btnAddProd.Image = Resources.btnAddP2;
        }

        private void btnAddProd_MouseLeave(object sender, EventArgs e)
        {
            btnAddProd.Image = Resources.btnAddP;
        }

        private void btnDeleteProduct_MouseHover(object sender, EventArgs e)
        {
            btnDeleteProduct.Image = Resources.btnDeletePP2;
        }

        private void btnDeleteProduct_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteProduct.Image = Resources.btnDeletePP;
        }

        private void btnConfirm_MouseHover(object sender, EventArgs e)
        {
            btnConfirm.Image = Resources.btnConfirm2;
        }

        private void btnConfirm_MouseLeave(object sender, EventArgs e)
        {
            btnConfirm.Image = Resources.btnConfirm;
        }
    }
}
