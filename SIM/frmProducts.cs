using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIM
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        
        static string ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=simDB";
        static MySqlConnection connect = new MySqlConnection(ConnectionString);
        static MySqlCommand cmd;
        static MySqlDataReader dtareader;
        public static String productID, productname, productdesc, categoryID, supplierID, unitquantity, unitprice, sellingprice, gender, unitsize, discount, unitstock, unitorder, reorder, note;

        int countgender;

        private void frmProducts_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == true || rbFemale.Checked == true)
            {
                countgender = 1;
            }
            if ((txtProductID.Text == "") || (txtProductName.Text == "") || (txtProductDesc.Text == "") || (txtCategoryID.Text == "") || (txtSupplierID.Text == "") || (txtUnitQuantity.Text == "") || (txtUnitPrice.Text == "") || (txtSellingPrice.Text == "") || (countgender == 0) || (txtUnitSize.Text == "") || (txtDiscount.Text == "") || (txtUnitStock.Text == "") || (txtUnitOrder.Text == "") || (txtReorderNo.Text == "") || (txtNote.Text == ""))
            {
                MessageBox.Show("Please Fill out all the Items", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (MessageBox.Show("Are you Sure You To Add This Item?", "Inventory System",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
          == DialogResult.Yes)
                {
                    productID = txtProductID.Text;
                    productname = txtProductName.Text;
                    productdesc = txtProductDesc.Text;
                    categoryID = txtCategoryID.Text;
                    supplierID = txtSupplierID.Text;
                    unitquantity = txtUnitQuantity.Text;
                    unitprice = txtUnitPrice.Text;
                    sellingprice = txtSellingPrice.Text;
                    unitsize = txtUnitSize.Text;
                    discount = txtDiscount.Text;
                    unitstock = txtUnitStock.Text;
                    unitorder = txtUnitOrder.Text;
                    reorder = txtReorderNo.Text;
                    note = txtNote.Text;

                    if (rbMale.Checked == true)
                    {
                        gender = rbMale.Text;
                    }
                    else
                    {
                        gender = rbFemale.Text;
                    }
                    string InsertData = "INSERT INTO simdb.tblproduct VALUES ('" + productID + "', '" + productname + "', '" + productdesc + "', '" + categoryID + "', '" + supplierID + "', '" + unitquantity + "', '" + unitprice + "', '" + sellingprice + "', '" + gender + "', '" + unitsize + "', '" + discount + "', '" + unitstock + "', '" + unitorder + "', '" + reorder + "', '" + note + "');";

                    cmd = new MySqlCommand(InsertData, connect);

                    try
                    {
                        connect.ConnectionString = ConnectionString;
                        connect.Open();
                        dtareader = cmd.ExecuteReader();
                        MessageBox.Show("Data Saved");
                        while (dtareader.Read())
                        {
                        }
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            //update listview
            //connect list view to db
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //delete data thru listview
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtProductID.Text = String.Empty;
            txtProductName.Text = String.Empty;
            txtProductDesc.Text = String.Empty;
            txtCategoryID.Text = String.Empty;
            txtSupplierID.Text = String.Empty;
            txtUnitQuantity.Text = String.Empty;
            txtUnitPrice.Text = String.Empty;
            txtSellingPrice.Text = String.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtUnitSize.Text = String.Empty;
            txtDiscount.Text = String.Empty;
            txtUnitStock.Text = String.Empty;
            txtUnitOrder.Text = String.Empty;
            txtReorderNo.Text = String.Empty;
            txtNote.Text = String.Empty;
        }
    }
}
