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
    public partial class Individuals : Form
    {
        int ItemId = 0;
        InventoryDashboard Invdash = null;
        public Individuals()
        {
            InitializeComponent();
        }

        private void Individuals_Load(object sender, EventArgs e)
        {
            try
            {
                Invdash = (InventoryDashboard)this.MdiParent;
                bindIndividualsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bindIndividualsGrid()
        {
            ItemId = 0;
            txtName.Text = "";
            lblAddEdit.Text = "Add New Individual";
            txtAddress.Text = "";
            txtidNumber.Text = "";
            txtRank.Text = "";         
            btnSaveUpdate.Text = "Save";
            btnDelete.Visible = false;
            grdItems.ReadOnly = true;
            using (var context = new INVENTORYEntities())
            {
                grdItems.DataSource = context.Individuals.Where(c => c.StoreId == Invdash.StoreId).Select(d => new
                {
                    d.Id,
                    d.Name,
                    d.IDNumber,
                    d.Rank,
                    d.Address
                }).ToList();

                grdItems.Columns["Id"].Visible = false; //make the id column 
            }

        }

        private void grdItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ItemId = (int)grdItems.Rows[e.RowIndex].Cells[0].Value;
            txtName.Text = grdItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtidNumber.Text = grdItems.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRank.Text = grdItems.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = grdItems.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblAddEdit.Text = "Update Zone";
            btnDelete.Visible = true;
            btnSaveUpdate.Text = "Update";
        }


        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData()) return;
                Individual ItemToAdd = null;
                using (var context = new INVENTORYEntities())
                {
                    if (ItemId != 0)
                    {
                        ItemToAdd = (from c in context.Individuals
                                     where c.Id == ItemId
                                     select c).FirstOrDefault();
                    }
                    else
                    {
                        ItemToAdd = new Individual();
                    }
                    ItemToAdd.StoreId = Invdash.StoreId;
                    ItemToAdd.Name = txtName.Text;
                    ItemToAdd.IDNumber = txtidNumber.Text;
                    ItemToAdd.Rank = txtRank.Text;
                    ItemToAdd.Address = txtAddress.Text;
                    if (ItemId == 0)
                    {
                        context.Individuals.Add(ItemToAdd);
                    }
                    context.SaveChanges();
                    bindIndividualsGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Individual Name is Required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (txtidNumber.Text.Trim() == "")
            {
                MessageBox.Show("ID Number is Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidNumber.Focus();
                return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ItemId == 0) return;
            var confirm = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var context = new INVENTORYEntities())
                    {
                        IndividualInventory idi = context.IndividualInventories.Where(c => c.IndividualId == ItemId).FirstOrDefault();
                        if (idi != null)
                        {
                            MessageBox.Show("There are items associated with Individual.. So not possible to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var StoreItemToDelete = from b in context.Individuals
                                                where b.Id == ItemId
                                                select b;
                        foreach (var customer in StoreItemToDelete)
                            context.Individuals.Remove(customer);
                        context.SaveChanges();
                        bindIndividualsGrid();
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
