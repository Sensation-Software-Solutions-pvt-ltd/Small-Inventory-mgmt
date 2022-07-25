using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class InventoryDashboard : Form
    {
        public int LoginId = 0;
        public string formtitle = "Store";
        public int StoreId = 0;
        public string StoreTitle = "";
        public string StoreAddress = "";
        Home ds = null;
        Inventory Inv = null;
        Zones zn = null;
        Individuals Ind = null;
        //NewsPapers ns = null;
        //NewsPaperRates nsr = null;
        //MapNewsPaperWithCustomer mnpwc = null;
        //Invoices inv = null;
        //BulkSupply bs = null;
        public Login lg = null;

        public InventoryDashboard()
        {
            InitializeComponent();
        }
        private void CloseAllMDIChildreen(Form form)
        {
            ds = form != ds ? null : ds;
            Inv = form != Inv ? null : Inv;
            zn = form != zn ? null : zn;
            Ind = form != Ind ? null : Ind;
            //mnpwc = form != mnpwc ? null : mnpwc;
            //inv = form != inv ? null : inv;
            //bs = form != bs ? null : bs;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm != form)
                {
                    frm.Dispose();
                    return;
                }
            }
        }

        private void InventoryDashboard_Load(object sender, EventArgs e)
        {
            ds = new Home();
            ds.MdiParent = this;
            ds.Dock = DockStyle.Fill;
            ds.Invdash = this;
            ds.Show();
            this.Text = ds.Text + " - " + formtitle;
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDIChildreen(ds);
            if (ds == null)
            {
                ds = new Home();
                ds.MdiParent = this;
                ds.Dock = DockStyle.Fill;
                ds.Invdash = this;
                ds.Show();
                this.Text = ds.Text + " - " + formtitle;
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        public void homeMenuClick()
        {
            CloseAllMDIChildreen(ds);
            if (ds == null)
            {
                ds = new Home();
                ds.MdiParent = this;
                ds.Dock = DockStyle.Fill;
                ds.Invdash = this;
                ds.Show();
                this.Text = ds.Text + " - " + formtitle;
                this.LayoutMdi(MdiLayout.Cascade);
            }
            else
                ds.BindGrid();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lg.Show();
            this.Close();
            this.Dispose();
        }

        private void InventoryDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            lg.Show();
        }

        private void manualSuplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueItem issue = new IssueItem();
            issue.StoreId = this.StoreId;
            issue.Invdash = this;
            issue.ShowDialog();
        }

        private void masterSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDIChildreen(Inv);
            if (Inv == null)
            {
                Inv = new Inventory();
                Inv.MdiParent = this;
                Inv.Dock = DockStyle.Fill;
                Inv.Show();
                this.Text = Inv.Text + " - " + formtitle;
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        private void mnZones_Click(object sender, EventArgs e)
        {
            CloseAllMDIChildreen(zn);
            if (zn == null)
            {
                zn = new Zones();
                zn.MdiParent = this;
                zn.Dock = DockStyle.Fill;
                zn.Show();
                this.Text = zn.Text + " - " + formtitle;
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        private void ReceiveItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceiveItem receive = new ReceiveItem();
            receive.StoreId = this.StoreId;
            receive.Invdash = this;
            receive.ShowDialog();
        }

        private void individualsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDIChildreen(Ind);
            if (Ind == null)
            {
                Ind = new Individuals();
                Ind.MdiParent = this;
                Ind.Dock = DockStyle.Fill;
                Ind.Show();
                this.Text = Ind.Text + " - " + formtitle;
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }
    }
}
