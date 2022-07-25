namespace Inventory
{
    partial class IssueItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueItem));
            this.label1 = new System.Windows.Forms.Label();
            this.cbStockItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdInd = new System.Windows.Forms.RadioButton();
            this.rdZone = new System.Windows.Forms.RadioButton();
            this.lblSuplyType = new System.Windows.Forms.Label();
            this.cbZones = new System.Windows.Forms.ComboBox();
            this.pnlZone = new System.Windows.Forms.Panel();
            this.rchtextDescriptionZone = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveZone = new System.Windows.Forms.Button();
            this.nmQuantityZone = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlInd = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rchtextDescriptionInd = new System.Windows.Forms.RichTextBox();
            this.btnSaveInd = new System.Windows.Forms.Button();
            this.nmQuantityInd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.cbIndividual = new System.Windows.Forms.ComboBox();
            this.pnlZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantityZone)).BeginInit();
            this.pnlInd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantityInd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock Item Issue";
            // 
            // cbStockItem
            // 
            this.cbStockItem.FormattingEnabled = true;
            this.cbStockItem.Location = new System.Drawing.Point(41, 68);
            this.cbStockItem.Name = "cbStockItem";
            this.cbStockItem.Size = new System.Drawing.Size(253, 21);
            this.cbStockItem.TabIndex = 5;
            this.cbStockItem.SelectedIndexChanged += new System.EventHandler(this.cbStockItem_SelectedIndexChanged);
            this.cbStockItem.TextChanged += new System.EventHandler(this.cbStockItem_TextChanged);
            this.cbStockItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbStockItem_KeyUp);
            this.cbStockItem.Leave += new System.EventHandler(this.cbStockItem_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stock Item";
            // 
            // rdInd
            // 
            this.rdInd.AutoSize = true;
            this.rdInd.Location = new System.Drawing.Point(168, 114);
            this.rdInd.Name = "rdInd";
            this.rdInd.Size = new System.Drawing.Size(121, 17);
            this.rdInd.TabIndex = 7;
            this.rdInd.Text = "Supply To Individual";
            this.rdInd.UseVisualStyleBackColor = true;
            this.rdInd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdZone
            // 
            this.rdZone.AutoSize = true;
            this.rdZone.Checked = true;
            this.rdZone.Location = new System.Drawing.Point(43, 114);
            this.rdZone.Name = "rdZone";
            this.rdZone.Size = new System.Drawing.Size(101, 17);
            this.rdZone.TabIndex = 8;
            this.rdZone.TabStop = true;
            this.rdZone.Text = "Supply To Zone";
            this.rdZone.UseVisualStyleBackColor = true;
            this.rdZone.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblSuplyType
            // 
            this.lblSuplyType.AutoSize = true;
            this.lblSuplyType.Location = new System.Drawing.Point(12, 3);
            this.lblSuplyType.Name = "lblSuplyType";
            this.lblSuplyType.Size = new System.Drawing.Size(32, 13);
            this.lblSuplyType.TabIndex = 9;
            this.lblSuplyType.Text = "Zone";
            // 
            // cbZones
            // 
            this.cbZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZones.FormattingEnabled = true;
            this.cbZones.Location = new System.Drawing.Point(12, 19);
            this.cbZones.Name = "cbZones";
            this.cbZones.Size = new System.Drawing.Size(253, 21);
            this.cbZones.TabIndex = 11;
            // 
            // pnlZone
            // 
            this.pnlZone.Controls.Add(this.rchtextDescriptionZone);
            this.pnlZone.Controls.Add(this.label8);
            this.pnlZone.Controls.Add(this.btnSaveZone);
            this.pnlZone.Controls.Add(this.nmQuantityZone);
            this.pnlZone.Controls.Add(this.label3);
            this.pnlZone.Controls.Add(this.lblSuplyType);
            this.pnlZone.Controls.Add(this.cbZones);
            this.pnlZone.Location = new System.Drawing.Point(31, 137);
            this.pnlZone.Name = "pnlZone";
            this.pnlZone.Size = new System.Drawing.Size(275, 255);
            this.pnlZone.TabIndex = 12;
            // 
            // rchtextDescriptionZone
            // 
            this.rchtextDescriptionZone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchtextDescriptionZone.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtextDescriptionZone.Location = new System.Drawing.Point(13, 112);
            this.rchtextDescriptionZone.Name = "rchtextDescriptionZone";
            this.rchtextDescriptionZone.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rchtextDescriptionZone.Size = new System.Drawing.Size(252, 96);
            this.rchtextDescriptionZone.TabIndex = 16;
            this.rchtextDescriptionZone.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Description";
            // 
            // btnSaveZone
            // 
            this.btnSaveZone.Location = new System.Drawing.Point(98, 221);
            this.btnSaveZone.Name = "btnSaveZone";
            this.btnSaveZone.Size = new System.Drawing.Size(75, 23);
            this.btnSaveZone.TabIndex = 14;
            this.btnSaveZone.Text = "Save";
            this.btnSaveZone.UseVisualStyleBackColor = true;
            this.btnSaveZone.Click += new System.EventHandler(this.btnSaveZone_Click);
            // 
            // nmQuantityZone
            // 
            this.nmQuantityZone.Location = new System.Drawing.Point(12, 63);
            this.nmQuantityZone.Name = "nmQuantityZone";
            this.nmQuantityZone.Size = new System.Drawing.Size(253, 20);
            this.nmQuantityZone.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity";
            // 
            // pnlInd
            // 
            this.pnlInd.Controls.Add(this.cbIndividual);
            this.pnlInd.Controls.Add(this.label7);
            this.pnlInd.Controls.Add(this.rchtextDescriptionInd);
            this.pnlInd.Controls.Add(this.btnSaveInd);
            this.pnlInd.Controls.Add(this.nmQuantityInd);
            this.pnlInd.Controls.Add(this.label6);
            this.pnlInd.Controls.Add(this.label4);
            this.pnlInd.Location = new System.Drawing.Point(31, 136);
            this.pnlInd.Name = "pnlInd";
            this.pnlInd.Size = new System.Drawing.Size(275, 245);
            this.pnlInd.TabIndex = 13;
            this.pnlInd.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Description";
            // 
            // rchtextDescriptionInd
            // 
            this.rchtextDescriptionInd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchtextDescriptionInd.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtextDescriptionInd.Location = new System.Drawing.Point(15, 116);
            this.rchtextDescriptionInd.Name = "rchtextDescriptionInd";
            this.rchtextDescriptionInd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rchtextDescriptionInd.Size = new System.Drawing.Size(250, 72);
            this.rchtextDescriptionInd.TabIndex = 17;
            this.rchtextDescriptionInd.Text = "";
            // 
            // btnSaveInd
            // 
            this.btnSaveInd.Location = new System.Drawing.Point(98, 205);
            this.btnSaveInd.Name = "btnSaveInd";
            this.btnSaveInd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInd.TabIndex = 16;
            this.btnSaveInd.Text = "Save";
            this.btnSaveInd.UseVisualStyleBackColor = true;
            this.btnSaveInd.Click += new System.EventHandler(this.btnSaveInd_Click);
            // 
            // nmQuantityInd
            // 
            this.nmQuantityInd.Location = new System.Drawing.Point(12, 66);
            this.nmQuantityInd.Name = "nmQuantityInd";
            this.nmQuantityInd.Size = new System.Drawing.Size(253, 20);
            this.nmQuantityInd.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Green;
            this.lblQty.Location = new System.Drawing.Point(41, 93);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(41, 15);
            this.lblQty.TabIndex = 14;
            this.lblQty.Text = "label9";
            // 
            // cbIndividual
            // 
            this.cbIndividual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndividual.FormattingEnabled = true;
            this.cbIndividual.Location = new System.Drawing.Point(12, 20);
            this.cbIndividual.Name = "cbIndividual";
            this.cbIndividual.Size = new System.Drawing.Size(253, 21);
            this.cbIndividual.TabIndex = 19;
            // 
            // IssueItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 444);
            this.Controls.Add(this.pnlInd);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.pnlZone);
            this.Controls.Add(this.rdZone);
            this.Controls.Add(this.rdInd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStockItem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 483);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(364, 483);
            this.Name = "IssueItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Issue";
            this.Load += new System.EventHandler(this.NoSupplyDates_Load);
            this.pnlZone.ResumeLayout(false);
            this.pnlZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantityZone)).EndInit();
            this.pnlInd.ResumeLayout(false);
            this.pnlInd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantityInd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStockItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdInd;
        private System.Windows.Forms.RadioButton rdZone;
        private System.Windows.Forms.Label lblSuplyType;
        private System.Windows.Forms.ComboBox cbZones;
        private System.Windows.Forms.Panel pnlZone;
        private System.Windows.Forms.NumericUpDown nmQuantityZone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveZone;
        private System.Windows.Forms.Panel pnlInd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmQuantityInd;
        private System.Windows.Forms.Button btnSaveInd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchtextDescriptionInd;
        private System.Windows.Forms.RichTextBox rchtextDescriptionZone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ComboBox cbIndividual;
    }
}