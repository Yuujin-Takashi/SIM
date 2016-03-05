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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        static string ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=simDB";
        static MySqlConnection connect = new MySqlConnection(ConnectionString);
        static MySqlCommand cmd;
        static MySqlDataReader dtareader;
        public static String employeeID, employeefname, employeelname, birthdate, address, gender, phonenum, roleID;

        int countgender;

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == true || rbFemale.Checked == true)
            {
                countgender = 1;
            }
            if ((txtEmployeeID.Text == "") || (txtEmployeeFirstName.Text == "") || (txtEmployeeLastName.Text == "") || (txtBirthDate.Text == "") || (txtAddress.Text == "") || (countgender == 0) || (txtPhoneNum.Text == "") || (txtRoleID.Text == ""))
            {
                MessageBox.Show("Please Fill out all the Items", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (MessageBox.Show("Are you Sure You To Add This Item?", "Inventory System",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
          == DialogResult.Yes)
                {
                    employeeID = txtEmployeeID.Text;
                    employeefname = txtEmployeeFirstName.Text;
                    employeelname = txtEmployeeLastName.Text;
                    birthdate = txtBirthDate.Text;
                    address = txtAddress.Text;
                    phonenum = txtPhoneNum.Text;
                    roleID = txtRoleID.Text;

                    if (rbMale.Checked == true)
                    {
                        gender = rbMale.Text;
                    }
                    else
                    {
                        gender = rbFemale.Text;
                    }
                    string InsertData = "INSERT INTO simdb.tblemployee VALUES ('" + employeeID + "', '" + employeefname + "', '" + employeelname + "', '" + birthdate + "', '" + address + "', '" + gender + "', '" + phonenum + "', '" + roleID + "');";

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
            //connect to listview
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            //connect to listview
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = String.Empty;
            txtEmployeeFirstName.Text = String.Empty;
            txtEmployeeLastName.Text = String.Empty;
            txtBirthDate.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhoneNum.Text = String.Empty;
            txtRoleID.Text = String.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }
    }
}
