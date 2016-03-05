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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        static frmAbout frmabout = new frmAbout();
        static frmCategory frmcategory = new frmCategory();
        static frmConfiguration frmconfig = new frmConfiguration();
        static frmCustomers frmcustomers = new frmCustomers();
        static frmDelivery frmdelivery = new frmDelivery();
        static frmEmployee frmemployee = new frmEmployee();
        static frmInventory frminventory = new frmInventory();
        static frmProducts frmproducts = new frmProducts();
        static frmOrder frmpurchase = new frmOrder();
        static frmSettings frmsettings = new frmSettings();
        static frmSupplier frmsupplier = new frmSupplier();
        static frmTools frmtools = new frmTools();

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e){}
        private void toolStripButton1_Click(object sender, EventArgs e) { }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void recordToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconfig.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmemployee.MdiParent = this;
            frmemployee.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategory.MdiParent = this;
            frmcategory.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproducts.MdiParent = this;
            frmproducts.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmabout.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmcustomers.MdiParent = this;
            frmcustomers.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmsupplier.MdiParent = this;
            frmsupplier.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmproducts.MdiParent = this;
            frmproducts.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frminventory.MdiParent = this;
            frminventory.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmpurchase.MdiParent = this;
            frmpurchase.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmdelivery.MdiParent = this;
            frmdelivery.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            frmtools.MdiParent = this;
            frmtools.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmsettings.MdiParent = this.MdiParent;
            frmsettings.ShowDialog();
        }
       
    }
}
