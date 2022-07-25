namespace Inventory
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchdata = new System.Windows.Forms.TextBox();
            this.grpInd = new System.Windows.Forms.GroupBox();
            this.cbIndividuals = new System.Windows.Forms.ComboBox();
            this.rdIndividualInventory = new System.Windows.Forms.RadioButton();
            this.grpIndtype = new System.Windows.Forms.GroupBox();
            this.rdIndammunition = new System.Windows.Forms.RadioButton();
            this.rdIndGeneral = new System.Windows.Forms.RadioButton();
            this.rdIndall = new System.Windows.Forms.RadioButton();
            this.grpZones = new System.Windows.Forms.GroupBox();
            this.cmZones = new System.Windows.Forms.ComboBox();
            this.rdZonesInventory = new System.Windows.Forms.RadioButton();
            this.rdTotalInv = new System.Windows.Forms.RadioButton();
            this.grpstore = new System.Windows.Forms.GroupBox();
            this.rdstoreammunition = new System.Windows.Forms.RadioButton();
            this.rdstoregeneral = new System.Windows.Forms.RadioButton();
            this.rdstoreall = new System.Windows.Forms.RadioButton();
            this.grpzonetype = new System.Windows.Forms.GroupBox();
            this.rdZoneammunition = new System.Windows.Forms.RadioButton();
            this.rdZoneGeneral = new System.Windows.Forms.RadioButton();
            this.rdzoneall = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tblreportdata = new System.Windows.Forms.TableLayoutPanel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tooltipsearch = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpInd.SuspendLayout();
            this.grpIndtype.SuspendLayout();
            this.grpZones.SuspendLayout();
            this.grpstore.SuspendLayout();
            this.grpzonetype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.tblreportdata.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(23, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer5);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel2.Controls.Add(this.tblreportdata);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(807, 494);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(10, 10);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.AutoScroll = true;
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer5.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer5.Panel2.Controls.Add(this.grpInd);
            this.splitContainer5.Panel2.Controls.Add(this.rdIndividualInventory);
            this.splitContainer5.Panel2.Controls.Add(this.grpIndtype);
            this.splitContainer5.Panel2.Controls.Add(this.grpZones);
            this.splitContainer5.Panel2.Controls.Add(this.rdZonesInventory);
            this.splitContainer5.Panel2.Controls.Add(this.rdTotalInv);
            this.splitContainer5.Panel2.Controls.Add(this.grpstore);
            this.splitContainer5.Panel2.Controls.Add(this.grpzonetype);
            this.splitContainer5.Size = new System.Drawing.Size(247, 472);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 2;
            this.splitContainer5.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Your Inventory data";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchdata);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 48);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtSearchdata
            // 
            this.txtSearchdata.Location = new System.Drawing.Point(8, 18);
            this.txtSearchdata.Name = "txtSearchdata";
            this.txtSearchdata.Size = new System.Drawing.Size(200, 20);
            this.txtSearchdata.TabIndex = 0;
            this.txtSearchdata.Enter += new System.EventHandler(this.txtSearchdata_Enter);
            this.txtSearchdata.Leave += new System.EventHandler(this.txtSearchdata_Leave);
            this.txtSearchdata.MouseEnter += new System.EventHandler(this.txtSearchdata_MouseEnter);
            this.txtSearchdata.MouseHover += new System.EventHandler(this.txtSearchdata_MouseHover);
            // 
            // grpInd
            // 
            this.grpInd.Controls.Add(this.cbIndividuals);
            this.grpInd.Location = new System.Drawing.Point(17, 278);
            this.grpInd.Name = "grpInd";
            this.grpInd.Size = new System.Drawing.Size(218, 45);
            this.grpInd.TabIndex = 11;
            this.grpInd.TabStop = false;
            this.grpInd.Text = "Select Individual";
            // 
            // cbIndividuals
            // 
            this.cbIndividuals.FormattingEnabled = true;
            this.cbIndividuals.Location = new System.Drawing.Point(6, 17);
            this.cbIndividuals.Name = "cbIndividuals";
            this.cbIndividuals.Size = new System.Drawing.Size(202, 21);
            this.cbIndividuals.TabIndex = 11;
            this.cbIndividuals.SelectedIndexChanged += new System.EventHandler(this.cbIndividuals_SelectedIndexChanged);
            // 
            // rdIndividualInventory
            // 
            this.rdIndividualInventory.AutoSize = true;
            this.rdIndividualInventory.Location = new System.Drawing.Point(9, 258);
            this.rdIndividualInventory.Name = "rdIndividualInventory";
            this.rdIndividualInventory.Size = new System.Drawing.Size(182, 17);
            this.rdIndividualInventory.TabIndex = 10;
            this.rdIndividualInventory.TabStop = true;
            this.rdIndividualInventory.Text = "Inventory Available by Individuals";
            this.rdIndividualInventory.UseVisualStyleBackColor = true;
            this.rdIndividualInventory.CheckedChanged += new System.EventHandler(this.rdIndividualInventory_CheckedChanged);
            // 
            // grpIndtype
            // 
            this.grpIndtype.Controls.Add(this.rdIndammunition);
            this.grpIndtype.Controls.Add(this.rdIndGeneral);
            this.grpIndtype.Controls.Add(this.rdIndall);
            this.grpIndtype.Location = new System.Drawing.Point(17, 325);
            this.grpIndtype.Name = "grpIndtype";
            this.grpIndtype.Size = new System.Drawing.Size(218, 47);
            this.grpIndtype.TabIndex = 10;
            this.grpIndtype.TabStop = false;
            this.grpIndtype.Text = "Item Type";
            // 
            // rdIndammunition
            // 
            this.rdIndammunition.AutoSize = true;
            this.rdIndammunition.Location = new System.Drawing.Point(129, 19);
            this.rdIndammunition.Name = "rdIndammunition";
            this.rdIndammunition.Size = new System.Drawing.Size(79, 17);
            this.rdIndammunition.TabIndex = 14;
            this.rdIndammunition.Text = "Ammunition";
            this.rdIndammunition.UseVisualStyleBackColor = true;
            this.rdIndammunition.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdIndGeneral
            // 
            this.rdIndGeneral.AutoSize = true;
            this.rdIndGeneral.Location = new System.Drawing.Point(61, 19);
            this.rdIndGeneral.Name = "rdIndGeneral";
            this.rdIndGeneral.Size = new System.Drawing.Size(62, 17);
            this.rdIndGeneral.TabIndex = 13;
            this.rdIndGeneral.Text = "General";
            this.rdIndGeneral.UseVisualStyleBackColor = true;
            this.rdIndGeneral.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdIndall
            // 
            this.rdIndall.AutoSize = true;
            this.rdIndall.Checked = true;
            this.rdIndall.Location = new System.Drawing.Point(8, 19);
            this.rdIndall.Name = "rdIndall";
            this.rdIndall.Size = new System.Drawing.Size(47, 17);
            this.rdIndall.TabIndex = 12;
            this.rdIndall.TabStop = true;
            this.rdIndall.Text = "Both";
            this.rdIndall.UseVisualStyleBackColor = true;
            this.rdIndall.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // grpZones
            // 
            this.grpZones.Controls.Add(this.cmZones);
            this.grpZones.Location = new System.Drawing.Point(17, 152);
            this.grpZones.Name = "grpZones";
            this.grpZones.Size = new System.Drawing.Size(218, 45);
            this.grpZones.TabIndex = 8;
            this.grpZones.TabStop = false;
            this.grpZones.Text = "Select Zone";
            // 
            // cmZones
            // 
            this.cmZones.FormattingEnabled = true;
            this.cmZones.Location = new System.Drawing.Point(6, 17);
            this.cmZones.Name = "cmZones";
            this.cmZones.Size = new System.Drawing.Size(202, 21);
            this.cmZones.TabIndex = 6;
            this.cmZones.SelectedIndexChanged += new System.EventHandler(this.cmZones_SelectedIndexChanged);
            // 
            // rdZonesInventory
            // 
            this.rdZonesInventory.AutoSize = true;
            this.rdZonesInventory.Location = new System.Drawing.Point(9, 132);
            this.rdZonesInventory.Name = "rdZonesInventory";
            this.rdZonesInventory.Size = new System.Drawing.Size(162, 17);
            this.rdZonesInventory.TabIndex = 5;
            this.rdZonesInventory.TabStop = true;
            this.rdZonesInventory.Text = "Inventory Available by Zones";
            this.rdZonesInventory.UseVisualStyleBackColor = true;
            this.rdZonesInventory.CheckedChanged += new System.EventHandler(this.rdZonesInventory_CheckedChanged);
            // 
            // rdTotalInv
            // 
            this.rdTotalInv.AutoSize = true;
            this.rdTotalInv.Checked = true;
            this.rdTotalInv.Location = new System.Drawing.Point(9, 63);
            this.rdTotalInv.Name = "rdTotalInv";
            this.rdTotalInv.Size = new System.Drawing.Size(182, 17);
            this.rdTotalInv.TabIndex = 2;
            this.rdTotalInv.TabStop = true;
            this.rdTotalInv.Text = "Total Available Inventory at Store";
            this.rdTotalInv.UseVisualStyleBackColor = true;
            this.rdTotalInv.CheckedChanged += new System.EventHandler(this.rdTotalInv_CheckedChanged);
            // 
            // grpstore
            // 
            this.grpstore.Controls.Add(this.rdstoreammunition);
            this.grpstore.Controls.Add(this.rdstoregeneral);
            this.grpstore.Controls.Add(this.rdstoreall);
            this.grpstore.Location = new System.Drawing.Point(17, 79);
            this.grpstore.Name = "grpstore";
            this.grpstore.Size = new System.Drawing.Size(218, 44);
            this.grpstore.TabIndex = 6;
            this.grpstore.TabStop = false;
            this.grpstore.Text = "Item Type";
            // 
            // rdstoreammunition
            // 
            this.rdstoreammunition.AutoSize = true;
            this.rdstoreammunition.Location = new System.Drawing.Point(129, 20);
            this.rdstoreammunition.Name = "rdstoreammunition";
            this.rdstoreammunition.Size = new System.Drawing.Size(79, 17);
            this.rdstoreammunition.TabIndex = 5;
            this.rdstoreammunition.Text = "Ammunition";
            this.rdstoreammunition.UseVisualStyleBackColor = true;
            this.rdstoreammunition.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdstoregeneral
            // 
            this.rdstoregeneral.AutoSize = true;
            this.rdstoregeneral.Location = new System.Drawing.Point(61, 20);
            this.rdstoregeneral.Name = "rdstoregeneral";
            this.rdstoregeneral.Size = new System.Drawing.Size(62, 17);
            this.rdstoregeneral.TabIndex = 4;
            this.rdstoregeneral.Text = "General";
            this.rdstoregeneral.UseVisualStyleBackColor = true;
            this.rdstoregeneral.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdstoreall
            // 
            this.rdstoreall.AutoSize = true;
            this.rdstoreall.Checked = true;
            this.rdstoreall.Location = new System.Drawing.Point(8, 20);
            this.rdstoreall.Name = "rdstoreall";
            this.rdstoreall.Size = new System.Drawing.Size(47, 17);
            this.rdstoreall.TabIndex = 3;
            this.rdstoreall.TabStop = true;
            this.rdstoreall.Text = "Both";
            this.rdstoreall.UseVisualStyleBackColor = true;
            this.rdstoreall.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // grpzonetype
            // 
            this.grpzonetype.Controls.Add(this.rdZoneammunition);
            this.grpzonetype.Controls.Add(this.rdZoneGeneral);
            this.grpzonetype.Controls.Add(this.rdzoneall);
            this.grpzonetype.Location = new System.Drawing.Point(17, 199);
            this.grpzonetype.Name = "grpzonetype";
            this.grpzonetype.Size = new System.Drawing.Size(218, 47);
            this.grpzonetype.TabIndex = 7;
            this.grpzonetype.TabStop = false;
            this.grpzonetype.Text = "Item Type";
            // 
            // rdZoneammunition
            // 
            this.rdZoneammunition.AutoSize = true;
            this.rdZoneammunition.Location = new System.Drawing.Point(129, 19);
            this.rdZoneammunition.Name = "rdZoneammunition";
            this.rdZoneammunition.Size = new System.Drawing.Size(79, 17);
            this.rdZoneammunition.TabIndex = 9;
            this.rdZoneammunition.Text = "Ammunition";
            this.rdZoneammunition.UseVisualStyleBackColor = true;
            this.rdZoneammunition.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdZoneGeneral
            // 
            this.rdZoneGeneral.AutoSize = true;
            this.rdZoneGeneral.Location = new System.Drawing.Point(61, 19);
            this.rdZoneGeneral.Name = "rdZoneGeneral";
            this.rdZoneGeneral.Size = new System.Drawing.Size(62, 17);
            this.rdZoneGeneral.TabIndex = 8;
            this.rdZoneGeneral.Text = "General";
            this.rdZoneGeneral.UseVisualStyleBackColor = true;
            this.rdZoneGeneral.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdzoneall
            // 
            this.rdzoneall.AutoSize = true;
            this.rdzoneall.Checked = true;
            this.rdzoneall.Location = new System.Drawing.Point(8, 19);
            this.rdzoneall.Name = "rdzoneall";
            this.rdzoneall.Size = new System.Drawing.Size(47, 17);
            this.rdzoneall.TabIndex = 7;
            this.rdzoneall.TabStop = true;
            this.rdzoneall.Text = "Both";
            this.rdzoneall.UseVisualStyleBackColor = true;
            this.rdzoneall.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Inventory Data";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(853, 33);
            this.splitContainer2.SplitterDistance = 375;
            this.splitContainer2.TabIndex = 3;
            this.splitContainer2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.btnPrint, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(474, 33);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrint.Location = new System.Drawing.Point(356, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(3, 49);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.Size = new System.Drawing.Size(506, 420);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblTitle.Size = new System.Drawing.Size(506, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Main Store Hamirpur";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 21);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(506, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Main Store Hamirpur";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblreportdata
            // 
            this.tblreportdata.ColumnCount = 1;
            this.tblreportdata.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblreportdata.Controls.Add(this.lblAddress, 0, 1);
            this.tblreportdata.Controls.Add(this.lblTitle, 0, 0);
            this.tblreportdata.Controls.Add(this.DataGrid, 0, 2);
            this.tblreportdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblreportdata.Location = new System.Drawing.Point(10, 10);
            this.tblreportdata.Name = "tblreportdata";
            this.tblreportdata.RowCount = 3;
            this.tblreportdata.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblreportdata.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblreportdata.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblreportdata.Size = new System.Drawing.Size(512, 472);
            this.tblreportdata.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tooltipsearch
            // 
            this.tooltipsearch.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltipsearch.ToolTipTitle = "Info";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(853, 550);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpInd.ResumeLayout(false);
            this.grpIndtype.ResumeLayout(false);
            this.grpIndtype.PerformLayout();
            this.grpZones.ResumeLayout(false);
            this.grpstore.ResumeLayout(false);
            this.grpstore.PerformLayout();
            this.grpzonetype.ResumeLayout(false);
            this.grpzonetype.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.tblreportdata.ResumeLayout(false);
            this.tblreportdata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.RadioButton rdZonesInventory;
        private System.Windows.Forms.RadioButton rdTotalInv;
        private System.Windows.Forms.GroupBox grpstore;
        private System.Windows.Forms.RadioButton rdstoreammunition;
        private System.Windows.Forms.RadioButton rdstoregeneral;
        private System.Windows.Forms.RadioButton rdstoreall;
        private System.Windows.Forms.GroupBox grpzonetype;
        private System.Windows.Forms.RadioButton rdZoneammunition;
        private System.Windows.Forms.RadioButton rdZoneGeneral;
        private System.Windows.Forms.RadioButton rdzoneall;
        private System.Windows.Forms.GroupBox grpZones;
        private System.Windows.Forms.ComboBox cmZones;
        private System.Windows.Forms.GroupBox grpInd;
        private System.Windows.Forms.ComboBox cbIndividuals;
        private System.Windows.Forms.RadioButton rdIndividualInventory;
        private System.Windows.Forms.GroupBox grpIndtype;
        private System.Windows.Forms.RadioButton rdIndammunition;
        private System.Windows.Forms.RadioButton rdIndGeneral;
        private System.Windows.Forms.RadioButton rdIndall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchdata;
        private System.Windows.Forms.TableLayoutPanel tblreportdata;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolTip tooltipsearch;
    }
}