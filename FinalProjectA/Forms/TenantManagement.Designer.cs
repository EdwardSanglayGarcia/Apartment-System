namespace FinalProjectA
{
    partial class TenantManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbRM = new System.Windows.Forms.ComboBox();
            this.cmbFL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.tbCN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overallRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.occupiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTenantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 374);
            this.dataGridView1.TabIndex = 69;
            // 
            // cmbRM
            // 
            this.cmbRM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRM.FormattingEnabled = true;
            this.cmbRM.Location = new System.Drawing.Point(125, 34);
            this.cmbRM.Name = "cmbRM";
            this.cmbRM.Size = new System.Drawing.Size(59, 21);
            this.cmbRM.TabIndex = 68;
            this.cmbRM.SelectedIndexChanged += new System.EventHandler(this.cmbRM_SelectedIndexChanged);
            // 
            // cmbFL
            // 
            this.cmbFL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFL.FormattingEnabled = true;
            this.cmbFL.Items.AddRange(new object[] {
            "Floor 1",
            "Floor 2",
            "Floor 3",
            "Floor 4"});
            this.cmbFL.Location = new System.Drawing.Point(57, 34);
            this.cmbFL.Name = "cmbFL";
            this.cmbFL.Size = new System.Drawing.Size(59, 21);
            this.cmbFL.TabIndex = 67;
            this.cmbFL.SelectedIndexChanged += new System.EventHandler(this.cmbFL_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Contact #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "First Name";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Studio",
            "1 Bedroom",
            "2 Bedroom",
            "3 Bedroom",
            "Penthouse",
            "Suite"});
            this.cmbType.Location = new System.Drawing.Point(60, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(124, 21);
            this.cmbType.TabIndex = 61;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(254, 35);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(124, 20);
            this.tbLN.TabIndex = 60;
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(254, 5);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(124, 20);
            this.tbFN.TabIndex = 59;
            // 
            // tbCN
            // 
            this.tbCN.Location = new System.Drawing.Point(447, 5);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(124, 20);
            this.tbCN.TabIndex = 57;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 76;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTenantsToolStripMenuItem,
            this.deleteTenantToolStripMenuItem,
            this.updateTenantToolStripMenuItem1,
            this.addTenantToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // viewTenantsToolStripMenuItem
            // 
            this.viewTenantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perFloorToolStripMenuItem,
            this.perTypeToolStripMenuItem,
            this.overallRecordsToolStripMenuItem,
            this.availableToolStripMenuItem,
            this.occupiedToolStripMenuItem});
            this.viewTenantsToolStripMenuItem.Name = "viewTenantsToolStripMenuItem";
            this.viewTenantsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewTenantsToolStripMenuItem.Text = "View Tenants";
            // 
            // perFloorToolStripMenuItem
            // 
            this.perFloorToolStripMenuItem.Name = "perFloorToolStripMenuItem";
            this.perFloorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perFloorToolStripMenuItem.Text = "Per Floor";
            this.perFloorToolStripMenuItem.Click += new System.EventHandler(this.perFloorToolStripMenuItem_Click);
            // 
            // perTypeToolStripMenuItem
            // 
            this.perTypeToolStripMenuItem.Name = "perTypeToolStripMenuItem";
            this.perTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perTypeToolStripMenuItem.Text = "Per Type";
            this.perTypeToolStripMenuItem.Click += new System.EventHandler(this.perTypeToolStripMenuItem_Click);
            // 
            // overallRecordsToolStripMenuItem
            // 
            this.overallRecordsToolStripMenuItem.Name = "overallRecordsToolStripMenuItem";
            this.overallRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.overallRecordsToolStripMenuItem.Text = "Overall Records";
            this.overallRecordsToolStripMenuItem.Click += new System.EventHandler(this.overallRecordsToolStripMenuItem_Click);
            // 
            // availableToolStripMenuItem
            // 
            this.availableToolStripMenuItem.Name = "availableToolStripMenuItem";
            this.availableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.availableToolStripMenuItem.Text = "Available";
            this.availableToolStripMenuItem.Click += new System.EventHandler(this.availableToolStripMenuItem_Click);
            // 
            // occupiedToolStripMenuItem
            // 
            this.occupiedToolStripMenuItem.Name = "occupiedToolStripMenuItem";
            this.occupiedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.occupiedToolStripMenuItem.Text = "Occupied";
            this.occupiedToolStripMenuItem.Click += new System.EventHandler(this.occupiedToolStripMenuItem_Click);
            // 
            // deleteTenantToolStripMenuItem
            // 
            this.deleteTenantToolStripMenuItem.Name = "deleteTenantToolStripMenuItem";
            this.deleteTenantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteTenantToolStripMenuItem.Text = "Delete Tenant";
            this.deleteTenantToolStripMenuItem.Click += new System.EventHandler(this.deleteTenantToolStripMenuItem_Click);
            // 
            // updateTenantToolStripMenuItem1
            // 
            this.updateTenantToolStripMenuItem1.Name = "updateTenantToolStripMenuItem1";
            this.updateTenantToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.updateTenantToolStripMenuItem1.Text = "Update Tenant";
            this.updateTenantToolStripMenuItem1.Click += new System.EventHandler(this.updateTenantToolStripMenuItem1_Click);
            // 
            // addTenantToolStripMenuItem
            // 
            this.addTenantToolStripMenuItem.Name = "addTenantToolStripMenuItem";
            this.addTenantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTenantToolStripMenuItem.Text = "Add Tenant";
            this.addTenantToolStripMenuItem.Click += new System.EventHandler(this.addTenantToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbFL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbCN);
            this.panel1.Controls.Add(this.cmbRM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbLN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbFN);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 64);
            this.panel1.TabIndex = 77;
            // 
            // TenantManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TenantManagement";
            this.Text = "TenantManagement";
            this.Load += new System.EventHandler(this.TenantManagement_Load);
            this.MouseHover += new System.EventHandler(this.TenantManagement_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbRM;
        private System.Windows.Forms.ComboBox cmbFL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.TextBox tbCN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTenantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perFloorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overallRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTenantToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem availableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem occupiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTenantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTenantToolStripMenuItem;
    }
}