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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        static frmLogin frmlogin = new frmLogin();
        public int timeleft { get; set; }
        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timeleft = 15;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                frmlogin.Show();
            }
        }
    }
}
