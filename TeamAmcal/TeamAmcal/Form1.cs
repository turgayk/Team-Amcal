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
        public frmPeopleHealthPharmacy()
        {
            InitializeComponent();
        } // end default constructor

        private void frmPeopleHealthPharmacy_Load(object sender, EventArgs e)
        {

        } // end frmPeopleHealthPharmacy_Load

        private void btnAddProdClearInput_Click(object sender, EventArgs e)
        {
            txtAddProdName.Text = "";
            txtAddProdPrice.Text = "";
            txtAddProdQuantity.Text = "";
            txtAddProdSupplier.Text = "";
        } // end btnAddProdClearInput

        private void btnEditProdConfirmChanges_Click(object sender, EventArgs e)
        {
            // add code here
        } // end btnEditProdConfirmChanges_Click

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string lDisplay = "";

            lDisplay += "Product Name: " + txtAddProdName.Text + "\n";
            lDisplay += "Quantity: " + txtAddProdQuantity.Text + "\n";
            lDisplay += "Price: " + txtAddProdPrice.Text + "\n";
            lDisplay += "Supplier: " + txtAddProdSupplier.Text + "\n";

            MessageBox.Show(lDisplay, "Product to Add:", MessageBoxButtons.OK);
            
        } // end btnAddProduct_Click

        private void btnEditProdConfirmChanges_Click_1(object sender, EventArgs e)
        {
            string lDisplay = "";

            if (txtEditProdName.Text != "")
                lDisplay += "Product Name: " + txtEditProdName.Text + "\n";
            if (txtEditProdPrice.Text != "")
                lDisplay += "Product Name: " + txtEditProdPrice.Text + "\n";
            if (txtEditProdQuantity.Text != "")
                lDisplay += "Product Name: " + txtEditProdQuantity.Text + "\n";
            if (txtEditProdSupplier.Text != "")
                lDisplay += "Product Name: " + txtEditProdSupplier.Text + "\n";

            MessageBox.Show(lDisplay, "Product to Edit:", MessageBoxButtons.OK);
        } // end btnEditProdConfirmChanges_Click_1

        private void btnEditProdClearInput_Click(object sender, EventArgs e)
        {
            txtEditProdName.Text = "";
            txtEditProdPrice.Text = "";
            txtEditProdQuantity.Text = "";
            txtEditProdSupplier.Text = "";
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
    } // end frmPeopleHealthPharmacy
} // end namespace