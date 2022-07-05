using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ProjectClass;

namespace FinalProjectA
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            label5.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbPW.Text == tbPW2.Text)
            {
                Oracle ORA = new Oracle("myEmployee");
                ORA.ID = tbID.Text; ORA.FN = tbFN.Text; ORA.LN = tbLN.Text; ORA.UN = tbUN.Text; ORA.PW = tbPW.Text;
                ORA.CreatorS();
                ORA.EndDisplay();
                MessageBox.Show("Success");
            }

            else
            {
                label5.Show();
                label5.Text = "Password Mismatch";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("myEmployee");
            ORA.Query = "myEmployee";
            ORA.ID = tbDel.Text;
            ORA.Delete();
            ORA.EndDisplay();
            MessageBox.Show("Success");
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == tbPassC.Text)
            {
                Oracle ORA = new Oracle("myEmployee");
                ORA.Query = "myEmployee";
                ORA.ID = tbPassID.Text;
                ORA.PW = tbPass.Text;
                ORA.Update();
                ORA.EndDisplay();
                MessageBox.Show("Success");
            }

            else
            {
                MessageBox.Show("Both Passwords should be the same","User Notfication");
            }
        }
    }
}
