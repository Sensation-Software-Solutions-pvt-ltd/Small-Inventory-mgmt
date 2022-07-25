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
    public partial class Zones : Form
    {
        int ItemId = 0;
        InventoryDashboard Invdash = null;
        public Zones()
        {
            InitializeComponent();
        }

        private void Zones_Load(object sender, EventArgs e)
        {
            try
            {
                Invdash = (InventoryDashboard)this.MdiParent;                         
                bindStoreItemGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bindStoreItemGrid()
        {
            ItemId = 0;
            txttitle.Text = "";
            lblAddEdit.Text = "Add New Zone";
            txtItemDescription.Text = "";
            btnSaveUpdate.Text = "Save";          
            btnDelete.Visible = false;
            grdItems.ReadOnly = true;
            using (var context = new INVENTORYEntities())
            {
                grdItems.DataSource = context.Zones.Where(c => c.StoreId == Invdash.StoreId).Select(d => new {
                    d.Id,
                    d.SortDescription,
                    d.Address
                }).ToList();
              
                grdItems.Columns["Id"].Visible = false; //make the id column read only 
                grdItems.Columns["SortDescription"].HeaderText = "Zone Name";
                grdItems.Columns["Address"].HeaderText = "Address";
            }

        }

        private void grdItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ItemId = (int)grdItems.Rows[e.RowIndex].Cells[0].Value;
            txttitle.Text = grdItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtItemDescription.Text = grdItems.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblAddEdit.Text = "Update Zone";
            btnDelete.Visible = true;
            btnSaveUpdate.Text = "Update";
        }


        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData()) return;
                Zone ItemToAdd = null;
                using (var context = new INVENTORYEntities())
                {
                    if (ItemId != 0)
                    {
                        ItemToAdd = (from c in context.Zones
                                         where c.Id == ItemId
                                         select c).FirstOrDefault();
                    }
                    else
                    {
                        ItemToAdd = new Zone();
                    }                   
                    ItemToAdd.StoreId = Invdash.StoreId;
                    ItemToAdd.SortDescription = txttitle.Text;
                    ItemToAdd.Address = txtItemDescription.Text;
                    if (ItemId == 0)
                    {
                        context.Zones.Add(ItemToAdd);
                    }
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
            if (txttitle.Text.Trim() == "")
            {
                MessageBox.Show("Item Title is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttitle.Focus();
                return false;
            }

            if (txtItemDescription.Text.Trim() == "")
            {
                MessageBox.Show("Item Description is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemDescription.Focus();
                return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ItemId == 0) return;
            var confirm = MessageBox.Show("Are you sure to delete this item ??","Confirm Delete!!",MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var context = new INVENTORYEntities())
                    {
                        ZoneInventory zi = context.ZoneInventories.Where(c => c.ZoneId == ItemId).FirstOrDefault();
                        if (zi != null)
                        {
                            MessageBox.Show("There are items associated with Zone.. So not possible to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        var ZoneToDelete = from b in context.Zones
                                               where b.Id == ItemId
                                               select b;
                        foreach (var zonei in ZoneToDelete)
                            context.Zones.Remove(zonei);
                        context.SaveChanges();
                        bindStoreItemGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
