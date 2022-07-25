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
    public partial class IssueItem : Form
    {
        public int StoreId = 0;
        StoreInventory storeInventory = null;
        public InventoryDashboard Invdash = null;
        public IssueItem()
        {
            InitializeComponent();
        }

        private void NoSupplyDates_Load(object sender, EventArgs e)
        {
            bindData();
        }

        private void bindData()
        {
            using (var context = new INVENTORYEntities())
            {
                List<StoreInventory> st = context.StoreInventories.Where(c => c.StoreId == StoreId).ToList();
                cbStockItem.DataSource = st;
                cbStockItem.DisplayMember = "ItemName";
                cbStockItem.SelectedIndex = -1;

                List<Zone> zn = context.Zones.Where(c => c.StoreId == StoreId).ToList();
                cbZones.DataSource = zn;
                cbZones.DisplayMember = "SortDescription";
                cbZones.ValueMember = "Id";
                cbZones.SelectedIndex = -1;
                lblQty.Text = "";

                List<CBIndividual> Ind = context.Individuals.Where(c => c.StoreId == StoreId)
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

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pnlZone.Visible = true;
            pnlInd.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pnlZone.Visible = false;
            pnlInd.Visible = true;
        }

        private void btnSaveZone_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            using (var context = new INVENTORYEntities())
            {
                Zone znselectedzone = (Zone)cbZones.SelectedItem;
                ZoneInventory zni = context.ZoneInventories.Where(c => c.StoreItemId == storeInventory.Id && c.ZoneId == znselectedzone.Id).FirstOrDefault();
                if (zni == null)
                {
                    zni = new ZoneInventory();
                    zni.ItemCount = nmQuantityZone.Value;
                    zni.ItemName = storeInventory.ItemName;
                    zni.StoreItemId = storeInventory.Id;
                    zni.ZoneId = znselectedzone.Id;
                    context.ZoneInventories.Add(zni);
                }
                else
                {
                    zni.ItemCount += nmQuantityZone.Value;
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
                CBIndividual dbind = (CBIndividual)cbIndividual.SelectedItem;
                IndividualInventory indi = context.IndividualInventories.Where(c => c.StoreItemId == storeInventory.Id && c.IndividualId== dbind.Id).FirstOrDefault();
                if (indi == null)
                {
                    indi = new IndividualInventory();
                    indi.ItemCount = nmQuantityInd.Value;
                    indi.StoreItemName = storeInventory.ItemName;
                    indi.StoreItemId = storeInventory.Id;
                    indi.Name = dbind.Name;                    
                    indi.IndividualId = dbind.Id;
                    context.IndividualInventories.Add(indi);
                }
                else
                {
                    indi.ItemCount += nmQuantityZone.Value;
                }
                context.SaveChanges();
            }
            SaveTransactions();
        }

        private bool ValidateData()
        {
            storeInventory = (StoreInventory)cbStockItem.SelectedItem;
            if (storeInventory == null)
            {
                MessageBox.Show("Please select Store Item for Issue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbStockItem.Focus();
                return false;
            }

            if (rdZone.Checked)
            {
                if (storeInventory.AvailableQuantity < nmQuantityZone.Value)
                {
                    MessageBox.Show("Please enter quantity less then available quantity!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nmQuantityZone.Focus();
                    return false;
                }
                Zone znselectedzone = (Zone)cbZones.SelectedItem;
                if (znselectedzone == null)
                {
                    MessageBox.Show("Please select Zone", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbZones.Focus();
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
                if (storeInventory.AvailableQuantity < nmQuantityInd.Value)
                {
                    MessageBox.Show("Please enter quantity less then available quantity!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nmQuantityInd.Focus();
                    return false;
                }

                CBIndividual znselectedIndividual = (CBIndividual)cbIndividual.SelectedItem;
                if (znselectedIndividual == null)
                {
                    MessageBox.Show("Please select Individual", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbIndividual.Focus();
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
                st.StoreItemId = storeInventory.Id;
                st.TransactionDate = DateTime.Now;
                st.TransactionType = 1;

                if (rdZone.Checked)
                {
                    Zone znselectedzone = (Zone)cbZones.SelectedItem;
                    st.ZoneId = znselectedzone.Id;
                    st.ItemCount = nmQuantityZone.Value;
                    st.Description = rchtextDescriptionZone.Text;
                    st.ZoneName = znselectedzone.SortDescription;
                }
                else
                {
                    CBIndividual znselectedIndividual = (CBIndividual)cbIndividual.SelectedItem;
                    st.ItemCount = nmQuantityInd.Value;
                    st.Description = rchtextDescriptionInd.Text;                    
                    st.IndividualName = znselectedIndividual.Name;
                    st.IndividualId = znselectedIndividual.Id;
                }

                context.StoreTransactions.Add(st);
                StoreInventory si = context.StoreInventories.Where(c => c.Id == storeInventory.Id && c.StoreId == StoreId).FirstOrDefault();
                si.AvailableQuantity -= st.ItemCount;
                context.SaveChanges();
            }
            MessageBox.Show("Data updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.Invdash.homeMenuClick();
        }

        bool schange = true;

        private void cbStockItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            schange = true;
            ComboBox comboBox = (ComboBox)sender;
            if (cbStockItem.SelectedItem != null)
            {
                StoreInventory storeInventory = (StoreInventory)cbStockItem.SelectedItem;
                lblQty.Text = "(Available Quantiry " + storeInventory.AvailableQuantity + ")";
            }
        }


        private void cbStockItem_TextChanged(object sender, EventArgs e)
        {
            if (!schange)
            {
                using (var context = new INVENTORYEntities())
                {
                    var txt = cbStockItem.Text;
                    List<StoreInventory> st = context.StoreInventories.Where(c => c.StoreId == StoreId && c.ItemName.Contains(txt)).ToList();
                    if (st.Count() > 0)
                    {
                        cbStockItem.DataSource = st;
                        var sText = cbStockItem.Items[0].ToString();
                        cbStockItem.SelectionStart = txt.Length;
                        cbStockItem.SelectionLength = sText.Length - txt.Length;
                        cbStockItem.DroppedDown = true;
                    }
                    else
                    {

                    }
                }
            }
        }

        private void cbStockItem_KeyUp(object sender, KeyEventArgs e)
        {
            schange = false;
            if (e.KeyCode == Keys.Back)
            {
                int sStart = cbStockItem.SelectionStart;
                if (sStart > 0)
                {
                    sStart--;
                    if (sStart == 0)
                    {
                        cbStockItem.Text = "";
                    }
                    else
                    {
                        cbStockItem.Text = cbStockItem.Text.Substring(0, sStart);
                    }
                }
                e.Handled = true;
            }
        }

        private void cbStockItem_Leave(object sender, EventArgs e)
        {
            if (!schange)
            {
                using (var context = new INVENTORYEntities())
                {
                    int ind = cbStockItem.SelectedIndex;
                    List<StoreInventory> st = context.StoreInventories.Where(c => c.StoreId == StoreId).ToList();
                    cbStockItem.DataSource = st;
                    cbStockItem.SelectedIndex = ind;
                }
            }
        }
    }
}
