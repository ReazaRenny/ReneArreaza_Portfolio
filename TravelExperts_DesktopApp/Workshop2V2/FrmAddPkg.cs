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
*
* 
*/
namespace Workshop2V2
{
    
    public partial class FrmAddPkg : Form
    {
        public FrmAddPkg()
        {
            InitializeComponent();
        }
        // new pkg object of packages
        public Packages pkg;
        // add package button event
        private void btnAddPack_Click(object sender, EventArgs e)
        {            
            bool exists = false;
            // validator checks input if its present, and a non negative decimal
            if (Validator.IsPresent(txtPkgName) && Validator.IsPresent(txtPkgDesc) &&
                Validator.IsPresent(txtPkgBasePrice) && Validator.IsPresent(txtPkgAgencyComm) &&
                Validator.NonNegativeDecimal(txtPkgBasePrice) && Validator.NonNegativeDecimal(txtPkgAgencyComm))
            {
                // new packages list retrieved with getpackages method
                List<Packages> packages = PackagesDB.GetPackages();
                foreach (Packages package in packages)
                {
                    if (package.PkgName == txtPkgName.Text)
                    {
                        exists = true;
                    }
                }
                if (!exists) // if it does not exist then execute this block to add package
                {
                    pkg = new Packages();
                    this.PutPkgData(pkg);
                    if (pkg.PkgBasePrice <= pkg.PkgAgencyCommission)
                    {
                        MessageBox.Show("Commission cannot be greater than Base price!");
                        return;
                    }
                    else
                    {
                        try
                        {
                            pkg.PackageID = PackagesDB.AddPackage(pkg);
                            this.DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                        finally
                        {
                            this.Close();
                        }
                    }

                }
                else { MessageBox.Show("A package of a similar name exists in database"); }
            }
        }
        private void PutPkgData(Packages pkg)
        {
            // binds package data to their relevant objects
            pkg.PkgName = txtPkgName.Text;
            pkg.PkgStartDate = dTStartDate.Value;
            pkg.PkgEndDate = dTEndDate.Value;
            pkg.PkgDesc = txtPkgDesc.Text;
            pkg.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
            pkg.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyComm.Text);
        }

        private void FrmAddPkg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
        }

        private void dTEndDate_ValueChanged(object sender, EventArgs e)
        {// if end date value is changed and it is less than the start date then execute error message
            if (dTEndDate.Value < dTStartDate.Value)
            {
                MessageBox.Show("End date cannot be before start date.");
            }
        }


        private void txtPkgAgencyComm_Leave(object sender, EventArgs e)
        {
            //if (Convert.ToDecimal(txtPkgAgencyComm.Text) > Convert.ToDecimal(txtPkgBasePrice.Text))
            //{
            //    MessageBox.Show("Commission cannot be more than the base price.", "Don't be greedy");
            //}
        }


        // Closes the current form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // * Control Buttons * //
        // Add button
        private void btnAddPack_MouseHover(object sender, EventArgs e)
        {
            btnAddPack.Image = Resources.btnAddPack2;
        }

        private void btnAddPack_MouseLeave(object sender, EventArgs e)
        {
            btnAddPack.Image = Resources.btnAddPack;
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
