using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
*This form is used to modify a package in the database
* 
*/
namespace Workshop2V2
{
    public partial class frmModifyPackages : Form
    {
        Packages oldPackage = FrmPackages.selectedPackage;
        public frmModifyPackages()
        {
            InitializeComponent();
        }

        private void frmModifyPackages_Load_1(object sender, EventArgs e)
        {
            txtPkgAgencyComm.Text = oldPackage.PkgAgencyCommission.ToString("c");
            txtPkgBasePrice.Text = oldPackage.PkgBasePrice.ToString("c");
            txtPkgDesc.Text = oldPackage.PkgDesc;
            txtPkgName.Text = oldPackage.PkgName;
            dTStartDate.Value = Convert.ToDateTime(oldPackage.PkgStartDate);
            dTEndDate.Value = Convert.ToDateTime(oldPackage.PkgEndDate);
        }

        private void btnModifyPack_Click_1(object sender, EventArgs e)
        {
            Packages modifiedPackage = new Packages();
            if (Validator.IsPkgPresent(txtPkgAgencyComm, oldPackage.PkgAgencyCommission.ToString("c")) && 
                Validator.isNonNegativeDecimal(txtPkgAgencyComm) &&
                Validator.IsPkgPresent(txtPkgBasePrice, oldPackage.PkgBasePrice.ToString("c")) && 
                Validator.isNonNegativeDecimal(txtPkgBasePrice) &&
                Validator.IsPkgPresent(txtPkgDesc, oldPackage.PkgDesc) && 
                Validator.IsPkgPresent(txtPkgName, oldPackage.PkgName) &&
                Validator.DateMin(dTEndDate, dTStartDate.Value))
            {
                modifiedPackage.PackageID = oldPackage.PackageID;
                modifiedPackage.PkgAgencyCommission = decimal.Parse(txtPkgAgencyComm.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
                modifiedPackage.PkgBasePrice = decimal.Parse(txtPkgBasePrice.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
                modifiedPackage.PkgDesc = txtPkgDesc.Text;
                modifiedPackage.PkgName = txtPkgName.Text;
                modifiedPackage.PkgStartDate = dTStartDate.Value;
                modifiedPackage.PkgEndDate = dTEndDate.Value;

                if (modifiedPackage.PkgBasePrice <= modifiedPackage.PkgAgencyCommission)
                {
                    MessageBox.Show("Commission cannot be greater than Base price!");
                }
                else
                {
                    bool attempt;

                    attempt = PackagesDB.UpdatePacakge(oldPackage, modifiedPackage);
                    if (attempt)
                    {
                        MessageBox.Show("Successfully updated package", "success");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to modify package", "error");
                    }
                }
            }
            //else
            //{
            //    if (txtPkgName.Text == "" || txtPkgDesc.Text == "" || txtPkgBasePrice.Text == "" || txtPkgAgencyComm.Text == "")
            //    {
            //        txtPkgName.Text = oldPackage.PkgName;
            //        txtPkgDesc.Text = oldPackage.PkgDesc;
            //        txtPkgBasePrice.Text = oldPackage.PkgBasePrice.ToString("c");
            //        txtPkgAgencyComm.Text = oldPackage.PkgAgencyCommission.ToString("c");
            //    }
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModifyPack_MouseHover(object sender, EventArgs e)
        {
            btnModifyPack.Image = Resources.btnModifyP2;
        }

        private void btnModifyPack_MouseLeave(object sender, EventArgs e)
        {
            btnModifyPack.Image = Resources.btnModifyP;
        }

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
