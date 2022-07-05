namespace FinalProjectA
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbUN = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cmbHuman = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "USERNAME";
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(227, 101);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(159, 20);
            this.tbPW.TabIndex = 14;
            // 
            // tbUN
            // 
            this.tbUN.Location = new System.Drawing.Point(227, 75);
            this.tbUN.Name = "tbUN";
            this.tbUN.Size = new System.Drawing.Size(159, 20);
            this.tbUN.TabIndex = 13;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(227, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 37);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cmbHuman
            // 
            this.cmbHuman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHuman.FormattingEnabled = true;
            this.cmbHuman.Items.AddRange(new object[] {
            "Administrator",
            "Staff"});
            this.cmbHuman.Location = new System.Drawing.Point(227, 128);
            this.cmbHuman.Name = "cmbHuman";
            this.cmbHuman.Size = new System.Drawing.Size(78, 21);
            this.cmbHuman.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 266);
            this.Controls.Add(this.cmbHuman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbUN);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbUN;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbHuman;
    }
}

