namespace Inventory
{
    partial class InventoryDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryDashboard));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnZones = new System.Windows.Forms.ToolStripMenuItem();
            this.masterSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSuplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceiveItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.individualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.mnZones,
            this.individualsToolStripMenuItem,
            this.masterSettingsToolStripMenuItem,
            this.manualEntryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(837, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // mnZones
            // 
            this.mnZones.Name = "mnZones";
            this.mnZones.Size = new System.Drawing.Size(51, 20);
            this.mnZones.Text = "Zones";
            this.mnZones.Click += new System.EventHandler(this.mnZones_Click);
            // 
            // masterSettingsToolStripMenuItem
            // 
            this.masterSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem});
            this.masterSettingsToolStripMenuItem.Name = "masterSettingsToolStripMenuItem";
            this.masterSettingsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.masterSettingsToolStripMenuItem.Text = "Inventory";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.newItemToolStripMenuItem.Text = "New Item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.masterSettingsToolStripMenuItem_Click);
            // 
            // manualEntryToolStripMenuItem
            // 
            this.manualEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualSuplyToolStripMenuItem,
            this.ReceiveItemToolStripMenuItem,
            this.profitLossToolStripMenuItem,
            this.transactionReportsToolStripMenuItem});
            this.manualEntryToolStripMenuItem.Name = "manualEntryToolStripMenuItem";
            this.manualEntryToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.manualEntryToolStripMenuItem.Text = "Transactions";
            // 
            // manualSuplyToolStripMenuItem
            // 
            this.manualSuplyToolStripMenuItem.Name = "manualSuplyToolStripMenuItem";
            this.manualSuplyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.manualSuplyToolStripMenuItem.Text = "Issue Item";
            this.manualSuplyToolStripMenuItem.Click += new System.EventHandler(this.manualSuplyToolStripMenuItem_Click);
            // 
            // ReceiveItemToolStripMenuItem
            // 
            this.ReceiveItemToolStripMenuItem.Name = "ReceiveItemToolStripMenuItem";
            this.ReceiveItemToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ReceiveItemToolStripMenuItem.Text = "Receive Item";
            this.ReceiveItemToolStripMenuItem.Click += new System.EventHandler(this.ReceiveItemToolStripMenuItem_Click);
            // 
            // profitLossToolStripMenuItem
            // 
            this.profitLossToolStripMenuItem.Name = "profitLossToolStripMenuItem";
            this.profitLossToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.profitLossToolStripMenuItem.Text = "Dispose";
            // 
            // transactionReportsToolStripMenuItem
            // 
            this.transactionReportsToolStripMenuItem.Name = "transactionReportsToolStripMenuItem";
            this.transactionReportsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.transactionReportsToolStripMenuItem.Text = "Transaction Reports";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 519);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(837, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // individualsToolStripMenuItem
            // 
            this.individualsToolStripMenuItem.Name = "individualsToolStripMenuItem";
            this.individualsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.individualsToolStripMenuItem.Text = "Individuals";
            this.individualsToolStripMenuItem.Click += new System.EventHandler(this.individualsToolStripMenuItem_Click);
            // 
            // InventoryDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(837, 541);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.MinimumSize = new System.Drawing.Size(853, 580);
            this.Name = "InventoryDashboard";
            this.Text = "Store Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryDashboard_FormClosed);
            this.Load += new System.EventHandler(this.InventoryDashboard_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnZones;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualSuplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReceiveItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualsToolStripMenuItem;
    }
}



