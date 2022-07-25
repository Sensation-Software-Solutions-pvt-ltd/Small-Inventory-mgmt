using Inventory.Entity;
using Inventory.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Home : Form
    {
        public InventoryDashboard Invdash = null;
        private Zone selectedzone = null;
        private CBIndividual selectedInd = null;
        Subro.Controls.DataGridViewGrouper grouper = null;

        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        public Home()
        {
            InitializeComponent();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Report";
                printDocument1.Print();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            List<Zone> zn = null;
            List<CBIndividual> indlist = null;
            using (var context = new INVENTORYEntities())
            {
                zn = context.Zones.Where(c => c.StoreId == Invdash.StoreId).ToList();
                cmZones.DataSource = zn;
                cmZones.DisplayMember = "SortDescription";
                cmZones.SelectedIndex = -1;
                cmZones.Text = "All Zones";

                indlist = context.Individuals.Where(c => c.StoreId == Invdash.StoreId)
                    .Select(d => new CBIndividual()
                    {
                        Id = d.Id,
                        Name = d.Name + "(" + d.IDNumber + ")",
                        Address = d.Address
                    })
                    .ToList();
                cbIndividuals.DataSource = indlist;
                cbIndividuals.DisplayMember = "Name";
                cbIndividuals.SelectedIndex = -1;
                cbIndividuals.Text = "All Individuals";

            }

            grpZones.Enabled = false;
            grpzonetype.Enabled = false;
            grpInd.Enabled = false;
            grpIndtype.Enabled = false;
            grpstore.Enabled = true;

            BindGrid();


            txtSearchdata.KeyPress += (sndr, ev) =>
            {
                if (ev.KeyChar.Equals((char)13))
                {
                    BindGrid();
                    ev.Handled = true; // suppress default handling
                }
            };
            txtSearchdata.Focus();
        }




        private void rdTotalInv_CheckedChanged(object sender, EventArgs e)
        {
            grpZones.Enabled = false;
            grpzonetype.Enabled = false;
            grpInd.Enabled = false;
            grpIndtype.Enabled = false;
            grpstore.Enabled = true;
            cmZones.SelectedIndex = -1;
            cmZones.Text = "All Zones";
            cbIndividuals.SelectedIndex = -1;
            cbIndividuals.Text = "All Individuals";
            BindGrid();
        }

        private void rdZonesInventory_CheckedChanged(object sender, EventArgs e)
        {
            grpZones.Enabled = true;
            grpzonetype.Enabled = true;
            grpInd.Enabled = false;
            grpIndtype.Enabled = false;
            grpstore.Enabled = false;
            cbIndividuals.SelectedIndex = -1;
            cbIndividuals.Text = "All Individuals";
            BindGrid();
        }
        private void rdIndividualInventory_CheckedChanged(object sender, EventArgs e)
        {
            grpInd.Enabled = true;
            grpIndtype.Enabled = true;
            grpstore.Enabled = false;
            grpZones.Enabled = false;
            grpzonetype.Enabled = false;
            cmZones.SelectedIndex = -1;
            cmZones.Text = "All Zones";
            BindGrid();
        }
        private void cmZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedzone = (Zone)cmZones.SelectedItem;
            if (selectedzone != null)
                BindGrid();
        }

        public void BindGrid()
        {
            string searchstr = txtSearchdata.Text.Trim();
            if (grouper != null)
            {
                grouper.Dispose();
                grouper = null;
            }
            if (rdTotalInv.Checked)
            {
                #region Store Inventory:
                lblTitle.Text = Invdash.StoreTitle;
                lblAddress.Text = "( " + Invdash.StoreAddress + " )";

                using (var context = new INVENTORYEntities())
                {
                    if (rdstoreall.Checked)
                    {
                        DataGrid.DataSource = context.StoreInventories.Where(c => c.StoreId == Invdash.StoreId)
                            .Select(d => new
                            {
                                d.ItemName,
                                d.ItemDescription,
                                TotalItems = d.ItemCount,
                                d.AvailableQuantity,
                                Type = d.ItemType == 1 ? "General" : "Ammunition"
                            })
                            .Where(z=>z.ItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr))
                            .ToList();
                    }
                    else
                    {
                        int itemtype = rdstoregeneral.Checked ? 1 : 2;
                        DataGrid.DataSource = context.StoreInventories.Where(c => c.StoreId == Invdash.StoreId && c.ItemType == itemtype)
                            .Select(d => new
                            {
                                d.ItemName,
                                d.ItemDescription,
                                TotalItems = d.ItemCount,
                                d.AvailableQuantity,
                                Type = d.ItemType == 1 ? "General" : "Ammunition"
                            })
                            .Where(z => z.ItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr))
                            .ToList();
                    }

                    DataGrid.Columns["TotalItems"].HeaderText = "Total Quantity";
                    DataGrid.Columns["ItemName"].HeaderText = "Item Title";
                    DataGrid.Columns["ItemDescription"].HeaderText = "Item Description";
                    DataGrid.Columns["AvailableQuantity"].HeaderText = "Available Quantity";

                }
                #endregion
            }
            else if (rdZonesInventory.Checked)
            {
                #region Zone Inventory
                if (selectedzone == null)
                {
                    lblTitle.Text = Invdash.StoreTitle;
                    lblAddress.Text = "( " + Invdash.StoreAddress + " )";
                    using (var context = new INVENTORYEntities())
                    {
                        if (rdzoneall.Checked)
                        {
                            DataGrid.DataSource = context.ZoneInventories.Where(c => c.Zone.StoreId == Invdash.StoreId)
                                .Select(d => new
                                {
                                    ZoneName = d.Zone.SortDescription,
                                    d.ItemName,
                                    d.StoreInventory.ItemDescription,
                                    TotalItems = d.ItemCount,
                                    Type = d.StoreInventory.ItemType == 1 ? "General" : "Ammunition"
                                })
                                .Where(z => z.ItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr) || z.ZoneName.Contains(searchstr))
                                .ToList();
                        }
                        else
                        {
                            int itemtype = rdZoneGeneral.Checked ? 1 : 2;
                            DataGrid.DataSource = context.ZoneInventories.Where(c => c.Zone.StoreId == Invdash.StoreId && c.StoreInventory.ItemType == itemtype)
                                 .Select(d => new
                                 {
                                     ZoneName = d.Zone.SortDescription,
                                     d.ItemName,
                                     d.StoreInventory.ItemDescription,
                                     TotalItems = d.ItemCount,
                                     Type = d.StoreInventory.ItemType == 1 ? "General" : "Ammunition"
                                 })
                                 .Where(z => z.ItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr) || z.ZoneName.Contains(searchstr))
                                 .ToList();
                        }
                    }

                    DataGrid.Columns["ItemName"].HeaderText = "Item Title";
                    DataGrid.Columns["ItemDescription"].HeaderText = "Item Description";
                    DataGrid.Columns["TotalItems"].HeaderText = "Available Quantity";
                    grouper = new Subro.Controls.DataGridViewGrouper(DataGrid);
                    grouper.SetGroupOn("ZoneName");
                }
                else
                {
                    lblTitle.Text = selectedzone.SortDescription;
                    lblAddress.Text = "( " + selectedzone.Address + " )";

                    using (var context = new INVENTORYEntities())
                    {
                        if (rdzoneall.Checked)
                        {
                            DataGrid.DataSource = context.ZoneInventories.Where(c => c.Zone.StoreId == Invdash.StoreId && c.ZoneId == selectedzone.Id)
                                .Select(d => new
                                {
                                    d.Zone.SortDescription,
                                    d.ItemName,
                                    d.StoreInventory.ItemDescription,
                                    TotalItems = d.ItemCount,
                                    Type = d.StoreInventory.ItemType == 1 ? "General" : "Ammunition"
                                })
                                .Where(z => z.ItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr) || z.SortDescription.Contains(searchstr))
                                .ToList();
                        }
                        else
                        {
                            int itemtype = rdZoneGeneral.Checked ? 1 : 2;
                            DataGrid.DataSource = context.ZoneInventories.Where(c => c.Zone.StoreId == Invdash.StoreId && c.StoreInventory.ItemType == itemtype && c.ZoneId == selectedzone.Id)
                                 .Select(d => new
                                 {
                                     d.Zone.SortDescription,
                                     d.ItemName,
                                     d.StoreInventory.ItemDescription,
                                     TotalItems = d.ItemCount,
                                     Type = d.StoreInventory.ItemType == 1 ? "General" : "Ammunition"
                                 })
                                 .Where(z => z.ItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr) || z.SortDescription.Contains(searchstr))
                                 .ToList();
                        }
                    }
                    DataGrid.Columns["SortDescription"].HeaderText = "Zone Name";
                    DataGrid.Columns["ItemName"].HeaderText = "Item Title";
                    DataGrid.Columns["ItemDescription"].HeaderText = "Item Description";
                    DataGrid.Columns["TotalItems"].HeaderText = "Available Quantity";
                }
                #endregion
            }

            else
            {
                #region Individual Inventory
                if (selectedInd == null)
                {
                    lblTitle.Text = Invdash.StoreTitle;
                    lblAddress.Text = "( " + Invdash.StoreAddress + " )";
                    using (var context = new INVENTORYEntities())
                    {
                        if (rdIndall.Checked)
                        {
                            DataGrid.DataSource = context.IndividualInventories.Where(c => c.Individual.StoreId == Invdash.StoreId)
                                .Select(d => new
                                {
                                    Name = d.Individual.Name + "(" + d.Individual.IDNumber + ")",
                                    d.StoreItemName,
                                    d.StoreInventory.ItemDescription,
                                    TotalItems = d.ItemCount,
                                    Type = d.StoreInventory.ItemType == 1 ? "General" : "Ammunition"
                                })
                                .Where(z => z.StoreItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr) || z.Name.Contains(searchstr))
                                .ToList();
                        }
                        else
                        {
                            int itemtype = rdIndGeneral.Checked ? 1 : 2;
                            DataGrid.DataSource = context.IndividualInventories.Where(c => c.Individual.StoreId == Invdash.StoreId && c.StoreInventory.ItemType == itemtype)
                                 .Select(d => new
                                 {
                                     Name = d.Individual.Name + "(" + d.Individual.IDNumber + ")",
                                     d.StoreItemName,
                                     d.StoreInventory.ItemDescription,
                                     TotalItems = d.ItemCount,
                                     Type = d.StoreInventory.ItemType == 1 ? "General" : "Ammunition"
                                 })
                                 .Where(z => z.StoreItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr) || z.Name.Contains(searchstr))
                                 .ToList();
                        }
                    }

                    DataGrid.Columns["StoreItemName"].HeaderText = "Item Title";
                    DataGrid.Columns["ItemDescription"].HeaderText = "Item Description";
                    DataGrid.Columns["TotalItems"].HeaderText = "Available Quantity";
                    grouper = new Subro.Controls.DataGridViewGrouper(DataGrid);
                    grouper.SetGroupOn("Name");
                }
                else
                {
                    lblTitle.Text = selectedInd.Name;
                    lblAddress.Text = "( " + selectedInd.Address + " )";

                    using (var context = new INVENTORYEntities())
                    {
                        if (rdIndall.Checked)
                        {
                            DataGrid.DataSource = context.IndividualInventories.Where(c => c.Individual.StoreId == Invdash.StoreId && c.IndividualId == selectedInd.Id)
                                .Select(d => new
                                {
                                    Name = d.Individual.Name + "(" + d.Individual.IDNumber + ")",
                                    d.StoreItemName,
                                    d.StoreInventory.ItemDescription,
                                    TotalItems = d.ItemCount,
                                    Type = d.StoreInventory.ItemType == 1 ? "General" : "Ammunition"
                                })
                                .Where(z => z.StoreItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr) || z.Name.Contains(searchstr))
                                .ToList();
                        }
                        else
                        {
                            int itemtype = rdIndGeneral.Checked ? 1 : 2;
                            DataGrid.DataSource = context.IndividualInventories.Where(c => c.Individual.StoreId == Invdash.StoreId && c.StoreInventory.ItemType == itemtype && c.IndividualId == selectedInd.Id)
                                 .Select(d => new
                                 {
                                     Name = d.Individual.Name + "(" + d.Individual.IDNumber + ")",
                                     d.StoreItemName,
                                     d.StoreInventory.ItemDescription,
                                     TotalItems = d.ItemCount,
                                     Type = d.StoreInventory.ItemType == 1 ? "General" : "Ammunition"
                                 })
                                 .Where(z => z.StoreItemName.Contains(searchstr) || z.ItemDescription.Contains(searchstr) || z.Name.Contains(searchstr))
                                 .ToList();
                        }
                    }

                    DataGrid.Columns["StoreItemName"].HeaderText = "Item Title";
                    DataGrid.Columns["ItemDescription"].HeaderText = "Item Description";
                    DataGrid.Columns["TotalItems"].HeaderText = "Available Quantity";
                }
                #endregion
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void cbIndividuals_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInd = (CBIndividual)cbIndividuals.SelectedItem;
            if (selectedInd != null)
                BindGrid();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in DataGrid.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in DataGrid.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= DataGrid.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = DataGrid.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Inventory Report", new Font(DataGrid.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Inventory Report", new Font(DataGrid.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(DataGrid.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(DataGrid.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Inventory Report", new Font(new Font(DataGrid.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in DataGrid.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchdata_MouseHover(object sender, EventArgs e)
        {
            tooltipsearch.Hide(txtSearchdata);
        }

        private void txtSearchdata_MouseEnter(object sender, EventArgs e)
        {
            tooltipsearch.Show("Press \"Enter\" to search data", txtSearchdata);
        }

        private void txtSearchdata_Enter(object sender, EventArgs e)
        {
            tooltipsearch.Show("Press \"Enter\" to search data", txtSearchdata);
        }

        private void txtSearchdata_Leave(object sender, EventArgs e)
        {
            tooltipsearch.Hide(txtSearchdata);
        }
    }
}
