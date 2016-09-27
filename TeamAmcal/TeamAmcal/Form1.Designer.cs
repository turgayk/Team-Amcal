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
            this.tabHome = new System.Windows.Forms.TabPage();
            this.gpbHomeGoTo = new System.Windows.Forms.GroupBox();
            this.btnHomeReports = new System.Windows.Forms.Button();
            this.btnHomeSales = new System.Windows.Forms.Button();
            this.btnHomeProducts = new System.Windows.Forms.Button();
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.tabProductOptions = new System.Windows.Forms.TabControl();
            this.tabAddProduct = new System.Windows.Forms.TabPage();
            this.txtAddProdKey = new System.Windows.Forms.TextBox();
            this.lblAddProdKey = new System.Windows.Forms.Label();
            this.txtAddProdDiscount = new System.Windows.Forms.TextBox();
            this.lblAddProdDiscount = new System.Windows.Forms.Label();
            this.txtAddProdRetPrice = new System.Windows.Forms.TextBox();
            this.lblAddProdRetPrice = new System.Windows.Forms.Label();
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
            this.grpEditProdNew = new System.Windows.Forms.GroupBox();
            this.txtEditProdDiscount = new System.Windows.Forms.TextBox();
            this.lblEditProdDiscount = new System.Windows.Forms.Label();
            this.txtEditProdRetPrice = new System.Windows.Forms.TextBox();
            this.lblEditProdRetPrice = new System.Windows.Forms.Label();
            this.cmbEditProdSelect = new System.Windows.Forms.ComboBox();
            this.lblEditProdName = new System.Windows.Forms.Label();
            this.lblEditProdQuantity = new System.Windows.Forms.Label();
            this.lblEditProdFind = new System.Windows.Forms.Label();
            this.lblEditProdPrice = new System.Windows.Forms.Label();
            this.txtEditProdSupplier = new System.Windows.Forms.TextBox();
            this.lblEditProdSupplier = new System.Windows.Forms.Label();
            this.txtEditProdPrice = new System.Windows.Forms.TextBox();
            this.txtEditProdName = new System.Windows.Forms.TextBox();
            this.txtEditProdQuantity = new System.Windows.Forms.TextBox();
            this.grpEditProdOld = new System.Windows.Forms.GroupBox();
            this.txtEditProdOldDiscount = new System.Windows.Forms.TextBox();
            this.txtEditProdOldSupplier = new System.Windows.Forms.TextBox();
            this.txtEditProdOldRetPrice = new System.Windows.Forms.TextBox();
            this.txtEditProdOldPrice = new System.Windows.Forms.TextBox();
            this.txtEditProdOldQuantity = new System.Windows.Forms.TextBox();
            this.txtEditProdOldName = new System.Windows.Forms.TextBox();
            this.lblEditProdOldRetPrice = new System.Windows.Forms.Label();
            this.lblEditProdOldDiscount = new System.Windows.Forms.Label();
            this.lblEditProdOldName = new System.Windows.Forms.Label();
            this.lblEditProdOldQuantity = new System.Windows.Forms.Label();
            this.lblEditProdOldSupplier = new System.Windows.Forms.Label();
            this.lblEditProdOldPrice = new System.Windows.Forms.Label();
            this.btnEditProdClearInput = new System.Windows.Forms.Button();
            this.btnEditProdConfirmChanges = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.txtSalesNotes = new System.Windows.Forms.TextBox();
            this.lblSalesNotes = new System.Windows.Forms.Label();
            this.btnSalesClear = new System.Windows.Forms.Button();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.dtpSalesDatae = new System.Windows.Forms.DateTimePicker();
            this.btnSalesConfirm = new System.Windows.Forms.Button();
            this.btnSalesAddProduct = new System.Windows.Forms.Button();
            this.txtSalesQuantity = new System.Windows.Forms.TextBox();
            this.lblSalesQuantity = new System.Windows.Forms.Label();
            this.dgvAddSales = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddSalesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddSalesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddSalesItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddSalesTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.cmbSalesSelect = new System.Windows.Forms.ComboBox();
            this.lblSalesSelect = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabReportOptions = new System.Windows.Forms.TabControl();
            this.tabMonthlyReport = new System.Windows.Forms.TabPage();
            this.dgcRepMonthlySales = new System.Windows.Forms.DataGridView();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRepMonthlySelect = new System.Windows.Forms.ComboBox();
            this.lblRepMonthlySelect = new System.Windows.Forms.Label();
            this.lblRepMonthlyTitle = new System.Windows.Forms.Label();
            this.tabYearlyReport = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRepYearlySelect = new System.Windows.Forms.ComboBox();
            this.lblRepYearlySelect = new System.Windows.Forms.Label();
            this.lblYearlyReportTitle = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.gpbHomeGoTo.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabProductOptions.SuspendLayout();
            this.tabAddProduct.SuspendLayout();
            this.tabEditProduct.SuspendLayout();
            this.grpEditProdNew.SuspendLayout();
            this.grpEditProdOld.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSales)).BeginInit();
            this.tabReports.SuspendLayout();
            this.tabReportOptions.SuspendLayout();
            this.tabMonthlyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcRepMonthlySales)).BeginInit();
            this.tabYearlyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabHome);
            this.tabMenu.Controls.Add(this.tabProducts);
            this.tabMenu.Controls.Add(this.tabSales);
            this.tabMenu.Controls.Add(this.tabReports);
            this.tabMenu.Location = new System.Drawing.Point(12, 12);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1317, 723);
            this.tabMenu.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.gpbHomeGoTo);
            this.tabHome.Controls.Add(this.lblHomeTitle);
            this.tabHome.Location = new System.Drawing.Point(4, 40);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(1309, 679);
            this.tabHome.TabIndex = 3;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // gpbHomeGoTo
            // 
            this.gpbHomeGoTo.Controls.Add(this.btnHomeReports);
            this.gpbHomeGoTo.Controls.Add(this.btnHomeSales);
            this.gpbHomeGoTo.Controls.Add(this.btnHomeProducts);
            this.gpbHomeGoTo.Location = new System.Drawing.Point(449, 179);
            this.gpbHomeGoTo.Name = "gpbHomeGoTo";
            this.gpbHomeGoTo.Size = new System.Drawing.Size(523, 193);
            this.gpbHomeGoTo.TabIndex = 2;
            this.gpbHomeGoTo.TabStop = false;
            this.gpbHomeGoTo.Text = "Go To:";
            // 
            // btnHomeReports
            // 
            this.btnHomeReports.Location = new System.Drawing.Point(364, 82);
            this.btnHomeReports.Name = "btnHomeReports";
            this.btnHomeReports.Size = new System.Drawing.Size(143, 59);
            this.btnHomeReports.TabIndex = 2;
            this.btnHomeReports.Text = "Reports";
            this.btnHomeReports.UseVisualStyleBackColor = true;
            this.btnHomeReports.Click += new System.EventHandler(this.btnHomeReports_Click);
            // 
            // btnHomeSales
            // 
            this.btnHomeSales.Location = new System.Drawing.Point(199, 82);
            this.btnHomeSales.Name = "btnHomeSales";
            this.btnHomeSales.Size = new System.Drawing.Size(143, 59);
            this.btnHomeSales.TabIndex = 1;
            this.btnHomeSales.Text = "Sales";
            this.btnHomeSales.UseVisualStyleBackColor = true;
            this.btnHomeSales.Click += new System.EventHandler(this.btnHomeSales_Click);
            // 
            // btnHomeProducts
            // 
            this.btnHomeProducts.Location = new System.Drawing.Point(34, 82);
            this.btnHomeProducts.Name = "btnHomeProducts";
            this.btnHomeProducts.Size = new System.Drawing.Size(143, 59);
            this.btnHomeProducts.TabIndex = 0;
            this.btnHomeProducts.Text = "Products";
            this.btnHomeProducts.UseVisualStyleBackColor = true;
            this.btnHomeProducts.Click += new System.EventHandler(this.btnHomeProducts_Click);
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblHomeTitle.Location = new System.Drawing.Point(66, 0);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(1211, 54);
            this.lblHomeTitle.TabIndex = 1;
            this.lblHomeTitle.Text = "Welcome to People Health Pharmacy Inc. Sales Manager";
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.tabProductOptions);
            this.tabProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProducts.Location = new System.Drawing.Point(4, 40);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1309, 679);
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
            this.tabProductOptions.Size = new System.Drawing.Size(1291, 669);
            this.tabProductOptions.TabIndex = 0;
            // 
            // tabAddProduct
            // 
            this.tabAddProduct.Controls.Add(this.txtAddProdKey);
            this.tabAddProduct.Controls.Add(this.lblAddProdKey);
            this.tabAddProduct.Controls.Add(this.txtAddProdDiscount);
            this.tabAddProduct.Controls.Add(this.lblAddProdDiscount);
            this.tabAddProduct.Controls.Add(this.txtAddProdRetPrice);
            this.tabAddProduct.Controls.Add(this.lblAddProdRetPrice);
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
            this.tabAddProduct.Size = new System.Drawing.Size(1283, 625);
            this.tabAddProduct.TabIndex = 0;
            this.tabAddProduct.Text = "Add Product";
            this.tabAddProduct.UseVisualStyleBackColor = true;
            // 
            // txtAddProdKey
            // 
            this.txtAddProdKey.Location = new System.Drawing.Point(401, 432);
            this.txtAddProdKey.Name = "txtAddProdKey";
            this.txtAddProdKey.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdKey.TabIndex = 44;
            // 
            // lblAddProdKey
            // 
            this.lblAddProdKey.AutoSize = true;
            this.lblAddProdKey.Location = new System.Drawing.Point(326, 435);
            this.lblAddProdKey.Name = "lblAddProdKey";
            this.lblAddProdKey.Size = new System.Drawing.Size(69, 31);
            this.lblAddProdKey.TabIndex = 43;
            this.lblAddProdKey.Text = "Key:";
            // 
            // txtAddProdDiscount
            // 
            this.txtAddProdDiscount.Location = new System.Drawing.Point(401, 376);
            this.txtAddProdDiscount.Name = "txtAddProdDiscount";
            this.txtAddProdDiscount.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdDiscount.TabIndex = 42;
            // 
            // lblAddProdDiscount
            // 
            this.lblAddProdDiscount.Location = new System.Drawing.Point(227, 366);
            this.lblAddProdDiscount.Name = "lblAddProdDiscount";
            this.lblAddProdDiscount.Size = new System.Drawing.Size(168, 78);
            this.lblAddProdDiscount.TabIndex = 41;
            this.lblAddProdDiscount.Text = "Discount  Percentage:";
            this.lblAddProdDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAddProdRetPrice
            // 
            this.txtAddProdRetPrice.Location = new System.Drawing.Point(401, 258);
            this.txtAddProdRetPrice.Name = "txtAddProdRetPrice";
            this.txtAddProdRetPrice.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdRetPrice.TabIndex = 12;
            // 
            // lblAddProdRetPrice
            // 
            this.lblAddProdRetPrice.AutoSize = true;
            this.lblAddProdRetPrice.Location = new System.Drawing.Point(234, 261);
            this.lblAddProdRetPrice.Name = "lblAddProdRetPrice";
            this.lblAddProdRetPrice.Size = new System.Drawing.Size(161, 31);
            this.lblAddProdRetPrice.TabIndex = 11;
            this.lblAddProdRetPrice.Text = "Retail Price:";
            // 
            // txtAddProdSupplier
            // 
            this.txtAddProdSupplier.Location = new System.Drawing.Point(401, 312);
            this.txtAddProdSupplier.Name = "txtAddProdSupplier";
            this.txtAddProdSupplier.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdSupplier.TabIndex = 10;
            // 
            // txtAddProdPrice
            // 
            this.txtAddProdPrice.Location = new System.Drawing.Point(401, 204);
            this.txtAddProdPrice.Name = "txtAddProdPrice";
            this.txtAddProdPrice.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdPrice.TabIndex = 9;
            // 
            // txtAddProdQuantity
            // 
            this.txtAddProdQuantity.Location = new System.Drawing.Point(401, 150);
            this.txtAddProdQuantity.Name = "txtAddProdQuantity";
            this.txtAddProdQuantity.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdQuantity.TabIndex = 8;
            // 
            // txtAddProdName
            // 
            this.txtAddProdName.Location = new System.Drawing.Point(401, 97);
            this.txtAddProdName.Name = "txtAddProdName";
            this.txtAddProdName.Size = new System.Drawing.Size(618, 38);
            this.txtAddProdName.TabIndex = 7;
            // 
            // btnAddProdClearInput
            // 
            this.btnAddProdClearInput.Location = new System.Drawing.Point(753, 517);
            this.btnAddProdClearInput.Name = "btnAddProdClearInput";
            this.btnAddProdClearInput.Size = new System.Drawing.Size(191, 60);
            this.btnAddProdClearInput.TabIndex = 6;
            this.btnAddProdClearInput.Text = "Clear Input";
            this.btnAddProdClearInput.UseVisualStyleBackColor = true;
            this.btnAddProdClearInput.Click += new System.EventHandler(this.btnAddProdClearInput_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(451, 517);
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
            this.lblAddProdSupplier.Location = new System.Drawing.Point(274, 315);
            this.lblAddProdSupplier.Name = "lblAddProdSupplier";
            this.lblAddProdSupplier.Size = new System.Drawing.Size(121, 31);
            this.lblAddProdSupplier.TabIndex = 4;
            this.lblAddProdSupplier.Text = "Supplier:";
            // 
            // lblAddProdPrice
            // 
            this.lblAddProdPrice.AutoSize = true;
            this.lblAddProdPrice.Location = new System.Drawing.Point(311, 207);
            this.lblAddProdPrice.Name = "lblAddProdPrice";
            this.lblAddProdPrice.Size = new System.Drawing.Size(84, 31);
            this.lblAddProdPrice.TabIndex = 3;
            this.lblAddProdPrice.Text = "Price:";
            // 
            // lblAddProdQuantity
            // 
            this.lblAddProdQuantity.AutoSize = true;
            this.lblAddProdQuantity.Location = new System.Drawing.Point(271, 153);
            this.lblAddProdQuantity.Name = "lblAddProdQuantity";
            this.lblAddProdQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblAddProdQuantity.TabIndex = 2;
            this.lblAddProdQuantity.Text = "Quantity:";
            // 
            // lblAddProdName
            // 
            this.lblAddProdName.AutoSize = true;
            this.lblAddProdName.Location = new System.Drawing.Point(200, 100);
            this.lblAddProdName.Name = "lblAddProdName";
            this.lblAddProdName.Size = new System.Drawing.Size(195, 31);
            this.lblAddProdName.TabIndex = 1;
            this.lblAddProdName.Text = "Product Name:";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(527, 3);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(367, 63);
            this.lblAddProduct.TabIndex = 0;
            this.lblAddProduct.Text = "Add a Product";
            // 
            // tabEditProduct
            // 
            this.tabEditProduct.Controls.Add(this.grpEditProdNew);
            this.tabEditProduct.Controls.Add(this.grpEditProdOld);
            this.tabEditProduct.Controls.Add(this.btnEditProdClearInput);
            this.tabEditProduct.Controls.Add(this.btnEditProdConfirmChanges);
            this.tabEditProduct.Controls.Add(this.label5);
            this.tabEditProduct.Location = new System.Drawing.Point(4, 40);
            this.tabEditProduct.Name = "tabEditProduct";
            this.tabEditProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditProduct.Size = new System.Drawing.Size(1283, 625);
            this.tabEditProduct.TabIndex = 1;
            this.tabEditProduct.Text = "Edit Product";
            this.tabEditProduct.UseVisualStyleBackColor = true;
            // 
            // grpEditProdNew
            // 
            this.grpEditProdNew.Controls.Add(this.txtEditProdDiscount);
            this.grpEditProdNew.Controls.Add(this.lblEditProdDiscount);
            this.grpEditProdNew.Controls.Add(this.txtEditProdRetPrice);
            this.grpEditProdNew.Controls.Add(this.lblEditProdRetPrice);
            this.grpEditProdNew.Controls.Add(this.cmbEditProdSelect);
            this.grpEditProdNew.Controls.Add(this.lblEditProdName);
            this.grpEditProdNew.Controls.Add(this.lblEditProdQuantity);
            this.grpEditProdNew.Controls.Add(this.lblEditProdFind);
            this.grpEditProdNew.Controls.Add(this.lblEditProdPrice);
            this.grpEditProdNew.Controls.Add(this.txtEditProdSupplier);
            this.grpEditProdNew.Controls.Add(this.lblEditProdSupplier);
            this.grpEditProdNew.Controls.Add(this.txtEditProdPrice);
            this.grpEditProdNew.Controls.Add(this.txtEditProdName);
            this.grpEditProdNew.Controls.Add(this.txtEditProdQuantity);
            this.grpEditProdNew.Location = new System.Drawing.Point(6, 84);
            this.grpEditProdNew.Name = "grpEditProdNew";
            this.grpEditProdNew.Size = new System.Drawing.Size(643, 455);
            this.grpEditProdNew.TabIndex = 38;
            this.grpEditProdNew.TabStop = false;
            this.grpEditProdNew.Text = "New Details";
            // 
            // txtEditProdDiscount
            // 
            this.txtEditProdDiscount.Location = new System.Drawing.Point(234, 349);
            this.txtEditProdDiscount.Name = "txtEditProdDiscount";
            this.txtEditProdDiscount.Size = new System.Drawing.Size(365, 38);
            this.txtEditProdDiscount.TabIndex = 40;
            // 
            // lblEditProdDiscount
            // 
            this.lblEditProdDiscount.Location = new System.Drawing.Point(60, 339);
            this.lblEditProdDiscount.Name = "lblEditProdDiscount";
            this.lblEditProdDiscount.Size = new System.Drawing.Size(168, 78);
            this.lblEditProdDiscount.TabIndex = 39;
            this.lblEditProdDiscount.Text = "Discount  Percentage:";
            this.lblEditProdDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEditProdRetPrice
            // 
            this.txtEditProdRetPrice.Location = new System.Drawing.Point(234, 248);
            this.txtEditProdRetPrice.Name = "txtEditProdRetPrice";
            this.txtEditProdRetPrice.Size = new System.Drawing.Size(365, 38);
            this.txtEditProdRetPrice.TabIndex = 38;
            // 
            // lblEditProdRetPrice
            // 
            this.lblEditProdRetPrice.AutoSize = true;
            this.lblEditProdRetPrice.Location = new System.Drawing.Point(67, 251);
            this.lblEditProdRetPrice.Name = "lblEditProdRetPrice";
            this.lblEditProdRetPrice.Size = new System.Drawing.Size(161, 31);
            this.lblEditProdRetPrice.TabIndex = 37;
            this.lblEditProdRetPrice.Text = "Retail Price:";
            // 
            // cmbEditProdSelect
            // 
            this.cmbEditProdSelect.DisplayMember = "Key";
            this.cmbEditProdSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditProdSelect.FormattingEnabled = true;
            this.cmbEditProdSelect.Location = new System.Drawing.Point(234, 31);
            this.cmbEditProdSelect.Name = "cmbEditProdSelect";
            this.cmbEditProdSelect.Size = new System.Drawing.Size(365, 39);
            this.cmbEditProdSelect.TabIndex = 36;
            this.cmbEditProdSelect.ValueMember = "Key";
            this.cmbEditProdSelect.SelectedIndexChanged += new System.EventHandler(this.cmbEditProdSelect_SelectedIndexChanged);
            // 
            // lblEditProdName
            // 
            this.lblEditProdName.AutoSize = true;
            this.lblEditProdName.Location = new System.Drawing.Point(33, 92);
            this.lblEditProdName.Name = "lblEditProdName";
            this.lblEditProdName.Size = new System.Drawing.Size(195, 31);
            this.lblEditProdName.TabIndex = 25;
            this.lblEditProdName.Text = "Product Name:";
            // 
            // lblEditProdQuantity
            // 
            this.lblEditProdQuantity.AutoSize = true;
            this.lblEditProdQuantity.Location = new System.Drawing.Point(104, 147);
            this.lblEditProdQuantity.Name = "lblEditProdQuantity";
            this.lblEditProdQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblEditProdQuantity.TabIndex = 26;
            this.lblEditProdQuantity.Text = "Quantity:";
            // 
            // lblEditProdFind
            // 
            this.lblEditProdFind.AutoSize = true;
            this.lblEditProdFind.Location = new System.Drawing.Point(29, 34);
            this.lblEditProdFind.Name = "lblEditProdFind";
            this.lblEditProdFind.Size = new System.Drawing.Size(199, 31);
            this.lblEditProdFind.TabIndex = 35;
            this.lblEditProdFind.Text = "Select Product:";
            // 
            // lblEditProdPrice
            // 
            this.lblEditProdPrice.AutoSize = true;
            this.lblEditProdPrice.Location = new System.Drawing.Point(144, 201);
            this.lblEditProdPrice.Name = "lblEditProdPrice";
            this.lblEditProdPrice.Size = new System.Drawing.Size(84, 31);
            this.lblEditProdPrice.TabIndex = 27;
            this.lblEditProdPrice.Text = "Price:";
            // 
            // txtEditProdSupplier
            // 
            this.txtEditProdSupplier.Location = new System.Drawing.Point(234, 296);
            this.txtEditProdSupplier.Name = "txtEditProdSupplier";
            this.txtEditProdSupplier.Size = new System.Drawing.Size(365, 38);
            this.txtEditProdSupplier.TabIndex = 34;
            // 
            // lblEditProdSupplier
            // 
            this.lblEditProdSupplier.AutoSize = true;
            this.lblEditProdSupplier.Location = new System.Drawing.Point(107, 299);
            this.lblEditProdSupplier.Name = "lblEditProdSupplier";
            this.lblEditProdSupplier.Size = new System.Drawing.Size(121, 31);
            this.lblEditProdSupplier.TabIndex = 28;
            this.lblEditProdSupplier.Text = "Supplier:";
            // 
            // txtEditProdPrice
            // 
            this.txtEditProdPrice.Location = new System.Drawing.Point(234, 198);
            this.txtEditProdPrice.Name = "txtEditProdPrice";
            this.txtEditProdPrice.Size = new System.Drawing.Size(365, 38);
            this.txtEditProdPrice.TabIndex = 33;
            // 
            // txtEditProdName
            // 
            this.txtEditProdName.Location = new System.Drawing.Point(234, 89);
            this.txtEditProdName.Name = "txtEditProdName";
            this.txtEditProdName.Size = new System.Drawing.Size(365, 38);
            this.txtEditProdName.TabIndex = 31;
            // 
            // txtEditProdQuantity
            // 
            this.txtEditProdQuantity.Location = new System.Drawing.Point(234, 144);
            this.txtEditProdQuantity.Name = "txtEditProdQuantity";
            this.txtEditProdQuantity.Size = new System.Drawing.Size(365, 38);
            this.txtEditProdQuantity.TabIndex = 32;
            // 
            // grpEditProdOld
            // 
            this.grpEditProdOld.Controls.Add(this.txtEditProdOldDiscount);
            this.grpEditProdOld.Controls.Add(this.txtEditProdOldSupplier);
            this.grpEditProdOld.Controls.Add(this.txtEditProdOldRetPrice);
            this.grpEditProdOld.Controls.Add(this.txtEditProdOldPrice);
            this.grpEditProdOld.Controls.Add(this.txtEditProdOldQuantity);
            this.grpEditProdOld.Controls.Add(this.txtEditProdOldName);
            this.grpEditProdOld.Controls.Add(this.lblEditProdOldRetPrice);
            this.grpEditProdOld.Controls.Add(this.lblEditProdOldDiscount);
            this.grpEditProdOld.Controls.Add(this.lblEditProdOldName);
            this.grpEditProdOld.Controls.Add(this.lblEditProdOldQuantity);
            this.grpEditProdOld.Controls.Add(this.lblEditProdOldSupplier);
            this.grpEditProdOld.Controls.Add(this.lblEditProdOldPrice);
            this.grpEditProdOld.Location = new System.Drawing.Point(709, 84);
            this.grpEditProdOld.Name = "grpEditProdOld";
            this.grpEditProdOld.Size = new System.Drawing.Size(571, 455);
            this.grpEditProdOld.TabIndex = 37;
            this.grpEditProdOld.TabStop = false;
            this.grpEditProdOld.Text = "Old Details";
            // 
            // txtEditProdOldDiscount
            // 
            this.txtEditProdOldDiscount.Location = new System.Drawing.Point(318, 349);
            this.txtEditProdOldDiscount.Name = "txtEditProdOldDiscount";
            this.txtEditProdOldDiscount.ReadOnly = true;
            this.txtEditProdOldDiscount.Size = new System.Drawing.Size(189, 38);
            this.txtEditProdOldDiscount.TabIndex = 42;
            // 
            // txtEditProdOldSupplier
            // 
            this.txtEditProdOldSupplier.Location = new System.Drawing.Point(318, 293);
            this.txtEditProdOldSupplier.Name = "txtEditProdOldSupplier";
            this.txtEditProdOldSupplier.ReadOnly = true;
            this.txtEditProdOldSupplier.Size = new System.Drawing.Size(189, 38);
            this.txtEditProdOldSupplier.TabIndex = 42;
            // 
            // txtEditProdOldRetPrice
            // 
            this.txtEditProdOldRetPrice.Location = new System.Drawing.Point(318, 232);
            this.txtEditProdOldRetPrice.Name = "txtEditProdOldRetPrice";
            this.txtEditProdOldRetPrice.ReadOnly = true;
            this.txtEditProdOldRetPrice.Size = new System.Drawing.Size(189, 38);
            this.txtEditProdOldRetPrice.TabIndex = 42;
            // 
            // txtEditProdOldPrice
            // 
            this.txtEditProdOldPrice.Location = new System.Drawing.Point(318, 170);
            this.txtEditProdOldPrice.Name = "txtEditProdOldPrice";
            this.txtEditProdOldPrice.ReadOnly = true;
            this.txtEditProdOldPrice.Size = new System.Drawing.Size(189, 38);
            this.txtEditProdOldPrice.TabIndex = 42;
            // 
            // txtEditProdOldQuantity
            // 
            this.txtEditProdOldQuantity.Location = new System.Drawing.Point(318, 118);
            this.txtEditProdOldQuantity.Name = "txtEditProdOldQuantity";
            this.txtEditProdOldQuantity.ReadOnly = true;
            this.txtEditProdOldQuantity.Size = new System.Drawing.Size(189, 38);
            this.txtEditProdOldQuantity.TabIndex = 42;
            // 
            // txtEditProdOldName
            // 
            this.txtEditProdOldName.Location = new System.Drawing.Point(318, 63);
            this.txtEditProdOldName.Name = "txtEditProdOldName";
            this.txtEditProdOldName.ReadOnly = true;
            this.txtEditProdOldName.Size = new System.Drawing.Size(189, 38);
            this.txtEditProdOldName.TabIndex = 42;
            // 
            // lblEditProdOldRetPrice
            // 
            this.lblEditProdOldRetPrice.AutoSize = true;
            this.lblEditProdOldRetPrice.Location = new System.Drawing.Point(135, 235);
            this.lblEditProdOldRetPrice.Name = "lblEditProdOldRetPrice";
            this.lblEditProdOldRetPrice.Size = new System.Drawing.Size(161, 31);
            this.lblEditProdOldRetPrice.TabIndex = 41;
            this.lblEditProdOldRetPrice.Text = "Retail Price:";
            // 
            // lblEditProdOldDiscount
            // 
            this.lblEditProdOldDiscount.AutoSize = true;
            this.lblEditProdOldDiscount.Location = new System.Drawing.Point(14, 352);
            this.lblEditProdOldDiscount.Name = "lblEditProdOldDiscount";
            this.lblEditProdOldDiscount.Size = new System.Drawing.Size(282, 31);
            this.lblEditProdOldDiscount.TabIndex = 41;
            this.lblEditProdOldDiscount.Text = "Discount  Percentage:";
            this.lblEditProdOldDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEditProdOldName
            // 
            this.lblEditProdOldName.AutoSize = true;
            this.lblEditProdOldName.Location = new System.Drawing.Point(101, 66);
            this.lblEditProdOldName.Name = "lblEditProdOldName";
            this.lblEditProdOldName.Size = new System.Drawing.Size(195, 31);
            this.lblEditProdOldName.TabIndex = 37;
            this.lblEditProdOldName.Text = "Product Name:";
            // 
            // lblEditProdOldQuantity
            // 
            this.lblEditProdOldQuantity.AutoSize = true;
            this.lblEditProdOldQuantity.Location = new System.Drawing.Point(172, 121);
            this.lblEditProdOldQuantity.Name = "lblEditProdOldQuantity";
            this.lblEditProdOldQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblEditProdOldQuantity.TabIndex = 38;
            this.lblEditProdOldQuantity.Text = "Quantity:";
            // 
            // lblEditProdOldSupplier
            // 
            this.lblEditProdOldSupplier.AutoSize = true;
            this.lblEditProdOldSupplier.Location = new System.Drawing.Point(175, 296);
            this.lblEditProdOldSupplier.Name = "lblEditProdOldSupplier";
            this.lblEditProdOldSupplier.Size = new System.Drawing.Size(121, 31);
            this.lblEditProdOldSupplier.TabIndex = 40;
            this.lblEditProdOldSupplier.Text = "Supplier:";
            // 
            // lblEditProdOldPrice
            // 
            this.lblEditProdOldPrice.AutoSize = true;
            this.lblEditProdOldPrice.Location = new System.Drawing.Point(212, 173);
            this.lblEditProdOldPrice.Name = "lblEditProdOldPrice";
            this.lblEditProdOldPrice.Size = new System.Drawing.Size(84, 31);
            this.lblEditProdOldPrice.TabIndex = 39;
            this.lblEditProdOldPrice.Text = "Price:";
            // 
            // btnEditProdClearInput
            // 
            this.btnEditProdClearInput.Location = new System.Drawing.Point(771, 545);
            this.btnEditProdClearInput.Name = "btnEditProdClearInput";
            this.btnEditProdClearInput.Size = new System.Drawing.Size(191, 74);
            this.btnEditProdClearInput.TabIndex = 30;
            this.btnEditProdClearInput.Text = "Clear Input";
            this.btnEditProdClearInput.UseVisualStyleBackColor = true;
            this.btnEditProdClearInput.Click += new System.EventHandler(this.btnEditProdClearInput_Click);
            // 
            // btnEditProdConfirmChanges
            // 
            this.btnEditProdConfirmChanges.Location = new System.Drawing.Point(466, 545);
            this.btnEditProdConfirmChanges.Name = "btnEditProdConfirmChanges";
            this.btnEditProdConfirmChanges.Size = new System.Drawing.Size(191, 74);
            this.btnEditProdConfirmChanges.TabIndex = 29;
            this.btnEditProdConfirmChanges.Text = "Confirm Changes";
            this.btnEditProdConfirmChanges.UseVisualStyleBackColor = true;
            this.btnEditProdConfirmChanges.Click += new System.EventHandler(this.btnEditProdConfirmChanges_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 63);
            this.label5.TabIndex = 24;
            this.label5.Text = "Edit a Product";
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.txtSalesNotes);
            this.tabSales.Controls.Add(this.lblSalesNotes);
            this.tabSales.Controls.Add(this.btnSalesClear);
            this.tabSales.Controls.Add(this.lblSalesDate);
            this.tabSales.Controls.Add(this.dtpSalesDatae);
            this.tabSales.Controls.Add(this.btnSalesConfirm);
            this.tabSales.Controls.Add(this.btnSalesAddProduct);
            this.tabSales.Controls.Add(this.txtSalesQuantity);
            this.tabSales.Controls.Add(this.lblSalesQuantity);
            this.tabSales.Controls.Add(this.dgvAddSales);
            this.tabSales.Controls.Add(this.lblSalesReport);
            this.tabSales.Controls.Add(this.cmbSalesSelect);
            this.tabSales.Controls.Add(this.lblSalesSelect);
            this.tabSales.Location = new System.Drawing.Point(4, 40);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(1309, 679);
            this.tabSales.TabIndex = 1;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // txtSalesNotes
            // 
            this.txtSalesNotes.Location = new System.Drawing.Point(414, 217);
            this.txtSalesNotes.Name = "txtSalesNotes";
            this.txtSalesNotes.Size = new System.Drawing.Size(730, 38);
            this.txtSalesNotes.TabIndex = 60;
            // 
            // lblSalesNotes
            // 
            this.lblSalesNotes.AutoSize = true;
            this.lblSalesNotes.Location = new System.Drawing.Point(313, 220);
            this.lblSalesNotes.Name = "lblSalesNotes";
            this.lblSalesNotes.Size = new System.Drawing.Size(94, 31);
            this.lblSalesNotes.TabIndex = 59;
            this.lblSalesNotes.Text = "Notes:";
            // 
            // btnSalesClear
            // 
            this.btnSalesClear.Location = new System.Drawing.Point(1099, 561);
            this.btnSalesClear.Name = "btnSalesClear";
            this.btnSalesClear.Size = new System.Drawing.Size(192, 73);
            this.btnSalesClear.TabIndex = 58;
            this.btnSalesClear.Text = "Clear Input";
            this.btnSalesClear.UseVisualStyleBackColor = true;
            this.btnSalesClear.Click += new System.EventHandler(this.btnAddSalesClear_Click_1);
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Location = new System.Drawing.Point(327, 179);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(80, 31);
            this.lblSalesDate.TabIndex = 57;
            this.lblSalesDate.Text = "Date:";
            // 
            // dtpSalesDatae
            // 
            this.dtpSalesDatae.Location = new System.Drawing.Point(413, 173);
            this.dtpSalesDatae.Name = "dtpSalesDatae";
            this.dtpSalesDatae.Size = new System.Drawing.Size(730, 38);
            this.dtpSalesDatae.TabIndex = 56;
            // 
            // btnSalesConfirm
            // 
            this.btnSalesConfirm.Location = new System.Drawing.Point(1099, 464);
            this.btnSalesConfirm.Name = "btnSalesConfirm";
            this.btnSalesConfirm.Size = new System.Drawing.Size(192, 73);
            this.btnSalesConfirm.TabIndex = 55;
            this.btnSalesConfirm.Text = "Confirm Sale";
            this.btnSalesConfirm.UseVisualStyleBackColor = true;
            // 
            // btnSalesAddProduct
            // 
            this.btnSalesAddProduct.Location = new System.Drawing.Point(1099, 370);
            this.btnSalesAddProduct.Name = "btnSalesAddProduct";
            this.btnSalesAddProduct.Size = new System.Drawing.Size(192, 73);
            this.btnSalesAddProduct.TabIndex = 54;
            this.btnSalesAddProduct.Text = "Add Product";
            this.btnSalesAddProduct.UseVisualStyleBackColor = true;
            this.btnSalesAddProduct.Click += new System.EventHandler(this.btnSalesAddProduct_Click);
            // 
            // txtSalesQuantity
            // 
            this.txtSalesQuantity.Location = new System.Drawing.Point(413, 129);
            this.txtSalesQuantity.Name = "txtSalesQuantity";
            this.txtSalesQuantity.Size = new System.Drawing.Size(730, 38);
            this.txtSalesQuantity.TabIndex = 53;
            // 
            // lblSalesQuantity
            // 
            this.lblSalesQuantity.AutoSize = true;
            this.lblSalesQuantity.Location = new System.Drawing.Point(283, 132);
            this.lblSalesQuantity.Name = "lblSalesQuantity";
            this.lblSalesQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblSalesQuantity.TabIndex = 52;
            this.lblSalesQuantity.Text = "Quantity:";
            // 
            // dgvAddSales
            // 
            this.dgvAddSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colAddSalesName,
            this.colAddSalesQuantity,
            this.colAddSalesItemPrice,
            this.colAddSalesTotal,
            this.colNotes});
            this.dgvAddSales.Location = new System.Drawing.Point(17, 307);
            this.dgvAddSales.Name = "dgvAddSales";
            this.dgvAddSales.RowTemplate.Height = 24;
            this.dgvAddSales.Size = new System.Drawing.Size(1076, 334);
            this.dgvAddSales.TabIndex = 51;
            // 
            // colKey
            // 
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
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
            // colNotes
            // 
            this.colNotes.HeaderText = "Notes";
            this.colNotes.Name = "colNotes";
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(551, 3);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(317, 63);
            this.lblSalesReport.TabIndex = 50;
            this.lblSalesReport.Text = "Add a Sales";
            // 
            // cmbSalesSelect
            // 
            this.cmbSalesSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesSelect.FormattingEnabled = true;
            this.cmbSalesSelect.Location = new System.Drawing.Point(413, 84);
            this.cmbSalesSelect.Name = "cmbSalesSelect";
            this.cmbSalesSelect.Size = new System.Drawing.Size(731, 39);
            this.cmbSalesSelect.TabIndex = 49;
            this.cmbSalesSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSalesSelect_SelectedIndexChanged);
            // 
            // lblSalesSelect
            // 
            this.lblSalesSelect.AutoSize = true;
            this.lblSalesSelect.Location = new System.Drawing.Point(208, 87);
            this.lblSalesSelect.Name = "lblSalesSelect";
            this.lblSalesSelect.Size = new System.Drawing.Size(199, 31);
            this.lblSalesSelect.TabIndex = 48;
            this.lblSalesSelect.Text = "Select Product:";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabReportOptions);
            this.tabReports.Location = new System.Drawing.Point(4, 40);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1309, 679);
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
            this.tabMonthlyReport.Controls.Add(this.dgcRepMonthlySales);
            this.tabMonthlyReport.Controls.Add(this.cmbRepMonthlySelect);
            this.tabMonthlyReport.Controls.Add(this.lblRepMonthlySelect);
            this.tabMonthlyReport.Controls.Add(this.lblRepMonthlyTitle);
            this.tabMonthlyReport.Location = new System.Drawing.Point(4, 40);
            this.tabMonthlyReport.Name = "tabMonthlyReport";
            this.tabMonthlyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthlyReport.Size = new System.Drawing.Size(1288, 629);
            this.tabMonthlyReport.TabIndex = 0;
            this.tabMonthlyReport.Text = "Monthly Report";
            this.tabMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // dgcRepMonthlySales
            // 
            this.dgcRepMonthlySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcRepMonthlySales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdName,
            this.colQuantity,
            this.colSalePrice});
            this.dgcRepMonthlySales.Location = new System.Drawing.Point(324, 165);
            this.dgcRepMonthlySales.Name = "dgcRepMonthlySales";
            this.dgcRepMonthlySales.RowTemplate.Height = 24;
            this.dgcRepMonthlySales.Size = new System.Drawing.Size(716, 461);
            this.dgcRepMonthlySales.TabIndex = 41;
            // 
            // colProdName
            // 
            this.colProdName.HeaderText = "Product Name";
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            this.colProdName.Width = 250;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 125;
            // 
            // colSalePrice
            // 
            this.colSalePrice.HeaderText = "Sale Price $";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            this.colSalePrice.Width = 125;
            // 
            // cmbRepMonthlySelect
            // 
            this.cmbRepMonthlySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepMonthlySelect.FormattingEnabled = true;
            this.cmbRepMonthlySelect.Location = new System.Drawing.Point(372, 95);
            this.cmbRepMonthlySelect.Name = "cmbRepMonthlySelect";
            this.cmbRepMonthlySelect.Size = new System.Drawing.Size(654, 39);
            this.cmbRepMonthlySelect.TabIndex = 40;
            // 
            // lblRepMonthlySelect
            // 
            this.lblRepMonthlySelect.AutoSize = true;
            this.lblRepMonthlySelect.Location = new System.Drawing.Point(203, 98);
            this.lblRepMonthlySelect.Name = "lblRepMonthlySelect";
            this.lblRepMonthlySelect.Size = new System.Drawing.Size(163, 31);
            this.lblRepMonthlySelect.TabIndex = 39;
            this.lblRepMonthlySelect.Text = "Select Date:";
            // 
            // lblRepMonthlyTitle
            // 
            this.lblRepMonthlyTitle.AutoSize = true;
            this.lblRepMonthlyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMonthlyTitle.Location = new System.Drawing.Point(512, 3);
            this.lblRepMonthlyTitle.Name = "lblRepMonthlyTitle";
            this.lblRepMonthlyTitle.Size = new System.Drawing.Size(393, 63);
            this.lblRepMonthlyTitle.TabIndex = 25;
            this.lblRepMonthlyTitle.Text = "Monthly Report";
            // 
            // tabYearlyReport
            // 
            this.tabYearlyReport.Controls.Add(this.dataGridView1);
            this.tabYearlyReport.Controls.Add(this.cmbRepYearlySelect);
            this.tabYearlyReport.Controls.Add(this.lblRepYearlySelect);
            this.tabYearlyReport.Controls.Add(this.lblYearlyReportTitle);
            this.tabYearlyReport.Location = new System.Drawing.Point(4, 40);
            this.tabYearlyReport.Name = "tabYearlyReport";
            this.tabYearlyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabYearlyReport.Size = new System.Drawing.Size(1288, 629);
            this.tabYearlyReport.TabIndex = 1;
            this.tabYearlyReport.Text = "Yearly Report";
            this.tabYearlyReport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(329, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 461);
            this.dataGridView1.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Sale Price $";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // cmbRepYearlySelect
            // 
            this.cmbRepYearlySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepYearlySelect.FormattingEnabled = true;
            this.cmbRepYearlySelect.Location = new System.Drawing.Point(372, 98);
            this.cmbRepYearlySelect.Name = "cmbRepYearlySelect";
            this.cmbRepYearlySelect.Size = new System.Drawing.Size(654, 39);
            this.cmbRepYearlySelect.TabIndex = 40;
            // 
            // lblRepYearlySelect
            // 
            this.lblRepYearlySelect.AutoSize = true;
            this.lblRepYearlySelect.Location = new System.Drawing.Point(203, 101);
            this.lblRepYearlySelect.Name = "lblRepYearlySelect";
            this.lblRepYearlySelect.Size = new System.Drawing.Size(163, 31);
            this.lblRepYearlySelect.TabIndex = 39;
            this.lblRepYearlySelect.Text = "Select Date:";
            // 
            // lblYearlyReportTitle
            // 
            this.lblYearlyReportTitle.AutoSize = true;
            this.lblYearlyReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyReportTitle.Location = new System.Drawing.Point(512, 3);
            this.lblYearlyReportTitle.Name = "lblYearlyReportTitle";
            this.lblYearlyReportTitle.Size = new System.Drawing.Size(357, 63);
            this.lblYearlyReportTitle.TabIndex = 26;
            this.lblYearlyReportTitle.Text = "Yearly Report";
            // 
            // frmPeopleHealthPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 739);
            this.Controls.Add(this.tabMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPeopleHealthPharmacy";
            this.Text = "People Health Pharmacy Inc.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPeopleHealthPharmacy_FormClosing);
            this.Load += new System.EventHandler(this.frmPeopleHealthPharmacy_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.gpbHomeGoTo.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProductOptions.ResumeLayout(false);
            this.tabAddProduct.ResumeLayout(false);
            this.tabAddProduct.PerformLayout();
            this.tabEditProduct.ResumeLayout(false);
            this.tabEditProduct.PerformLayout();
            this.grpEditProdNew.ResumeLayout(false);
            this.grpEditProdNew.PerformLayout();
            this.grpEditProdOld.ResumeLayout(false);
            this.grpEditProdOld.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSales)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReportOptions.ResumeLayout(false);
            this.tabMonthlyReport.ResumeLayout(false);
            this.tabMonthlyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcRepMonthlySales)).EndInit();
            this.tabYearlyReport.ResumeLayout(false);
            this.tabYearlyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txtAddProdRetPrice;
        private System.Windows.Forms.Label lblAddProdRetPrice;
        private System.Windows.Forms.GroupBox grpEditProdNew;
        private System.Windows.Forms.GroupBox grpEditProdOld;
        private System.Windows.Forms.Label lblEditProdOldName;
        private System.Windows.Forms.Label lblEditProdOldQuantity;
        private System.Windows.Forms.Label lblEditProdOldSupplier;
        private System.Windows.Forms.Label lblEditProdOldPrice;
        private System.Windows.Forms.TextBox txtEditProdRetPrice;
        private System.Windows.Forms.Label lblEditProdRetPrice;
        private System.Windows.Forms.Label lblEditProdOldRetPrice;
        private System.Windows.Forms.TextBox txtEditProdDiscount;
        private System.Windows.Forms.Label lblEditProdDiscount;
        private System.Windows.Forms.Label lblEditProdOldDiscount;
        private System.Windows.Forms.TextBox txtAddProdDiscount;
        private System.Windows.Forms.Label lblAddProdDiscount;
        private System.Windows.Forms.TextBox txtAddProdKey;
        private System.Windows.Forms.Label lblAddProdKey;
        private System.Windows.Forms.Label lblRepMonthlyTitle;
        private System.Windows.Forms.Label lblYearlyReportTitle;
        private System.Windows.Forms.TextBox txtEditProdOldDiscount;
        private System.Windows.Forms.TextBox txtEditProdOldSupplier;
        private System.Windows.Forms.TextBox txtEditProdOldRetPrice;
        private System.Windows.Forms.TextBox txtEditProdOldPrice;
        private System.Windows.Forms.TextBox txtEditProdOldQuantity;
        private System.Windows.Forms.TextBox txtEditProdOldName;
        private System.Windows.Forms.Button btnSalesClear;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.DateTimePicker dtpSalesDatae;
        private System.Windows.Forms.Button btnSalesConfirm;
        private System.Windows.Forms.Button btnSalesAddProduct;
        private System.Windows.Forms.TextBox txtSalesQuantity;
        private System.Windows.Forms.Label lblSalesQuantity;
        private System.Windows.Forms.DataGridView dgvAddSales;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.ComboBox cmbSalesSelect;
        private System.Windows.Forms.Label lblSalesSelect;
        private System.Windows.Forms.ComboBox cmbRepYearlySelect;
        private System.Windows.Forms.Label lblRepYearlySelect;
        private System.Windows.Forms.TextBox txtSalesNotes;
        private System.Windows.Forms.Label lblSalesNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddSalesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddSalesQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddSalesItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddSalesTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridView dgcRepMonthlySales;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.GroupBox gpbHomeGoTo;
        private System.Windows.Forms.Button btnHomeReports;
        private System.Windows.Forms.Button btnHomeSales;
        private System.Windows.Forms.Button btnHomeProducts;
        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.ComboBox cmbRepMonthlySelect;
        private System.Windows.Forms.Label lblRepMonthlySelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

