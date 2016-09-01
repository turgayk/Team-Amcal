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
        }

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

        } // end btnEditProdConfirmChanges_Click_1

        private void btnEditProdClearInput_Click(object sender, EventArgs e)
        {
            txtEditProdName.Text = "";
            txtEditProdPrice.Text = "";
            txtEditProdQuantity.Text = "";
            txtEditProdSupplier.Text = "";
        } // end btnEditProdClearInput_Click
    } // end frmPeopleHealthPharmacy
} // end namespace