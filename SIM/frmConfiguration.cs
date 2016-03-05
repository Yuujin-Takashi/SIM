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
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }

        static string ConnectionString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=simDB";
        static MySqlConnection connect = new MySqlConnection(ConnectionString);
        static MySqlCommand cmd = new MySqlCommand();

        private void cmdTest_Click(object sender, EventArgs e)
        {

            string tstserver = txtServerHost.Text;
            string tstport = txtPort.Text;
            string tstusername = txtUserName.Text;
            string tstpassword = txtPassword.Text;
            string tstdatabase = txtDatabase.Text;

            try
            {
                //connect = "Server = '" & tstserver & "'" & "Port ='" & tstport & "'" &"Username ='" & tstusername & "'" &"Password ='" & tstpassword & "'" &"Database ='" & tstdatabase & "'";


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
