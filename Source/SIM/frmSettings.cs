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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        static frmArchiveRestore frmarchiverestore = new frmArchiveRestore();
        static frmDateTime frmdatetime = new frmDateTime();
        static frmSalesSched frmsalessched = new frmSalesSched();
        static frmUserAccount frmuseraccount = new frmUserAccount();


        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            frmarchiverestore.MdiParent = this;
            frmarchiverestore.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frmdatetime.MdiParent = this;
            frmdatetime.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            frmsalessched.MdiParent = this;
            frmsalessched.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmuseraccount.MdiParent = this;
            frmuseraccount.Show();
        }

    }
}
