using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Entity;
using Inventory.Models;

namespace Inventory
{
    public partial class Inventory : Form
    {
        int ItemId = 0;
        bool schange = false;
        InventoryDashboard Invdash = null;
        List<ItemTypedropdown> itemtype = new List<ItemTypedropdown>();
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                Invdash = (InventoryDashboard)this.MdiParent;
                itemtype.Add(new ItemTypedropdown(1, "General"));
                itemtype.Add(new ItemTypedropdown(2, "Ammunition"));
                cbItemType.DataSource = itemtype;
                cbItemType.DisplayMember = "ItemTypeName";
                bindStoreItemGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bindStoreItemGrid()
        {
            using (var context = new INVENTORYEntities())
            {
                var list = from d in context.StoreInventories
                           where d.StoreId == Invdash.StoreId
                           select d;
                if (list.Count() > 0)
                {
                    cmbTitle.DataSource = list.ToList();
                    cmbTitle.DisplayMember = "ItemName";
                }
            }

            ItemId = 0;
            cmbTitle.SelectedIndex = -1;
            txtItemDescription.Text = "";
            txtInvoiceNumber.Text = "";
            txtVendor.Text = "";
            richPurchaseDesc.Text = "";
            cbItemType.SelectedItem = itemtype.Where(c => c.ItemTypeId == 1).FirstOrDefault();
            nmQuantity.Value = 0;
            grdItems.ReadOnly = true;
            using (var context = new INVENTORYEntities())
            {
                grdItems.DataSource = context.StorePurchaseItems.Where(c => c.StoreId == Invdash.StoreId).Select(d => new
                {
                    d.Id,
                    d.InvoiceNumber,
                    d.ItemName,
                    d.ItemDescription,
                    d.ItemCount,
                    d.Purchasedate,
                    d.PurchaseDescription,
                    d.VendorName
                }).ToList();               
                grdItems.Columns["Id"].Visible = false; //make the id column read only                 
                grdItems.Columns["ItemCount"].HeaderText = "Quantity";
                grdItems.Columns["ItemName"].HeaderText = "Item Title";
                grdItems.Columns["ItemDescription"].HeaderText = "Item Description";
                grdItems.Columns["InvoiceNumber"].HeaderText = "Invoice No.";
                grdItems.Columns["Purchasedate"].HeaderText = "Purchase Date";
                grdItems.Columns["PurchaseDescription"].HeaderText = "Purchase Description";
                grdItems.Columns["VendorName"].HeaderText = "Purchase From";
            }

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string abc = cmbTitle.Text;


                if (!ValidateData()) return;
                StoreInventory ItemToAdd = null;
                using (var context = new INVENTORYEntities())
                {
                    if (ItemId != 0)
                    {
                        ItemToAdd = (from c in context.StoreInventories
                                     where c.Id == ItemId
                                     select c).FirstOrDefault();
                        ItemToAdd.ItemCount += (int)nmQuantity.Value;
                        ItemToAdd.AvailableQuantity += (int)nmQuantity.Value;
                    }
                    else
                    {
                        ItemToAdd = new StoreInventory();
                        ItemToAdd.ItemCount = (int)nmQuantity.Value;
                        ItemToAdd.AvailableQuantity = (int)nmQuantity.Value;
                        ItemToAdd.ItemName = cmbTitle.Text;
                        ItemToAdd.ItemDescription = txtItemDescription.Text;
                        ItemToAdd.ItemType = ((ItemTypedropdown)cbItemType.SelectedValue).ItemTypeId;
                        ItemToAdd.StoreId = Invdash.StoreId;
                    }
                    
                    if (ItemId == 0)
                    {
                        context.StoreInventories.Add(ItemToAdd);
                    }
                   
                    StorePurchaseItem spi = new StorePurchaseItem();
                    spi.CreatedBy = Invdash.LoginId;
                    spi.InvoiceNumber = txtInvoiceNumber.Text;
                    spi.ItemCount = nmQuantity.Value;
                    spi.ItemDescription = txtItemDescription.Text;
                    spi.ItemName = cmbTitle.Text;
                    spi.PurchaseDescription = richPurchaseDesc.Text;
                    spi.VendorName = txtVendor.Text;
                    spi.Purchasedate = DateTime.Now;
                    spi.StoreId = Invdash.StoreId;
                    spi.StoreItemId = ItemToAdd.Id;
                    spi.ItemPrice = txtItemPrice.Value;
                    context.StorePurchaseItems.Add(spi);

                    context.SaveChanges();
                    bindStoreItemGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            if (cmbTitle.Text.Trim() == "")
            {
                MessageBox.Show("Item Title is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTitle.Focus();
                return false;
            }

            if (txtItemDescription.Text.Trim() == "")
            {
                MessageBox.Show("Item Description is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemDescription.Focus();
                return false;
            }

            if (txtItemDescription.Text.Trim() == "")
            {
                MessageBox.Show("Item Description is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemDescription.Focus();
                return false;
            }
            return true;
        }
        private void cmbTitle_TextChanged(object sender, EventArgs e)
        {
            if (!schange)
                HandleTextChanged();
        }

        private void cmbTitle_KeyUp(object sender, KeyEventArgs e)
        {
            schange = false;
            if (e.KeyCode == Keys.Back)
            {
                int sStart = cmbTitle.SelectionStart;
                if (sStart > 0)
                {
                    sStart--;
                    if (sStart == 0)
                    {
                        cmbTitle.Text = "";
                    }
                    else
                    {
                        cmbTitle.Text = cmbTitle.Text.Substring(0, sStart);
                    }
                }
                e.Handled = true;
            }
        }

        private void HandleTextChanged()
        {
            var txt = cmbTitle.Text;

            using (var context = new INVENTORYEntities())
            {
                var list = from d in context.StoreInventories
                           where d.ItemName.ToUpper().StartsWith(cmbTitle.Text.ToUpper()) && d.StoreId == Invdash.StoreId
                           select d;
                if (list.Count() > 0)
                {
                    cmbTitle.DataSource = list.ToList();
                    cmbTitle.DisplayMember = "ItemName";
                    var sText = cmbTitle.Items[0].ToString();
                    cmbTitle.SelectionStart = txt.Length;
                    cmbTitle.SelectionLength = sText.Length - txt.Length;
                    cmbTitle.DroppedDown = true;
                    return;
                }
                else
                {
                    ItemId = 0;
                    cmbTitle.DroppedDown = false;
                    cmbTitle.SelectionStart = txt.Length;
                    txtItemDescription.Enabled = true;
                    cbItemType.Enabled = true;
                    txtItemDescription.Text = "";
                    cbItemType.SelectedIndex = 0;
                }
            }
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            schange = true;
            ComboBox comboBox = (ComboBox)sender;
            if (cmbTitle.SelectedItem != null)
            {
                StoreInventory storeInventory = (StoreInventory)cmbTitle.SelectedItem;
                ItemId = storeInventory.Id;
                txtItemDescription.Enabled = false;
                cbItemType.Enabled = false;
                txtItemDescription.Text = storeInventory.ItemDescription;
                cbItemType.SelectedItem = itemtype.Where(c => c.ItemTypeId == storeInventory.ItemType).FirstOrDefault();
            }
            else
            {
                ItemId = 0;
                txtItemDescription.Enabled = true;
                cbItemType.Enabled = true;
                txtItemDescription.Text = "";
                cbItemType.SelectedIndex = 0;
            }
        }
    }
}
