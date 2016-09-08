using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamAmcal
{
    public partial class frmPeopleHealthPharmacy : Form
    {
        DatabaseManager fDataManager;
        BindingList<Product> fProducts;

        public frmPeopleHealthPharmacy()
        {
            InitializeComponent();
        } // end default constructor

        private void frmPeopleHealthPharmacy_Load(object sender, EventArgs e)
        {
            fDataManager = new DatabaseManager();

            fDataManager.LoadProducts();

            fProducts = new BindingList<Product>(fDataManager.ProductList);

            cmbEditProdSelect.DataSource = fDataManager.ProductList;
            cmbEditProdSelect.DisplayMember = "Name";
            cmbEditProdSelect.ValueMember = "Key";

            cmbAddSalesSelect.DataSource = fProducts;
            cmbAddSalesSelect.DisplayMember = "Name";
            cmbAddSalesSelect.ValueMember = "Key";
        } // end frmPeopleHealthPharmacy_Load

        private void btnAddProdClearInput_Click(object sender, EventArgs e)
        {
            txtAddProdName.Text = "";
            txtAddProdPrice.Text = "";
            txtAddProdQuantity.Text = "";
            txtAddProdSupplier.Text = "";
            txtAddProdRetPrice.Text = "";
            txtAddProdDiscount.Text = "";
            txtAddProdKey.Text = "";

        } // end btnAddProdClearInput

        private void btnEditProdConfirmChanges_Click(object sender, EventArgs e)
        {
            // add code here
        } // end btnEditProdConfirmChanges_Click

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string lKey = txtAddProdKey.Text;
            string lName = txtAddProdName.Text;
            float lPrice = float.Parse(txtAddProdPrice.Text);
            float lRetPrice = float.Parse(txtAddProdRetPrice.Text);
            string lSupplier = txtAddProdSupplier.Text;
            float lDiscount = float.Parse(txtAddProdDiscount.Text);
            int lQuantity = int.Parse(txtAddProdQuantity.Text);

            fDataManager.CreateProduct(lKey, lName, lSupplier, lQuantity, lPrice, lRetPrice, lDiscount);

            cmbEditProdSelect.DataSource = fDataManager.ProductList;

            string lDisplay = "";

            lDisplay += "Product Name: " + txtAddProdName.Text + "\n";
            lDisplay += "Quantity: " + txtAddProdQuantity.Text + "\n";
            lDisplay += "Price: " + txtAddProdPrice.Text + "\n";
            lDisplay += "Retail Price: " + txtAddProdRetPrice.Text + "\n";
            lDisplay += "Supplier: " + txtAddProdSupplier.Text + "\n";
            lDisplay += "Discount: " + txtAddProdDiscount.Text + "\n";
            lDisplay += "Key: " + txtAddProdKey.Text + "\n";

            MessageBox.Show(lDisplay, "Product to Add:", MessageBoxButtons.OK);

        } // end btnAddProduct_Click

        private void btnEditProdConfirmChanges_Click_1(object sender, EventArgs e)
        {
            //ComboBox lCMB = (ComboBox)sender;
            int lIndex = cmbEditProdSelect.SelectedIndex;//  lCMB.SelectedIndex;
            Product lTempProd = fDataManager.getProduct(lIndex);

            if (lTempProd != null)
            {
                if (txtEditProdName.Text != "")
                    lTempProd.Name = txtEditProdName.Text;
                if (txtEditProdPrice.Text != "")
                    lTempProd.Price = float.Parse(txtEditProdPrice.Text);
                if (txtEditProdQuantity.Text != "")
                    lTempProd.Quantity = int.Parse(txtEditProdQuantity.Text);
                if (txtEditProdSupplier.Text != "")
                    lTempProd.Supplier = txtEditProdSupplier.Text;
                if (txtEditProdRetPrice.Text != "")
                    lTempProd.RRP = float.Parse(txtEditProdRetPrice.Text);
                if (txtEditProdDiscount.Text != "")
                    lTempProd.Discounted = float.Parse(txtEditProdDiscount.Text);
            }
            else
                throw new IndexOutOfRangeException("Error. No Product found");

            string lDisplay = "";

            if (txtEditProdName.Text != "")
                lDisplay += "Product Name: " + txtEditProdName.Text + "\n";
            if (txtEditProdPrice.Text != "")
                lDisplay += "Price: " + txtEditProdPrice.Text + "\n";
            if (txtEditProdQuantity.Text != "")
                lDisplay += "Quantity: " + txtEditProdQuantity.Text + "\n";
            if (txtEditProdSupplier.Text != "")
                lDisplay += "Supplier: " + txtEditProdSupplier.Text + "\n";
            if (txtEditProdRetPrice.Text != "")
                lDisplay += "Retail Price: " + txtEditProdRetPrice.Text + "\n";
            if (txtEditProdDiscount.Text != "")
                lDisplay += "Discount Percentage: " + txtEditProdDiscount.Text + "\n";

            MessageBox.Show(lDisplay, "Product to Edit:", MessageBoxButtons.OK);
        } // end btnEditProdConfirmChanges_Click_1

        private void btnEditProdClearInput_Click(object sender, EventArgs e)
        {
            txtEditProdName.Text = "";
            txtEditProdPrice.Text = "";
            txtEditProdQuantity.Text = "";
            txtEditProdSupplier.Text = "";
            txtEditProdRetPrice.Text = "";
            txtEditProdDiscount.Text = "";
        } // end btnEditProdClearInput_Click

        private void btnEditSalesConfirmUpdate_Click(object sender, EventArgs e)
        {
            
        } // end btnEditSalesConfirmUpdate_Click

        private void btnEditSalesRemoveProduct_Click(object sender, EventArgs e)
        {

        } // end btnEditSalesRemoveProduct_Click

        private void btnAddSalesAddProduct_Click(object sender, EventArgs e)
        {

        } // end btnAddSalesAddProduct_Click

        private void btnAddSalesConfirm_Click(object sender, EventArgs e)
        {

        } // end btnAddSalesConfirm_Click

        private void btnAddSalesClear_Click(object sender, EventArgs e)
        {
            dgvAddSalesReport.Columns.Clear();
        } // end btnAddSalesClear_Click

        // gets the current product in the Combo box and displays its data in the appropriate text boxes
        private void cmbEditProdSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox lCMB = (ComboBox)sender;
            int lIndex = cmbEditProdSelect.SelectedIndex; //lCMB.SelectedIndex;
            Product lTempProd = fDataManager.getProduct(lIndex);

            if (lTempProd != null)
            {
                txtEditProdOldName.Text = lTempProd.Name;
                txtEditProdOldQuantity.Text = lTempProd.Quantity.ToString();
                txtEditProdOldPrice.Text = lTempProd.Price.ToString();
                txtEditProdOldRetPrice.Text = lTempProd.RRP.ToString();
                txtEditProdOldSupplier.Text = lTempProd.Supplier;
                txtEditProdOldDiscount.Text = lTempProd.Discounted.ToString();
            }
            else
                throw new IndexOutOfRangeException("Error. No Product found");
        }
    } // end frmPeopleHealthPharmacy
} // end namespace