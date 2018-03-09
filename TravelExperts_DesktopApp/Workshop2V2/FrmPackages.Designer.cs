namespace Workshop2V2
{
    partial class FrmPackages
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
            this.lvPkgDetails = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PkgName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PkgStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PkgEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PkgDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PkgBasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PkgAgencyCommission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPackages = new System.Windows.Forms.ListView();
            this.cBSupplier = new System.Windows.Forms.ComboBox();
            this.cBProduct = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.PictureBox();
            this.btnAddProd = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDeletePackage = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnModify = new System.Windows.Forms.PictureBox();
            this.btnAddPackage = new System.Windows.Forms.PictureBox();
            this.btnMainPage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pBot = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.PictureBox();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.pBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPkgDetails
            // 
            this.lvPkgDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Supplier});
            this.lvPkgDetails.FullRowSelect = true;
            this.lvPkgDetails.GridLines = true;
            this.lvPkgDetails.Location = new System.Drawing.Point(318, 438);
            this.lvPkgDetails.MultiSelect = false;
            this.lvPkgDetails.Name = "lvPkgDetails";
            this.lvPkgDetails.Size = new System.Drawing.Size(618, 152);
            this.lvPkgDetails.TabIndex = 4;
            this.lvPkgDetails.UseCompatibleStateImageBehavior = false;
            this.lvPkgDetails.View = System.Windows.Forms.View.Details;
            this.lvPkgDetails.SelectedIndexChanged += new System.EventHandler(this.lvPkgDetails_SelectedIndexChanged);
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 124;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 394;
            // 
            // PackageID
            // 
            this.PackageID.Text = "PackageID";
            this.PackageID.Width = 70;
            // 
            // PkgName
            // 
            this.PkgName.Text = "PkgName";
            this.PkgName.Width = 79;
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.Text = "PkgStartDate";
            this.PkgStartDate.Width = 77;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.Text = "PkgEndDate";
            this.PkgEndDate.Width = 84;
            // 
            // PkgDesc
            // 
            this.PkgDesc.Text = "PkgDesc";
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.Text = "PkgBasePrice";
            this.PkgBasePrice.Width = 87;
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.Text = "PkgAgencyCommission";
            this.PkgAgencyCommission.Width = 144;
            // 
            // lvPackages
            // 
            this.lvPackages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PackageID,
            this.PkgName,
            this.PkgStartDate,
            this.PkgEndDate,
            this.PkgDesc,
            this.PkgBasePrice,
            this.PkgAgencyCommission});
            this.lvPackages.FullRowSelect = true;
            this.lvPackages.GridLines = true;
            this.lvPackages.Location = new System.Drawing.Point(318, 91);
            this.lvPackages.Name = "lvPackages";
            this.lvPackages.Size = new System.Drawing.Size(618, 290);
            this.lvPackages.TabIndex = 0;
            this.lvPackages.UseCompatibleStateImageBehavior = false;
            this.lvPackages.View = System.Windows.Forms.View.Details;
            this.lvPackages.SelectedIndexChanged += new System.EventHandler(this.lvPackages_SelectedIndexChanged);
            // 
            // cBSupplier
            // 
            this.cBSupplier.FormattingEnabled = true;
            this.cBSupplier.Location = new System.Drawing.Point(36, 529);
            this.cBSupplier.Name = "cBSupplier";
            this.cBSupplier.Size = new System.Drawing.Size(232, 21);
            this.cBSupplier.TabIndex = 6;
            this.cBSupplier.SelectedIndexChanged += new System.EventHandler(this.cBSupplier_SelectedIndexChanged);
            // 
            // cBProduct
            // 
            this.cBProduct.FormattingEnabled = true;
            this.cBProduct.Location = new System.Drawing.Point(75, 463);
            this.cBProduct.Name = "cBProduct";
            this.cBProduct.Size = new System.Drawing.Size(160, 21);
            this.cBProduct.TabIndex = 7;
            this.cBProduct.SelectedIndexChanged += new System.EventHandler(this.cBProduct_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(99)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnAddProd);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnDeletePackage);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnAddPackage);
            this.panel1.Controls.Add(this.btnMainPage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 422);
            this.panel1.TabIndex = 12;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Image = global::Workshop2V2.Properties.Resources.btnDeletePP;
            this.btnDeleteProduct.Location = new System.Drawing.Point(72, 337);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(153, 29);
            this.btnDeleteProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDeleteProduct.TabIndex = 46;
            this.btnDeleteProduct.TabStop = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            this.btnDeleteProduct.MouseLeave += new System.EventHandler(this.btnDeleteProduct_MouseLeave);
            this.btnDeleteProduct.MouseHover += new System.EventHandler(this.btnDeleteProduct_MouseHover);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Image = global::Workshop2V2.Properties.Resources.btnAddP;
            this.btnAddProd.Location = new System.Drawing.Point(71, 304);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(154, 28);
            this.btnAddProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAddProd.TabIndex = 48;
            this.btnAddProd.TabStop = false;
            this.btnAddProd.Click += new System.EventHandler(this.AddProd_Click);
            this.btnAddProd.MouseLeave += new System.EventHandler(this.btnAddProd_MouseLeave);
            this.btnAddProd.MouseHover += new System.EventHandler(this.btnAddProd_MouseHover);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 420);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(296, 2);
            this.panel6.TabIndex = 42;
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Image = global::Workshop2V2.Properties.Resources.btnDeletePP;
            this.btnDeletePackage.Location = new System.Drawing.Point(71, 221);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(153, 29);
            this.btnDeletePackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDeletePackage.TabIndex = 47;
            this.btnDeletePackage.TabStop = false;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            this.btnDeletePackage.MouseLeave += new System.EventHandler(this.btnDeletePackage_MouseLeave);
            this.btnDeletePackage.MouseHover += new System.EventHandler(this.btnDeletePackage_MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(296, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 422);
            this.panel5.TabIndex = 41;
            // 
            // btnModify
            // 
            this.btnModify.Image = global::Workshop2V2.Properties.Resources.btnModifyP;
            this.btnModify.Location = new System.Drawing.Point(70, 187);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(154, 29);
            this.btnModify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnModify.TabIndex = 36;
            this.btnModify.TabStop = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            this.btnModify.MouseLeave += new System.EventHandler(this.btnModify_MouseLeave);
            this.btnModify.MouseHover += new System.EventHandler(this.btnModify_MouseHover);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Image = global::Workshop2V2.Properties.Resources.btnAddP;
            this.btnAddPackage.Location = new System.Drawing.Point(70, 156);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(154, 28);
            this.btnAddPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAddPackage.TabIndex = 35;
            this.btnAddPackage.TabStop = false;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAdd_Click_1);
            this.btnAddPackage.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAddPackage.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Image = global::Workshop2V2.Properties.Resources.btnMainP;
            this.btnMainPage.Location = new System.Drawing.Point(71, 76);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(153, 28);
            this.btnMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMainPage.TabIndex = 33;
            this.btnMainPage.TabStop = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            this.btnMainPage.MouseLeave += new System.EventHandler(this.btnMainPage_MouseLeave);
            this.btnMainPage.MouseHover += new System.EventHandler(this.btnMainPage_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Workshop2V2.Properties.Resources.ctrlOverall2;
            this.pictureBox1.Location = new System.Drawing.Point(27, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Workshop2V2.Properties.Resources.ctrlPackage;
            this.pictureBox3.Location = new System.Drawing.Point(26, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Workshop2V2.Properties.Resources.ctrlProduct2;
            this.pictureBox4.Location = new System.Drawing.Point(27, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(241, 114);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 41);
            this.panel2.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 32);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Packages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 9);
            this.label3.TabIndex = 17;
            this.label3.Text = "Version 0.500.200 BETA";
            // 
            // pBot
            // 
            this.pBot.BackColor = System.Drawing.Color.Black;
            this.pBot.Controls.Add(this.label3);
            this.pBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBot.Location = new System.Drawing.Point(0, 617);
            this.pBot.Name = "pBot";
            this.pBot.Size = new System.Drawing.Size(956, 23);
            this.pBot.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Packages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            this.label2.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Products && Suppliers:";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            this.lblProducts.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(120, 438);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(68, 17);
            this.lblProducts.TabIndex = 29;
            this.lblProducts.Text = "Product:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            this.lblSupplier.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(112, 500);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(83, 17);
            this.lblSupplier.TabIndex = 28;
            this.lblSupplier.Text = "Suppliers:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 576);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(954, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 576);
            this.panel4.TabIndex = 31;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = global::Workshop2V2.Properties.Resources.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(78, 569);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(153, 28);
            this.btnConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnConfirm.TabIndex = 45;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.MouseLeave += new System.EventHandler(this.btnConfirm_MouseLeave);
            this.btnConfirm.MouseHover += new System.EventHandler(this.btnConfirm_MouseHover);
            // 
            // pbPic
            // 
            this.pbPic.Image = global::Workshop2V2.Properties.Resources.IconProdSup;
            this.pbPic.Location = new System.Drawing.Point(79, 440);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(151, 150);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPic.TabIndex = 32;
            this.pbPic.TabStop = false;
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            this.lblPkgName.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgName.ForeColor = System.Drawing.Color.White;
            this.lblPkgName.Location = new System.Drawing.Point(625, 399);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(268, 25);
            this.lblPkgName.TabIndex = 46;
            this.lblPkgName.Text = "Products && Suppliers:";
            // 
            // FrmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(956, 640);
            this.Controls.Add(this.lblPkgName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pBot);
            this.Controls.Add(this.cBProduct);
            this.Controls.Add(this.cBSupplier);
            this.Controls.Add(this.lvPkgDetails);
            this.Controls.Add(this.lvPackages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPackages";
            this.Activated += new System.EventHandler(this.FrmPackages_Activated);
            this.Load += new System.EventHandler(this.FrmPackages_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPackages_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pBot.ResumeLayout(false);
            this.pBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvPkgDetails;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.ColumnHeader PackageID;
        private System.Windows.Forms.ColumnHeader PkgName;
        private System.Windows.Forms.ColumnHeader PkgStartDate;
        private System.Windows.Forms.ColumnHeader PkgEndDate;
        private System.Windows.Forms.ColumnHeader PkgDesc;
        private System.Windows.Forms.ColumnHeader PkgBasePrice;
        private System.Windows.Forms.ColumnHeader PkgAgencyCommission;
        private System.Windows.Forms.ListView lvPackages;
        private System.Windows.Forms.ComboBox cBSupplier;
        private System.Windows.Forms.ComboBox cBProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnMainPage;
        private System.Windows.Forms.PictureBox btnAddPackage;
        private System.Windows.Forms.PictureBox btnModify;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnDeletePackage;
        private System.Windows.Forms.PictureBox btnDeleteProduct;
        private System.Windows.Forms.PictureBox btnAddProd;
        private System.Windows.Forms.PictureBox btnConfirm;
        private System.Windows.Forms.Label lblPkgName;
    }
}