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
        private SuperUltraMegaDatabaseManager dbmDataManager;
        private BindingList<Product> bdlProducts;

        public frmPeopleHealthPharmacy()
        {
            InitializeComponent();
        } // end default constructor

        private void frmPeopleHealthPharmacy_Load(object sender, EventArgs e)
        {
            dbmDataManager = new SuperUltraMegaDatabaseManager();

            dbmDataManager.ReadData();
            updateList();

            cmbEditProdSelect.DisplayMember = "Name";
            cmbEditProdSelect.ValueMember = "Key";

            cmbSaleSelect.DisplayMember = "Name";
            cmbSaleSelect.ValueMember = "Key";

            cmbPredSelect.DisplayMember = "Name";
            cmbPredSelect.ValueMember = "Key";
        } // end frmPeopleHealthPharmacy_Load

        private void updateList()
        {
            bdlProducts = new BindingList<Product>(dbmDataManager.ProductList);

            cmbEditProdSelect.DataSource = bdlProducts;
            cmbSaleSelect.DataSource = bdlProducts;
            cmbPredSelect.DataSource = bdlProducts;
        } // end updateList

        private void clearAddProdInput()
        {
            txtAddProdKey.Text = "";
            txtAddProdName.Text = "";
            txtAddProdSupplier.Text = "";
            txtAddProdQuantity.Text = "";
            txtAddProdBuyPrice.Text = "";
            txtAddProdSellPrice.Text = "";
            txtAddProdDiscount.Text = "";
        } // end clearAddProdInput

        private void clearEditProduct()
        {
            txtEditProdNewName.Text = "";
            txtEditProdNewSupplier.Text = "";
            txtEditProdNewQuantity.Text = "";
            txtEditProdNewBuy.Text = "";
            txtEditProdNewSell.Text = "";
            txtEditProdNewDiscount.Text = "";
        } // end clearEditProduct

        private void btnHomeProducts_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedIndex = 1;
        } // end btnHomeProducts_Click

        private void btnHomeSales_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedIndex = 2;
        } // end btnHomeSales_Click

        private void btnHomeReports_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedIndex = 3;
        } // end btnHomeReports_Click

        private void btnAddProdAdd_Click(object sender, EventArgs e)
        {
            string strKey = txtAddProdKey.Text;
            string strName = txtAddProdName.Text;
            string strSupplier = txtAddProdSupplier.Text;
            int intQuantity = int.Parse(txtAddProdQuantity.Text);
            float fltBuy = float.Parse(txtAddProdBuyPrice.Text);
            float fltSell = float.Parse(txtAddProdSellPrice.Text);
            float fltDiscount = float.Parse(txtAddProdDiscount.Text);

            dbmDataManager.AddProduct(strKey, strName, strSupplier, intQuantity, fltBuy, fltSell, fltDiscount);

            clearAddProdInput();
            updateList();

        } // end btnAddProdAdd_Click

        private void btnAddProdClear_Click(object sender, EventArgs e)
        {
            clearAddProdInput();
        } // end btnAddProdClear_Click

        private void cmbEditProdSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intIndex = cmbEditProdSelect.SelectedIndex;
            Product prdSelected = dbmDataManager.getProduct(intIndex);

            if (prdSelected != null)
            {
                txtEditProdOldName.Text = prdSelected.Name;
                txtEditProdOldSupplier.Text = prdSelected.Supplier;
                txtEditProdOldQuantity.Text = prdSelected.Quantity.ToString();
                txtEditProdOldBuy.Text = prdSelected.Price.ToString();
                txtEditProdOldSell.Text = prdSelected.RRP.ToString();
                txtEditProdOldDiscount.Text = prdSelected.Discounted.ToString();
            } // end if
            else
                throw new IndexOutOfRangeException("Error. No Product Found");
        } // end cmbEditProdSelect_SelectedIndexChanged

        private void changeProduct(Product aProduct)
        {
            if (txtEditProdNewName.Text != "")
                aProduct.Name = txtEditProdNewName.Text;
            if (txtEditProdNewBuy.Text != "")
                aProduct.Price = float.Parse(txtEditProdNewBuy.Text);
            if (txtEditProdNewQuantity.Text != "")
                aProduct.Quantity = int.Parse(txtEditProdNewQuantity.Text);
            if (txtEditProdNewSupplier.Text != "")
                aProduct.Supplier = txtEditProdNewSupplier.Text;
            if (txtEditProdNewSell.Text != "")
                aProduct.RRP = float.Parse(txtEditProdNewSell.Text);
            if (txtEditProdNewDiscount.Text != "")
                aProduct.Discounted = float.Parse(txtEditProdNewDiscount.Text);

            updateList();
        } // end changeProduct

        private void btnEditProdConfirm_Click(object sender, EventArgs e)
        {
            int intIndex = cmbEditProdSelect.SelectedIndex;
            Product prdChange = dbmDataManager.getProduct(intIndex);

            if (prdChange != null)
            {
                changeProduct(prdChange);
                clearEditProduct();
                updateList();
            }
            else
                throw new IndexOutOfRangeException("Error. No Product found");
        } // end btnEditProdConfirm_Click

        private void btnEditProdClear_Click(object sender, EventArgs e)
        {
            clearEditProduct();
        } // end btnEditProdClear_Click

        private void btnSalesClear_Click(object sender, EventArgs e)
        {
            dgvSalesReport.Rows.Clear();
            txtSalesQuantity.Text = "";
            txtSalesNotes.Text = "";
        }

        private void btnSalesAdd_Click(object sender, EventArgs e)
        {
            int intIndex = cmbSaleSelect.SelectedIndex;
            Product prdAdd = dbmDataManager.getProduct(intIndex);

            if (prdAdd != null)
            {
                int intQuantity = int.Parse(txtSalesQuantity.Text);

                if (!(intQuantity > prdAdd.Quantity))
                {
                    string strKey = prdAdd.Key;
                    string strName = prdAdd.Name;
                    float fltPrice = prdAdd.RRP;
                    float fltTotal = fltPrice * intQuantity;
                    string strNotes = txtSalesNotes.Text;

                    dgvSalesReport.Rows.Add(strKey, strName, intQuantity, fltPrice, fltTotal);

                    prdAdd.Quantity -= intQuantity;

                    txtSalesQuantity.Text = "";
                } // end if
                else
                    MessageBox.Show("Sale quantity must be less than the products quantity!!!", "Quantity Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } // end if
        } // end btnSalesAdd_Click

        private void btnSalesConfirm_Click(object sender, EventArgs e)
        {

        } // end btnSalesConfirm_Click

        private void btnHomePredict_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedIndex = 4;
        } // end btnHomePredict_Click

        private void cmbPredSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intIndex = cmbEditProdSelect.SelectedIndex;
            Product prdSelected = dbmDataManager.getProduct(intIndex);

            if (prdSelected != null)
            {
                txtPredOutStock.Text = dbmDataManager.LinearRegression(prdSelected).ToString();
            } // end if
            else
                throw new IndexOutOfRangeException("Error. No Product Found");
        }

        private void cmbSaleSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } // end frmPeopleHealthPharmacy
} // end namespace
