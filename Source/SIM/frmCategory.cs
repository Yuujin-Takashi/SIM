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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //^Code to be used if gonna add a listview
        }

        static string ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=simDB";
        static MySqlConnection connect = new MySqlConnection(ConnectionString);
        static MySqlCommand cmd;
        static MySqlDataReader dtareader;
        public static String categoryID, categoryname, categorydesc;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((txtCategoryID.Text == "") || (txtCategoryName.Text == "") || (txtCategoryDesc.Text == ""))
            {
                MessageBox.Show("Please Fill out all the Items", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (MessageBox.Show("Are you Sure You To Add This Category?", "Inventory System",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
          == DialogResult.Yes)
                {
                    categoryID = txtCategoryID.Text;
                    categoryname = txtCategoryName.Text;
                    categorydesc = txtCategoryDesc.Text;

                    string InsertData = "INSERT INTO simdb.tblcategory VALUES ('" + categoryID + "', '" + categoryname + "', '" + categorydesc + "');";

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you sure to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtCategoryID.Text = String.Empty;
                txtCategoryName.Text = String.Empty;
                txtCategoryDesc.Text = String.Empty;
            }
        }
    }
}
