namespace Workshop2V2
{
    partial class frmProduct_Supplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pBot = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteSup = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.PictureBox();
            this.btnModifySup = new System.Windows.Forms.PictureBox();
            this.btnDeleteProd = new System.Windows.Forms.PictureBox();
            this.btnAddProdToSup = new System.Windows.Forms.PictureBox();
            this.btnAddSupplier = new System.Windows.Forms.PictureBox();
            this.btnMainPage = new System.Windows.Forms.PictureBox();
            this.btnModifyProd = new System.Windows.Forms.PictureBox();
            this.btnShowAll = new System.Windows.Forms.PictureBox();
            this.btnAddSupToProd = new System.Windows.Forms.PictureBox();
            this.btnDeleteData = new System.Windows.Forms.PictureBox();
            this.crtlOverall = new System.Windows.Forms.PictureBox();
            this.ctrlProduct = new System.Windows.Forms.PictureBox();
            this.ctrlSupplier = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pBot.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModifySup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProdToSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModifyProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSupToProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlOverall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(43, 135);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(225, 342);
            this.lbProducts.TabIndex = 2;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lbSuppliers
            // 
            this.lbSuppliers.FormattingEnabled = true;
            this.lbSuppliers.Location = new System.Drawing.Point(306, 135);
            this.lbSuppliers.Name = "lbSuppliers";
            this.lbSuppliers.Size = new System.Drawing.Size(225, 342);
            this.lbSuppliers.TabIndex = 3;
            this.lbSuppliers.SelectedIndexChanged += new System.EventHandler(this.lbSuppliers_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 41);
            this.panel1.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 32);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Products && Suppliers";
            // 
            // pBot
            // 
            this.pBot.BackColor = System.Drawing.Color.Black;
            this.pBot.Controls.Add(this.label2);
            this.pBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBot.Location = new System.Drawing.Point(0, 535);
            this.pBot.Name = "pBot";
            this.pBot.Size = new System.Drawing.Size(876, 23);
            this.pBot.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 9);
            this.label2.TabIndex = 17;
            this.label2.Text = "Version 0.500.200 BETA";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Magneto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(80, 83);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(147, 32);
            this.lblProducts.TabIndex = 16;
            this.lblProducts.Text = "Products";
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Magneto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.ForeColor = System.Drawing.Color.White;
            this.lblSuppliers.Location = new System.Drawing.Point(336, 83);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(160, 32);
            this.lblSuppliers.TabIndex = 17;
            this.lblSuppliers.Text = "Suppliers";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(99)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.btnDeleteSup);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Controls.Add(this.btnModifySup);
            this.panel2.Controls.Add(this.btnDeleteProd);
            this.panel2.Controls.Add(this.btnAddProdToSup);
            this.panel2.Controls.Add(this.btnAddSupplier);
            this.panel2.Controls.Add(this.btnMainPage);
            this.panel2.Controls.Add(this.btnModifyProd);
            this.panel2.Controls.Add(this.btnShowAll);
            this.panel2.Controls.Add(this.btnAddSupToProd);
            this.panel2.Controls.Add(this.btnDeleteData);
            this.panel2.Controls.Add(this.crtlOverall);
            this.panel2.Controls.Add(this.ctrlProduct);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.ctrlSupplier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(580, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 494);
            this.panel2.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(294, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 494);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 494);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(578, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 494);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 494);
            this.panel5.TabIndex = 28;
            // 
            // btnDeleteSup
            // 
            this.btnDeleteSup.Image = global::Workshop2V2.Properties.Resources.btnDeleteSup;
            this.btnDeleteSup.Location = new System.Drawing.Point(73, 438);
            this.btnDeleteSup.Name = "btnDeleteSup";
            this.btnDeleteSup.Size = new System.Drawing.Size(152, 28);
            this.btnDeleteSup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDeleteSup.TabIndex = 32;
            this.btnDeleteSup.TabStop = false;
            this.btnDeleteSup.Click += new System.EventHandler(this.btnDeleteSup_Click_1);
            this.btnDeleteSup.MouseLeave += new System.EventHandler(this.btnDeleteSupplier_MouseLeave);
            this.btnDeleteSup.MouseHover += new System.EventHandler(this.btnDeleteSupplier_MouseHover);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = global::Workshop2V2.Properties.Resources.btnAddProd;
            this.btnAddProduct.Location = new System.Drawing.Point(72, 170);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(152, 28);
            this.btnAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAddProduct.TabIndex = 29;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            this.btnAddProduct.MouseLeave += new System.EventHandler(this.btnAddProduct_MouseLeave);
            this.btnAddProduct.MouseHover += new System.EventHandler(this.btnAddProduct_MouseHover);
            // 
            // btnModifySup
            // 
            this.btnModifySup.Image = global::Workshop2V2.Properties.Resources.btnModifySupplier;
            this.btnModifySup.Location = new System.Drawing.Point(73, 407);
            this.btnModifySup.Name = "btnModifySup";
            this.btnModifySup.Size = new System.Drawing.Size(152, 28);
            this.btnModifySup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnModifySup.TabIndex = 31;
            this.btnModifySup.TabStop = false;
            this.btnModifySup.Click += new System.EventHandler(this.btnModifySup_Click_1);
            this.btnModifySup.MouseLeave += new System.EventHandler(this.btnModifySupplier_MouseLeave);
            this.btnModifySup.MouseHover += new System.EventHandler(this.btnModifySupplier_MouseHover);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Image = global::Workshop2V2.Properties.Resources.btnDeleteProd;
            this.btnDeleteProd.Location = new System.Drawing.Point(72, 268);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(152, 28);
            this.btnDeleteProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDeleteProd.TabIndex = 32;
            this.btnDeleteProd.TabStop = false;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            this.btnDeleteProd.MouseLeave += new System.EventHandler(this.btnDeleteProd_MouseLeave);
            this.btnDeleteProd.MouseHover += new System.EventHandler(this.btnDeleteProd_MouseHover);
            // 
            // btnAddProdToSup
            // 
            this.btnAddProdToSup.Image = global::Workshop2V2.Properties.Resources.btnLinkProd;
            this.btnAddProdToSup.Location = new System.Drawing.Point(73, 376);
            this.btnAddProdToSup.Name = "btnAddProdToSup";
            this.btnAddProdToSup.Size = new System.Drawing.Size(152, 28);
            this.btnAddProdToSup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAddProdToSup.TabIndex = 30;
            this.btnAddProdToSup.TabStop = false;
            this.btnAddProdToSup.Click += new System.EventHandler(this.btnAddProdToSup_Click);
            this.btnAddProdToSup.MouseLeave += new System.EventHandler(this.btnAddProdToSup_MouseLeave);
            this.btnAddProdToSup.MouseHover += new System.EventHandler(this.btnAddProdToSup_MouseHover);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Image = global::Workshop2V2.Properties.Resources.btnAddSupp;
            this.btnAddSupplier.Location = new System.Drawing.Point(73, 343);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(152, 28);
            this.btnAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAddSupplier.TabIndex = 29;
            this.btnAddSupplier.TabStop = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            this.btnAddSupplier.MouseLeave += new System.EventHandler(this.btnAddSup_MouseLeave);
            this.btnAddSupplier.MouseHover += new System.EventHandler(this.btnAddSup_MouseHover);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Image = global::Workshop2V2.Properties.Resources.btnMain;
            this.btnMainPage.Location = new System.Drawing.Point(72, 65);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(152, 29);
            this.btnMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMainPage.TabIndex = 30;
            this.btnMainPage.TabStop = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            this.btnMainPage.MouseLeave += new System.EventHandler(this.btnMainPage_MouseLeave);
            this.btnMainPage.MouseHover += new System.EventHandler(this.btnMainPage_MouseHover_1);
            // 
            // btnModifyProd
            // 
            this.btnModifyProd.Image = global::Workshop2V2.Properties.Resources.btnModifyProduct;
            this.btnModifyProd.Location = new System.Drawing.Point(72, 236);
            this.btnModifyProd.Name = "btnModifyProd";
            this.btnModifyProd.Size = new System.Drawing.Size(152, 28);
            this.btnModifyProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnModifyProd.TabIndex = 31;
            this.btnModifyProd.TabStop = false;
            this.btnModifyProd.Click += new System.EventHandler(this.btnModifyProd_Click);
            this.btnModifyProd.MouseLeave += new System.EventHandler(this.btnModifyProd_MouseLeave);
            this.btnModifyProd.MouseHover += new System.EventHandler(this.btnModifyProd_MouseHover);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Image = global::Workshop2V2.Properties.Resources.btnShowall;
            this.btnShowAll.Location = new System.Drawing.Point(72, 31);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(152, 28);
            this.btnShowAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnShowAll.TabIndex = 29;
            this.btnShowAll.TabStop = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            this.btnShowAll.MouseLeave += new System.EventHandler(this.btnShowAll_MouseLeave);
            this.btnShowAll.MouseHover += new System.EventHandler(this.btnShow_MouseHover);
            // 
            // btnAddSupToProd
            // 
            this.btnAddSupToProd.Image = global::Workshop2V2.Properties.Resources.btnLinkSup;
            this.btnAddSupToProd.Location = new System.Drawing.Point(72, 204);
            this.btnAddSupToProd.Name = "btnAddSupToProd";
            this.btnAddSupToProd.Size = new System.Drawing.Size(152, 28);
            this.btnAddSupToProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAddSupToProd.TabIndex = 30;
            this.btnAddSupToProd.TabStop = false;
            this.btnAddSupToProd.Click += new System.EventHandler(this.btnAddSupToProd_Click);
            this.btnAddSupToProd.MouseLeave += new System.EventHandler(this.btnAddSupToProd_MouseLeave);
            this.btnAddSupToProd.MouseHover += new System.EventHandler(this.btnAddSupToProd_MouseHover);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Image = global::Workshop2V2.Properties.Resources.btnDeletePS;
            this.btnDeleteData.Location = new System.Drawing.Point(72, 97);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(152, 28);
            this.btnDeleteData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDeleteData.TabIndex = 29;
            this.btnDeleteData.TabStop = false;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            this.btnDeleteData.MouseLeave += new System.EventHandler(this.btnDeleteData_MouseLeave);
            this.btnDeleteData.MouseHover += new System.EventHandler(this.btnDeleteData_MouseHover);
            // 
            // crtlOverall
            // 
            this.crtlOverall.Image = global::Workshop2V2.Properties.Resources.ctrlOverall;
            this.crtlOverall.Location = new System.Drawing.Point(28, -6);
            this.crtlOverall.Name = "crtlOverall";
            this.crtlOverall.Size = new System.Drawing.Size(241, 144);
            this.crtlOverall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.crtlOverall.TabIndex = 0;
            this.crtlOverall.TabStop = false;
            // 
            // ctrlProduct
            // 
            this.ctrlProduct.Image = global::Workshop2V2.Properties.Resources.ctrlProduct;
            this.ctrlProduct.Location = new System.Drawing.Point(29, 133);
            this.ctrlProduct.Name = "ctrlProduct";
            this.ctrlProduct.Size = new System.Drawing.Size(241, 174);
            this.ctrlProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ctrlProduct.TabIndex = 1;
            this.ctrlProduct.TabStop = false;
            // 
            // ctrlSupplier
            // 
            this.ctrlSupplier.Image = global::Workshop2V2.Properties.Resources.ctrlSupploer;
            this.ctrlSupplier.Location = new System.Drawing.Point(29, 304);
            this.ctrlSupplier.Name = "ctrlSupplier";
            this.ctrlSupplier.Size = new System.Drawing.Size(240, 175);
            this.ctrlSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ctrlSupplier.TabIndex = 2;
            this.ctrlSupplier.TabStop = false;
            // 
            // frmProduct_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(876, 558);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBot);
            this.Controls.Add(this.lbSuppliers);
            this.Controls.Add(this.lbProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmProduct_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products and Suppliers";
            this.Activated += new System.EventHandler(this.frmProduct_Supplier_Activated);
            this.Load += new System.EventHandler(this.frmProduct_Supplier_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduct_Supplier_KeyDown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pBot.ResumeLayout(false);
            this.pBot.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModifySup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProdToSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModifyProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSupToProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlOverall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbSuppliers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pBot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox crtlOverall;
        private System.Windows.Forms.PictureBox ctrlSupplier;
        private System.Windows.Forms.PictureBox ctrlProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btnShowAll;
        private System.Windows.Forms.PictureBox btnDeleteData;
        private System.Windows.Forms.PictureBox btnMainPage;
        private System.Windows.Forms.PictureBox btnAddProduct;
        private System.Windows.Forms.PictureBox btnAddSupToProd;
        private System.Windows.Forms.PictureBox btnModifyProd;
        private System.Windows.Forms.PictureBox btnDeleteProd;
        private System.Windows.Forms.PictureBox btnDeleteSup;
        private System.Windows.Forms.PictureBox btnModifySup;
        private System.Windows.Forms.PictureBox btnAddProdToSup;
        private System.Windows.Forms.PictureBox btnAddSupplier;
    }
}

