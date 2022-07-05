namespace FinalProjectA
{
    partial class Reservation
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFL = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.tbCN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbRM = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overallReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOverdueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOverdueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOverdueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Type";
            // 
            // cmbFL
            // 
            this.cmbFL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFL.FormattingEnabled = true;
            this.cmbFL.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbFL.Location = new System.Drawing.Point(60, 34);
            this.cmbFL.Name = "cmbFL";
            this.cmbFL.Size = new System.Drawing.Size(59, 21);
            this.cmbFL.TabIndex = 100;
            this.cmbFL.SelectedIndexChanged += new System.EventHandler(this.cmbFL_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Contact #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 96;
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
            this.cmbType.TabIndex = 95;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(254, 35);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(124, 20);
            this.tbLN.TabIndex = 94;
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(253, 5);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(124, 20);
            this.tbFN.TabIndex = 93;
            // 
            // tbCN
            // 
            this.tbCN.Location = new System.Drawing.Point(443, 5);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(124, 20);
            this.tbCN.TabIndex = 92;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 325);
            this.dataGridView1.TabIndex = 106;
            // 
            // cmbRM
            // 
            this.cmbRM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRM.FormattingEnabled = true;
            this.cmbRM.Location = new System.Drawing.Point(125, 34);
            this.cmbRM.Name = "cmbRM";
            this.cmbRM.Size = new System.Drawing.Size(59, 21);
            this.cmbRM.TabIndex = 107;
            this.cmbRM.SelectedIndexChanged += new System.EventHandler(this.cmbRM_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbRM);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbCN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbLN);
            this.panel1.Controls.Add(this.cmbFL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbFN);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 64);
            this.panel1.TabIndex = 108;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 109;
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
            this.viewReservationToolStripMenuItem,
            this.addReservationToolStripMenuItem,
            this.deleteReservationToolStripMenuItem,
            this.viewOverdueToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // viewReservationToolStripMenuItem
            // 
            this.viewReservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perFloorToolStripMenuItem,
            this.perTypeToolStripMenuItem,
            this.overallReservationToolStripMenuItem});
            this.viewReservationToolStripMenuItem.Name = "viewReservationToolStripMenuItem";
            this.viewReservationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.viewReservationToolStripMenuItem.Text = "View Reservation";
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
            // overallReservationToolStripMenuItem
            // 
            this.overallReservationToolStripMenuItem.Name = "overallReservationToolStripMenuItem";
            this.overallReservationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.overallReservationToolStripMenuItem.Text = "Overall Reservation";
            this.overallReservationToolStripMenuItem.Click += new System.EventHandler(this.overallReservationToolStripMenuItem_Click);
            // 
            // addReservationToolStripMenuItem
            // 
            this.addReservationToolStripMenuItem.Name = "addReservationToolStripMenuItem";
            this.addReservationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addReservationToolStripMenuItem.Text = "Add Reservation";
            this.addReservationToolStripMenuItem.Click += new System.EventHandler(this.addReservationToolStripMenuItem_Click);
            // 
            // deleteReservationToolStripMenuItem
            // 
            this.deleteReservationToolStripMenuItem.Name = "deleteReservationToolStripMenuItem";
            this.deleteReservationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deleteReservationToolStripMenuItem.Text = "Delete Reservation";
            this.deleteReservationToolStripMenuItem.Click += new System.EventHandler(this.deleteReservationToolStripMenuItem_Click);
            // 
            // viewOverdueToolStripMenuItem
            // 
            this.viewOverdueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOverdueToolStripMenuItem1,
            this.deleteOverdueToolStripMenuItem1});
            this.viewOverdueToolStripMenuItem.Name = "viewOverdueToolStripMenuItem";
            this.viewOverdueToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.viewOverdueToolStripMenuItem.Text = "Overdue Management";
            // 
            // viewOverdueToolStripMenuItem1
            // 
            this.viewOverdueToolStripMenuItem1.Name = "viewOverdueToolStripMenuItem1";
            this.viewOverdueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viewOverdueToolStripMenuItem1.Text = "View Overdue";
            this.viewOverdueToolStripMenuItem1.Click += new System.EventHandler(this.viewOverdueToolStripMenuItem1_Click);
            // 
            // deleteOverdueToolStripMenuItem1
            // 
            this.deleteOverdueToolStripMenuItem1.Name = "deleteOverdueToolStripMenuItem1";
            this.deleteOverdueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteOverdueToolStripMenuItem1.Text = "Delete Overdue";
            this.deleteOverdueToolStripMenuItem1.Click += new System.EventHandler(this.deleteOverdueToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.TextBox tbCN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbRM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perFloorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOverdueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOverdueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteOverdueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem overallReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}