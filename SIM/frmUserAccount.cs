using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public partial class frmUserAccount : Form
    {
        public frmUserAccount()
        {
            InitializeComponent();
        }

        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        // Emloyee Details/Profile
        //Change Username / Password
        //Employee Role(Admin, Staff, User) = Level of access [add to frmLogin too]
        //just placed role details there for (tab or somethin)
    }
}
