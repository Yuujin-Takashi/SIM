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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        static string ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=simDB";
        static MySqlConnection connect = new MySqlConnection(ConnectionString);
        static MySqlCommand cmd;
        static MySqlDataReader dtareader;
        public static String customerID, customerfname, customerlname, address, phone, email, employeeID;

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListViewItem items = new ListViewItem();
            //lstCustomer.Items.Add();

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
if ((txtCustomerID.Text == "") || (txtCustomerFirstName.Text == "") || (txtCustomerLastName.Text == "") || (txtAddress.Text == "") || (txtContact.Text == "") || (txtEmail.Text == "") || (txtEmployeeID.Text == ""))
            {
                MessageBox.Show("Please Fill out all the Items", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (MessageBox.Show("Are you Sure You To Add This Item?", "Inventory System",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
          == DialogResult.Yes)
                {
                    customerID = txtCustomerID.Text;
                    customerfname = txtCustomerFirstName.Text;
                    customerlname = txtCustomerLastName.Text;
                    address = txtAddress.Text;
                    phone = txtContact.Text;
                    email = txtEmail.Text;
                    employeeID = txtEmployeeID.Text;


                    string InsertData = "INSERT INTO simdb.tblcustomer VALUES ('" + customerID + "', '" + customerfname + "', '" + customerlname + "', '" + address + "', '" + phone + "', '" + email + "', '" + employeeID + "');";

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
            //Update codes for list view
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //connect to listview??
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = String.Empty;
            txtCustomerFirstName.Text = String.Empty;
            txtCustomerLastName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtContact.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtEmployeeID.Text = String.Empty;
        }
    }
}
