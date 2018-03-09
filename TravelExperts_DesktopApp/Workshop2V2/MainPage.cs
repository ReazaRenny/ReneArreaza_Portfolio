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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }


        // Close Button
        private void pbClose_Click(object sender, EventArgs e)
        {
            // Closes the application
            this.Close();
        }

        private void pbClose_MouseHover(object sender, EventArgs e)
        {
            pbClose.Image = Resources.Close1;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = Resources.Close2;
        }

        // Product Supplier button
        private void pbBtnPS_Click(object sender, EventArgs e)
        {
            // Opens new form when clicked
            frmProduct_Supplier prodSuppForm = new frmProduct_Supplier();
            prodSuppForm.Show();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pbBtnPS.Image = Resources.btnLaunch2;
        }

        private void pbBtnPS_MouseLeave(object sender, EventArgs e)
        {
            pbBtnPS.Image = Resources.btnLaunch1;
        }

        // Package Button
        private void pbBtnPack_Click(object sender, EventArgs e)
        {
            // Opens new form when clicked
            FrmPackages packagesForm = new FrmPackages();
            packagesForm.Show();
        }

        private void pbBtnPack_MouseHover(object sender, EventArgs e)
        {
            pbBtnPack.Image = Resources.btnLaunch2;
        }

        private void pbBtnPack_MouseLeave(object sender, EventArgs e)
        {
            pbBtnPack.Image = Resources.btnLaunch1;
        }

        private void MainPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)

            {
                this.Close();
            }
        }
    }    
}        
