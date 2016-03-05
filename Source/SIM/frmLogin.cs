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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        static frmMain frmmain = new frmMain();
        static string ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=simDB";
        static MySqlConnection connect = new MySqlConnection(ConnectionString);
        static MySqlCommand cmd = new MySqlCommand();

        private bool validate_login(string user, string pass)
        {
            connect.Open();
            cmd.CommandText = "Select username, password from tblemployee where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }
            bool r = validate_login(user, pass);
            if (r)
            {
                MessageBox.Show("Welcome Administrator!");
                frmmain.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect Login Credentials");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
            }
        }
    }
}
