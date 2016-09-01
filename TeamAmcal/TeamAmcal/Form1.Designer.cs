namespace TeamAmcal
{
    partial class frmPeopleHealthPharmacy
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.tabProductOptions = new System.Windows.Forms.TabControl();
            this.tabAddProduct = new System.Windows.Forms.TabPage();
            this.txtAddProdSupplier = new System.Windows.Forms.TextBox();
            this.txtAddProdPrice = new System.Windows.Forms.TextBox();
            this.txtAddProdQuantity = new System.Windows.Forms.TextBox();
            this.txtAddProdName = new System.Windows.Forms.TextBox();
            this.btnAddProdClearInput = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblAddProdSupplier = new System.Windows.Forms.Label();
            this.lblAddProdPrice = new System.Windows.Forms.Label();
            this.lblAddProdQuantity = new System.Windows.Forms.Label();
            this.lblAddProdName = new System.Windows.Forms.Label();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.tabEditProduct = new System.Windows.Forms.TabPage();
            this.cmbEditProdSelect = new System.Windows.Forms.ComboBox();
            this.lblEditProdFind = new System.Windows.Forms.Label();
            this.txtEditProdSupplier = new System.Windows.Forms.TextBox();
            this.txtEditProdPrice = new System.Windows.Forms.TextBox();
            this.txtEditProdQuantity = new System.Windows.Forms.TextBox();
            this.txtEditProdName = new System.Windows.Forms.TextBox();
            this.btnEditProdClearInput = new System.Windows.Forms.Button();
            this.btnEditProdConfirmChanges = new System.Windows.Forms.Button();
            this.lblEditProdSupplier = new System.Windows.Forms.Label();
            this.lblEditProdPrice = new System.Windows.Forms.Label();
            this.lblEditProdQuantity = new System.Windows.Forms.Label();
            this.lblEditProdName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.tabSalesOptions = new System.Windows.Forms.TabControl();
            this.tabAddSales = new System.Windows.Forms.TabPage();
            this.btnAddSalesConfirm = new System.Windows.Forms.Button();
            this.btnAddSalesAddProduct = new System.Windows.Forms.Button();
            this.txtAddSalesQuantity = new System.Windows.Forms.TextBox();
            this.lblAddSalesQuantity = new System.Windows.Forms.Label();
            this.dgvAddSalesReport = new System.Windows.Forms.DataGridView();
            this.colAddSalesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddSalesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddSalesItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddSalesTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAddSalesReport = new System.Windows.Forms.Label();
            this.cmbAddSalesSelect = new System.Windows.Forms.ComboBox();
            this.lblAddSalesSelect = new System.Windows.Forms.Label();
            this.tabEditSales = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabReportOptions = new System.Windows.Forms.TabControl();
            this.tabMonthlyReport = new System.Windows.Forms.TabPage();
            this.tabYearlyReport = new System.Windows.Forms.TabPage();
            this.tabMenu.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabProductOptions.SuspendLayout();
            this.tabAddProduct.SuspendLayout();
            this.tabEditProduct.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabSalesOptions.SuspendLayout();
            this.tabAddSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSalesReport)).BeginInit();
            this.tabReports.SuspendLayout();
            this.tabReportOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabProducts);
            this.tabMenu.Controls.Add(this.tabSales);
            this.tabMenu.Controls.Add(this.tabReports);
            this.tabMenu.Location = new System.Drawing.Point(12, 12);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1317, 702);
            this.tabMenu.TabIndex = 1;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.tabProductOptions);
            this.tabProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProducts.Location = new System.Drawing.Point(4, 40);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1309, 658);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // tabProductOptions
            // 
            this.tabProductOptions.Controls.Add(this.tabAddProduct);
            this.tabProductOptions.Controls.Add(this.tabEditProduct);
            this.tabProductOptions.Location = new System.Drawing.Point(6, 6);
            this.tabProductOptions.Name = "tabProductOptions";
            this.tabProductOptions.SelectedIndex = 0;
            this.tabProductOptions.Size = new System.Drawing.Size(1291, 646);
            this.tabProductOptions.TabIndex = 0;
            // 
            // tabAddProduct
            // 
            this.tabAddProduct.Controls.Add(this.txtAddProdSupplier);
            this.tabAddProduct.Controls.Add(this.txtAddProdPrice);
            this.tabAddProduct.Controls.Add(this.txtAddProdQuantity);
            this.tabAddProduct.Controls.Add(this.txtAddProdName);
            this.tabAddProduct.Controls.Add(this.btnAddProdClearInput);
            this.tabAddProduct.Controls.Add(this.btnAddProduct);
            this.tabAddProduct.Controls.Add(this.lblAddProdSupplier);
            this.tabAddProduct.Controls.Add(this.lblAddProdPrice);
            this.tabAddProduct.Controls.Add(this.lblAddProdQuantity);
            this.tabAddProduct.Controls.Add(this.lblAddProdName);
            this.tabAddProduct.Controls.Add(this.lblAddProduct);
            this.tabAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddProduct.Location = new System.Drawing.Point(4, 40);
            this.tabAddProduct.Name = "tabAddProduct";
            this.tabAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddProduct.Size = new System.Drawing.Size(1283, 602);
            this.tabAddProduct.TabIndex = 0;
            this.tabAddProduct.Text = "Add Product";
            this.tabAddProduct.UseVisualStyleBackColor = true;
            // 
            // txtAddProdSupplier
            // 
            this.txtAddProdSupplier.Location = new System.Drawing.Point(278, 253);
            this.txtAddProdSupplier.Name = "txtAddProdSupplier";
            this.txtAddProdSupplier.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdSupplier.TabIndex = 10;
            // 
            // txtAddProdPrice
            // 
            this.txtAddProdPrice.Location = new System.Drawing.Point(278, 199);
            this.txtAddProdPrice.Name = "txtAddProdPrice";
            this.txtAddProdPrice.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdPrice.TabIndex = 9;
            // 
            // txtAddProdQuantity
            // 
            this.txtAddProdQuantity.Location = new System.Drawing.Point(278, 145);
            this.txtAddProdQuantity.Name = "txtAddProdQuantity";
            this.txtAddProdQuantity.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdQuantity.TabIndex = 8;
            // 
            // txtAddProdName
            // 
            this.txtAddProdName.Location = new System.Drawing.Point(278, 90);
            this.txtAddProdName.Name = "txtAddProdName";
            this.txtAddProdName.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdName.TabIndex = 7;
            // 
            // btnAddProdClearInput
            // 
            this.btnAddProdClearInput.Location = new System.Drawing.Point(762, 410);
            this.btnAddProdClearInput.Name = "btnAddProdClearInput";
            this.btnAddProdClearInput.Size = new System.Drawing.Size(191, 60);
            this.btnAddProdClearInput.TabIndex = 6;
            this.btnAddProdClearInput.Text = "Clear Input";
            this.btnAddProdClearInput.UseVisualStyleBackColor = true;
            this.btnAddProdClearInput.Click += new System.EventHandler(this.btnAddProdClearInput_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(458, 410);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(191, 60);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblAddProdSupplier
            // 
            this.lblAddProdSupplier.AutoSize = true;
            this.lblAddProdSupplier.Location = new System.Drawing.Point(151, 256);
            this.lblAddProdSupplier.Name = "lblAddProdSupplier";
            this.lblAddProdSupplier.Size = new System.Drawing.Size(121, 31);
            this.lblAddProdSupplier.TabIndex = 4;
            this.lblAddProdSupplier.Text = "Supplier:";
            // 
            // lblAddProdPrice
            // 
            this.lblAddProdPrice.AutoSize = true;
            this.lblAddProdPrice.Location = new System.Drawing.Point(188, 202);
            this.lblAddProdPrice.Name = "lblAddProdPrice";
            this.lblAddProdPrice.Size = new System.Drawing.Size(84, 31);
            this.lblAddProdPrice.TabIndex = 3;
            this.lblAddProdPrice.Text = "Price:";
            // 
            // lblAddProdQuantity
            // 
            this.lblAddProdQuantity.AutoSize = true;
            this.lblAddProdQuantity.Location = new System.Drawing.Point(148, 148);
            this.lblAddProdQuantity.Name = "lblAddProdQuantity";
            this.lblAddProdQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblAddProdQuantity.TabIndex = 2;
            this.lblAddProdQuantity.Text = "Quantity:";
            // 
            // lblAddProdName
            // 
            this.lblAddProdName.AutoSize = true;
            this.lblAddProdName.Location = new System.Drawing.Point(77, 93);
            this.lblAddProdName.Name = "lblAddProdName";
            this.lblAddProdName.Size = new System.Drawing.Size(195, 31);
            this.lblAddProdName.TabIndex = 1;
            this.lblAddProdName.Text = "Product Name:";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(447, 3);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(367, 63);
            this.lblAddProduct.TabIndex = 0;
            this.lblAddProduct.Text = "Add a Product";
            // 
            // tabEditProduct
            // 
            this.tabEditProduct.Controls.Add(this.cmbEditProdSelect);
            this.tabEditProduct.Controls.Add(this.lblEditProdFind);
            this.tabEditProduct.Controls.Add(this.txtEditProdSupplier);
            this.tabEditProduct.Controls.Add(this.txtEditProdPrice);
            this.tabEditProduct.Controls.Add(this.txtEditProdQuantity);
            this.tabEditProduct.Controls.Add(this.txtEditProdName);
            this.tabEditProduct.Controls.Add(this.btnEditProdClearInput);
            this.tabEditProduct.Controls.Add(this.btnEditProdConfirmChanges);
            this.tabEditProduct.Controls.Add(this.lblEditProdSupplier);
            this.tabEditProduct.Controls.Add(this.lblEditProdPrice);
            this.tabEditProduct.Controls.Add(this.lblEditProdQuantity);
            this.tabEditProduct.Controls.Add(this.lblEditProdName);
            this.tabEditProduct.Controls.Add(this.label5);
            this.tabEditProduct.Location = new System.Drawing.Point(4, 40);
            this.tabEditProduct.Name = "tabEditProduct";
            this.tabEditProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditProduct.Size = new System.Drawing.Size(1283, 602);
            this.tabEditProduct.TabIndex = 1;
            this.tabEditProduct.Text = "Edit Product";
            this.tabEditProduct.UseVisualStyleBackColor = true;
            // 
            // cmbEditProdSelect
            // 
            this.cmbEditProdSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditProdSelect.FormattingEnabled = true;
            this.cmbEditProdSelect.Location = new System.Drawing.Point(405, 97);
            this.cmbEditProdSelect.Name = "cmbEditProdSelect";
            this.cmbEditProdSelect.Size = new System.Drawing.Size(654, 39);
            this.cmbEditProdSelect.TabIndex = 36;
            // 
            // lblEditProdFind
            // 
            this.lblEditProdFind.AutoSize = true;
            this.lblEditProdFind.Location = new System.Drawing.Point(200, 100);
            this.lblEditProdFind.Name = "lblEditProdFind";
            this.lblEditProdFind.Size = new System.Drawing.Size(199, 31);
            this.lblEditProdFind.TabIndex = 35;
            this.lblEditProdFind.Text = "Select Product:";
            // 
            // txtEditProdSupplier
            // 
            this.txtEditProdSupplier.Location = new System.Drawing.Point(405, 318);
            this.txtEditProdSupplier.Name = "txtEditProdSupplier";
            this.txtEditProdSupplier.Size = new System.Drawing.Size(654, 38);
            this.txtEditProdSupplier.TabIndex = 34;
            // 
            // txtEditProdPrice
            // 
            this.txtEditProdPrice.Location = new System.Drawing.Point(405, 264);
            this.txtEditProdPrice.Name = "txtEditProdPrice";
            this.txtEditProdPrice.Size = new System.Drawing.Size(654, 38);
            this.txtEditProdPrice.TabIndex = 33;
            // 
            // txtEditProdQuantity
            // 
            this.txtEditProdQuantity.Location = new System.Drawing.Point(405, 210);
            this.txtEditProdQuantity.Name = "txtEditProdQuantity";
            this.txtEditProdQuantity.Size = new System.Drawing.Size(654, 38);
            this.txtEditProdQuantity.TabIndex = 32;
            // 
            // txtEditProdName
            // 
            this.txtEditProdName.Location = new System.Drawing.Point(405, 155);
            this.txtEditProdName.Name = "txtEditProdName";
            this.txtEditProdName.Size = new System.Drawing.Size(654, 38);
            this.txtEditProdName.TabIndex = 31;
            // 
            // btnEditProdClearInput
            // 
            this.btnEditProdClearInput.Location = new System.Drawing.Point(898, 410);
            this.btnEditProdClearInput.Name = "btnEditProdClearInput";
            this.btnEditProdClearInput.Size = new System.Drawing.Size(191, 74);
            this.btnEditProdClearInput.TabIndex = 30;
            this.btnEditProdClearInput.Text = "Clear Input";
            this.btnEditProdClearInput.UseVisualStyleBackColor = true;
            this.btnEditProdClearInput.Click += new System.EventHandler(this.btnEditProdClearInput_Click);
            // 
            // btnEditProdConfirmChanges
            // 
            this.btnEditProdConfirmChanges.Location = new System.Drawing.Point(593, 410);
            this.btnEditProdConfirmChanges.Name = "btnEditProdConfirmChanges";
            this.btnEditProdConfirmChanges.Size = new System.Drawing.Size(191, 74);
            this.btnEditProdConfirmChanges.TabIndex = 29;
            this.btnEditProdConfirmChanges.Text = "Confirm Changes";
            this.btnEditProdConfirmChanges.UseVisualStyleBackColor = true;
            this.btnEditProdConfirmChanges.Click += new System.EventHandler(this.btnEditProdConfirmChanges_Click_1);
            // 
            // lblEditProdSupplier
            // 
            this.lblEditProdSupplier.AutoSize = true;
            this.lblEditProdSupplier.Location = new System.Drawing.Point(278, 321);
            this.lblEditProdSupplier.Name = "lblEditProdSupplier";
            this.lblEditProdSupplier.Size = new System.Drawing.Size(121, 31);
            this.lblEditProdSupplier.TabIndex = 28;
            this.lblEditProdSupplier.Text = "Supplier:";
            // 
            // lblEditProdPrice
            // 
            this.lblEditProdPrice.AutoSize = true;
            this.lblEditProdPrice.Location = new System.Drawing.Point(315, 267);
            this.lblEditProdPrice.Name = "lblEditProdPrice";
            this.lblEditProdPrice.Size = new System.Drawing.Size(84, 31);
            this.lblEditProdPrice.TabIndex = 27;
            this.lblEditProdPrice.Text = "Price:";
            // 
            // lblEditProdQuantity
            // 
            this.lblEditProdQuantity.AutoSize = true;
            this.lblEditProdQuantity.Location = new System.Drawing.Point(275, 213);
            this.lblEditProdQuantity.Name = "lblEditProdQuantity";
            this.lblEditProdQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblEditProdQuantity.TabIndex = 26;
            this.lblEditProdQuantity.Text = "Quantity:";
            // 
            // lblEditProdName
            // 
            this.lblEditProdName.AutoSize = true;
            this.lblEditProdName.Location = new System.Drawing.Point(204, 158);
            this.lblEditProdName.Name = "lblEditProdName";
            this.lblEditProdName.Size = new System.Drawing.Size(195, 31);
            this.lblEditProdName.TabIndex = 25;
            this.lblEditProdName.Text = "Product Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 63);
            this.label5.TabIndex = 24;
            this.label5.Text = "Edit a Product";
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.tabSalesOptions);
            this.tabSales.Location = new System.Drawing.Point(4, 40);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(1309, 658);
            this.tabSales.TabIndex = 1;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // tabSalesOptions
            // 
            this.tabSalesOptions.Controls.Add(this.tabAddSales);
            this.tabSalesOptions.Controls.Add(this.tabEditSales);
            this.tabSalesOptions.Location = new System.Drawing.Point(6, 6);
            this.tabSalesOptions.Name = "tabSalesOptions";
            this.tabSalesOptions.SelectedIndex = 0;
            this.tabSalesOptions.Size = new System.Drawing.Size(1291, 668);
            this.tabSalesOptions.TabIndex = 0;
            // 
            // tabAddSales
            // 
            this.tabAddSales.Controls.Add(this.btnAddSalesConfirm);
            this.tabAddSales.Controls.Add(this.btnAddSalesAddProduct);
            this.tabAddSales.Controls.Add(this.txtAddSalesQuantity);
            this.tabAddSales.Controls.Add(this.lblAddSalesQuantity);
            this.tabAddSales.Controls.Add(this.dgvAddSalesReport);
            this.tabAddSales.Controls.Add(this.lblAddSalesReport);
            this.tabAddSales.Controls.Add(this.cmbAddSalesSelect);
            this.tabAddSales.Controls.Add(this.lblAddSalesSelect);
            this.tabAddSales.Location = new System.Drawing.Point(4, 40);
            this.tabAddSales.Name = "tabAddSales";
            this.tabAddSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddSales.Size = new System.Drawing.Size(1283, 624);
            this.tabAddSales.TabIndex = 0;
            this.tabAddSales.Text = "Add Sales";
            this.tabAddSales.UseVisualStyleBackColor = true;
            // 
            // btnAddSalesConfirm
            // 
            this.btnAddSalesConfirm.Location = new System.Drawing.Point(996, 451);
            this.btnAddSalesConfirm.Name = "btnAddSalesConfirm";
            this.btnAddSalesConfirm.Size = new System.Drawing.Size(192, 73);
            this.btnAddSalesConfirm.TabIndex = 44;
            this.btnAddSalesConfirm.Text = "Confirm Sale";
            this.btnAddSalesConfirm.UseVisualStyleBackColor = true;
            // 
            // btnAddSalesAddProduct
            // 
            this.btnAddSalesAddProduct.Location = new System.Drawing.Point(996, 342);
            this.btnAddSalesAddProduct.Name = "btnAddSalesAddProduct";
            this.btnAddSalesAddProduct.Size = new System.Drawing.Size(192, 73);
            this.btnAddSalesAddProduct.TabIndex = 43;
            this.btnAddSalesAddProduct.Text = "Add Product";
            this.btnAddSalesAddProduct.UseVisualStyleBackColor = true;
            // 
            // txtAddSalesQuantity
            // 
            this.txtAddSalesQuantity.Location = new System.Drawing.Point(399, 156);
            this.txtAddSalesQuantity.Name = "txtAddSalesQuantity";
            this.txtAddSalesQuantity.Size = new System.Drawing.Size(653, 38);
            this.txtAddSalesQuantity.TabIndex = 42;
            // 
            // lblAddSalesQuantity
            // 
            this.lblAddSalesQuantity.AutoSize = true;
            this.lblAddSalesQuantity.Location = new System.Drawing.Point(268, 159);
            this.lblAddSalesQuantity.Name = "lblAddSalesQuantity";
            this.lblAddSalesQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblAddSalesQuantity.TabIndex = 41;
            this.lblAddSalesQuantity.Text = "Quantity:";
            // 
            // dgvAddSalesReport
            // 
            this.dgvAddSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddSalesName,
            this.colAddSalesQuantity,
            this.colAddSalesItemPrice,
            this.colAddSalesTotal});
            this.dgvAddSalesReport.Location = new System.Drawing.Point(6, 266);
            this.dgvAddSalesReport.Name = "dgvAddSalesReport";
            this.dgvAddSalesReport.RowTemplate.Height = 24;
            this.dgvAddSalesReport.Size = new System.Drawing.Size(968, 340);
            this.dgvAddSalesReport.TabIndex = 40;
            // 
            // colAddSalesName
            // 
            this.colAddSalesName.HeaderText = "Product";
            this.colAddSalesName.Name = "colAddSalesName";
            this.colAddSalesName.ReadOnly = true;
            this.colAddSalesName.Width = 600;
            // 
            // colAddSalesQuantity
            // 
            this.colAddSalesQuantity.HeaderText = "Quantity";
            this.colAddSalesQuantity.Name = "colAddSalesQuantity";
            this.colAddSalesQuantity.ReadOnly = true;
            this.colAddSalesQuantity.Width = 125;
            // 
            // colAddSalesItemPrice
            // 
            this.colAddSalesItemPrice.HeaderText = "Item Price";
            this.colAddSalesItemPrice.Name = "colAddSalesItemPrice";
            this.colAddSalesItemPrice.ReadOnly = true;
            // 
            // colAddSalesTotal
            // 
            this.colAddSalesTotal.HeaderText = "Total";
            this.colAddSalesTotal.Name = "colAddSalesTotal";
            this.colAddSalesTotal.ReadOnly = true;
            // 
            // lblAddSalesReport
            // 
            this.lblAddSalesReport.AutoSize = true;
            this.lblAddSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSalesReport.Location = new System.Drawing.Point(504, 3);
            this.lblAddSalesReport.Name = "lblAddSalesReport";
            this.lblAddSalesReport.Size = new System.Drawing.Size(493, 63);
            this.lblAddSalesReport.TabIndex = 39;
            this.lblAddSalesReport.Text = "Add a Sales Report";
            // 
            // cmbAddSalesSelect
            // 
            this.cmbAddSalesSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddSalesSelect.FormattingEnabled = true;
            this.cmbAddSalesSelect.Location = new System.Drawing.Point(398, 105);
            this.cmbAddSalesSelect.Name = "cmbAddSalesSelect";
            this.cmbAddSalesSelect.Size = new System.Drawing.Size(654, 39);
            this.cmbAddSalesSelect.TabIndex = 38;
            // 
            // lblAddSalesSelect
            // 
            this.lblAddSalesSelect.AutoSize = true;
            this.lblAddSalesSelect.Location = new System.Drawing.Point(193, 108);
            this.lblAddSalesSelect.Name = "lblAddSalesSelect";
            this.lblAddSalesSelect.Size = new System.Drawing.Size(199, 31);
            this.lblAddSalesSelect.TabIndex = 37;
            this.lblAddSalesSelect.Text = "Select Product:";
            // 
            // tabEditSales
            // 
            this.tabEditSales.Location = new System.Drawing.Point(4, 40);
            this.tabEditSales.Name = "tabEditSales";
            this.tabEditSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditSales.Size = new System.Drawing.Size(1283, 624);
            this.tabEditSales.TabIndex = 1;
            this.tabEditSales.Text = "Edit Sales";
            this.tabEditSales.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabReportOptions);
            this.tabReports.Location = new System.Drawing.Point(4, 40);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1309, 658);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tabReportOptions
            // 
            this.tabReportOptions.Controls.Add(this.tabMonthlyReport);
            this.tabReportOptions.Controls.Add(this.tabYearlyReport);
            this.tabReportOptions.Location = new System.Drawing.Point(4, 4);
            this.tabReportOptions.Name = "tabReportOptions";
            this.tabReportOptions.SelectedIndex = 0;
            this.tabReportOptions.Size = new System.Drawing.Size(1296, 673);
            this.tabReportOptions.TabIndex = 0;
            // 
            // tabMonthlyReport
            // 
            this.tabMonthlyReport.Location = new System.Drawing.Point(4, 40);
            this.tabMonthlyReport.Name = "tabMonthlyReport";
            this.tabMonthlyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthlyReport.Size = new System.Drawing.Size(1288, 629);
            this.tabMonthlyReport.TabIndex = 0;
            this.tabMonthlyReport.Text = "Monthly Report";
            this.tabMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // tabYearlyReport
            // 
            this.tabYearlyReport.Location = new System.Drawing.Point(4, 40);
            this.tabYearlyReport.Name = "tabYearlyReport";
            this.tabYearlyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabYearlyReport.Size = new System.Drawing.Size(1288, 629);
            this.tabYearlyReport.TabIndex = 1;
            this.tabYearlyReport.Text = "Yearly Report";
            this.tabYearlyReport.UseVisualStyleBackColor = true;
            // 
            // frmPeopleHealthPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 726);
            this.Controls.Add(this.tabMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPeopleHealthPharmacy";
            this.Text = "People Health Pharmacy Inc.";
            this.tabMenu.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProductOptions.ResumeLayout(false);
            this.tabAddProduct.ResumeLayout(false);
            this.tabAddProduct.PerformLayout();
            this.tabEditProduct.ResumeLayout(false);
            this.tabEditProduct.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.tabSalesOptions.ResumeLayout(false);
            this.tabAddSales.ResumeLayout(false);
            this.tabAddSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSalesReport)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReportOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabControl tabProductOptions;
        private System.Windows.Forms.TabPage tabAddProduct;
        private System.Windows.Forms.TextBox txtAddProdSupplier;
        private System.Windows.Forms.TextBox txtAddProdPrice;
        private System.Windows.Forms.TextBox txtAddProdQuantity;
        private System.Windows.Forms.TextBox txtAddProdName;
        private System.Windows.Forms.Button btnAddProdClearInput;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblAddProdSupplier;
        private System.Windows.Forms.Label lblAddProdPrice;
        private System.Windows.Forms.Label lblAddProdQuantity;
        private System.Windows.Forms.Label lblAddProdName;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.TabPage tabEditProduct;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabControl tabSalesOptions;
        private System.Windows.Forms.TabPage tabAddSales;
        private System.Windows.Forms.TabPage tabEditSales;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabControl tabReportOptions;
        private System.Windows.Forms.TabPage tabMonthlyReport;
        private System.Windows.Forms.TabPage tabYearlyReport;
        private System.Windows.Forms.ComboBox cmbEditProdSelect;
        private System.Windows.Forms.Label lblEditProdFind;
        private System.Windows.Forms.TextBox txtEditProdSupplier;
        private System.Windows.Forms.TextBox txtEditProdPrice;
        private System.Windows.Forms.TextBox txtEditProdQuantity;
        private System.Windows.Forms.TextBox txtEditProdName;
        private System.Windows.Forms.Button btnEditProdClearInput;
        private System.Windows.Forms.Button btnEditProdConfirmChanges;
        private System.Windows.Forms.Label lblEditProdSupplier;
        private System.Windows.Forms.Label lblEditProdPrice;
        private System.Windows.Forms.Label lblEditProdQuantity;
        private System.Windows.Forms.Label lblEditProdName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAddSalesReport;
        private System.Windows.Forms.ComboBox cmbAddSalesSelect;
        private System.Windows.Forms.Label lblAddSalesSelect;
        private System.Windows.Forms.Label lblAddSalesQuantity;
        private System.Windows.Forms.DataGridView dgvAddSalesReport;
        private System.Windows.Forms.Button btnAddSalesConfirm;
        private System.Windows.Forms.Button btnAddSalesAddProduct;
        private System.Windows.Forms.TextBox txtAddSalesQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddSalesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddSalesQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddSalesItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddSalesTotal;
    }
}

