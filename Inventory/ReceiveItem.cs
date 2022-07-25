using Inventory.Entity;
using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ReceiveItem : Form
    {
        public int StoreId = 0;
        StoreInventory storeInventory = null;
        public InventoryDashboard Invdash = null;
        decimal AvailableItemQty = 0;
        public ReceiveItem()
        {
            InitializeComponent();
        }
        private void ReceiveItem_Load(object sender, EventArgs e)
        {
            bindData();
        }
        private void bindData()
        {
            using (var context = new INVENTORYEntities())
            {
                List<Zone> zn = context.Zones.Where(c => c.StoreId == StoreId && c.ZoneInventories.Count() > 0).ToList();
                cbZones.DataSource = zn;
                cbZones.DisplayMember = "SortDescription";
                cbZones.ValueMember = "Id";
                cbZones.SelectedIndex = -1;
                lblQty.Text = "";
                lbIndItemcount.Text = "";
                List<CBIndividual> Ind = context.Individuals.Where(c => c.StoreId == StoreId && c.IndividualInventories.Count() > 0)
                    .Select(d => new CBIndividual()
                    {
                        Id = d.Id,
                        Name = d.Name + "(" + d.IDNumber + ")",
                        Address = d.Address,
                        IDNumber = d.IDNumber
                    })
                    .ToList();
                cbIndividual.DataSource = Ind;
                cbIndividual.DisplayMember = "Name";
                cbIndividual.SelectedIndex = -1;
                lbIndItemcount.Text = "";
            }
        }
        private void rdZone_CheckedChanged(object sender, EventArgs e)
        {
            pnlZone.Visible = true;
            pnlInd.Visible = false;

            cbIndividual.SelectedIndex = -1;
            lbIndItemcount.Text = "";
            cbZones.SelectedIndex = -1;
            lblQty.Text = "";

            cbIndItems.DataSource = null;
        }
        private void rdInd_CheckedChanged(object sender, EventArgs e)
        {
            pnlZone.Visible = false;
            pnlInd.Visible = true;

            cbIndividual.SelectedIndex = -1;
            lbIndItemcount.Text = "";
            cbZones.SelectedIndex = -1;
            lblQty.Text = "";
            cbStockItem.DataSource = null;
        }

        private void cbIndividual_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new INVENTORYEntities())
            {
                CBIndividual selectedInd = (CBIndividual)cbIndividual.SelectedItem;
                if (selectedInd != null)
                {
                    List<StoreInventory> st = context.StoreInventories.Where(c => c.StoreId == StoreId && c.IndividualInventories.Where(d => d.IndividualId == selectedInd.Id && d.ItemCount > 0).Count() > 0).ToList();
                    cbIndItems.DataSource = st;
                    cbIndItems.DisplayMember = "ItemName";
                    cbIndItems.SelectedIndex = -1;
                    lbIndItemcount.Text = "";
                    lblQty.Text = "";
                }
            }
        }
        private void cbZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new INVENTORYEntities())
            {
                Zone selectedZone = (Zone)cbZones.SelectedItem;
                if (selectedZone != null)
                {
                    List<StoreInventory> st = context.StoreInventories.Where(c => c.StoreId == StoreId && c.ZoneInventories.Where(d => d.ZoneId == selectedZone.Id && d.ItemCount > 0).Count() > 0).ToList();
                    cbStockItem.DataSource = st;
                    cbStockItem.DisplayMember = "ItemName";
                    cbStockItem.SelectedIndex = -1;
                    lbIndItemcount.Text = "";
                    lblQty.Text = "";
                }
            }
        }
        private void cbIndItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreInventory selecteditem = (StoreInventory)cbIndItems.SelectedItem;
            if (selecteditem == null) return;
            using (var context = new INVENTORYEntities())
            {
                CBIndividual selectedInd = (CBIndividual)cbIndividual.SelectedItem;
                if (selectedInd != null)
                    AvailableItemQty = context.IndividualInventories.Where(c => c.Individual.StoreId == StoreId && c.IndividualId == selectedInd.Id && c.StoreItemId == selecteditem.Id).FirstOrDefault().ItemCount.Value;
            }
            if (AvailableItemQty > 0)
                lbIndItemcount.Text = "Available Quantity : " + AvailableItemQty;
            else
                lbIndItemcount.Text = "";
        }

        private void cbStockItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreInventory selecteditem = (StoreInventory)cbStockItem.SelectedItem;
            if (selecteditem == null) return;
            using (var context = new INVENTORYEntities())
            {
                Zone selectedZone = (Zone)cbZones.SelectedItem;
                if (selectedZone != null)
                    AvailableItemQty = context.ZoneInventories.Where(c => c.Zone.StoreId == StoreId && c.ZoneId == selectedZone.Id && c.StoreItemId == selecteditem.Id).FirstOrDefault().ItemCount.Value;
            }
            if (AvailableItemQty > 0)
                lblQty.Text = "Available Quantity : " + AvailableItemQty;
            else
                lblQty.Text = "";
        }

        private void btnSaveZone_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            using (var context = new INVENTORYEntities())
            {
                Zone znselectedzone = (Zone)cbZones.SelectedItem;
                storeInventory = (StoreInventory)cbStockItem.SelectedItem;
                ZoneInventory zni = context.ZoneInventories.Where(c => c.StoreItemId == storeInventory.Id && c.ZoneId == znselectedzone.Id).FirstOrDefault();
                if (zni == null)
                {
                    MessageBox.Show("There is some error.. Please communicate with Software admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    zni.ItemCount -= nmQuantityZone.Value;
                }
                context.SaveChanges();
            }
            SaveTransactions();
        }
        private void btnSaveInd_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            using (var context = new INVENTORYEntities())
            {

                CBIndividual cbind = (CBIndividual)cbIndividual.SelectedItem;
                storeInventory = (StoreInventory)cbIndItems.SelectedItem;

                IndividualInventory indi = context.IndividualInventories.Where(c => c.StoreItemId == storeInventory.Id && c.IndividualId== cbind.Id).FirstOrDefault();


                if (indi == null)
                {
                    MessageBox.Show("There is some error.. Please communicate with Software admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    indi.ItemCount -= nmQuantityInd.Value;
                }
                context.SaveChanges();
            }
            SaveTransactions();
        }
        private bool ValidateData()
        {
            if (rdZone.Checked)
            {
                Zone znselectedzone = (Zone)cbZones.SelectedItem;
                if (znselectedzone == null)
                {
                    MessageBox.Show("Please select Zone", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbZones.Focus();
                    return false;
                }

                storeInventory = (StoreInventory)cbStockItem.SelectedItem;
                if (storeInventory == null)
                {
                    MessageBox.Show("Please select Item that received", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbStockItem.Focus();
                    return false;
                }

                if (AvailableItemQty < nmQuantityZone.Value)
                {
                    MessageBox.Show("Please enter quantity less then available quantity!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nmQuantityZone.Focus();
                    return false;
                }
                

                if (nmQuantityZone.Value == 0)
                {
                    MessageBox.Show("Please add quantity more than 0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nmQuantityZone.Focus();
                    return false;
                }
            }
            else
            {
                CBIndividual cbind = (CBIndividual)cbIndividual.SelectedItem;
                if (cbind == null)
                {
                    MessageBox.Show("Please select Individual name from whome we received the item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbIndividual.Focus();
                    return false;
                }

                storeInventory = (StoreInventory)cbIndItems.SelectedItem;
                if (storeInventory == null)
                {
                    MessageBox.Show("Please select Store Item for Issue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbIndItems.Focus();
                    return false;
                }

                if (AvailableItemQty < nmQuantityInd.Value)
                {
                    MessageBox.Show("Please enter quantity less then available quantity!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nmQuantityInd.Focus();
                    return false;
                }
                if (nmQuantityInd.Value == 0)
                {
                    MessageBox.Show("Please add quantity more than 0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nmQuantityInd.Focus();
                    return false;
                }
            }
            return true;
        }
        private void SaveTransactions()
        {
            using (var context = new INVENTORYEntities())
            {
                StoreTransaction st = new StoreTransaction();
                st.StoreId = StoreId;                
                st.TransactionDate = DateTime.Now;
                st.TransactionType = 2;

                if (rdZone.Checked)
                {
                    Zone znselectedzone = (Zone)cbZones.SelectedItem;
                    st.ZoneId = znselectedzone.Id;
                    st.ItemCount = nmQuantityZone.Value;
                    st.Description = rchtextDescriptionZone.Text;
                    storeInventory = (StoreInventory)cbStockItem.SelectedItem;
                    st.StoreItemId = storeInventory.Id;
                    st.ZoneName = znselectedzone.SortDescription;
                }
                else
                {
                    CBIndividual cbind = (CBIndividual)cbIndividual.SelectedItem;
                    st.ItemCount = nmQuantityInd.Value;
                    st.Description = rchtextDescriptionInd.Text;
                    st.IndividualId = cbind.Id;
                    st.IndividualName = cbIndividual.Text;
                    storeInventory = (StoreInventory)cbIndItems.SelectedItem;
                    st.StoreItemId = storeInventory.Id;
                }

                context.StoreTransactions.Add(st);
                StoreInventory si = context.StoreInventories.Where(c => c.Id == storeInventory.Id && c.StoreId == StoreId).FirstOrDefault();
                si.AvailableQuantity += st.ItemCount;
                context.SaveChanges();
            }
            MessageBox.Show("Data updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.Invdash.homeMenuClick();
        }
    }
}
