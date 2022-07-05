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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Oracle ORA = new Oracle("myAdmin");
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (cmbHuman.Text == "Administrator")
            {
                Oracle ORA = new Oracle("myAdmin");
                ORA.User = tbUN.Text; ORA.Pass = tbPW.Text;
                ORA.LoginVerification();
                if (ORA.LoginVerification() == true) { MessageBox.Show("Correct!"); }
                else { MessageBox.Show("Wrong!"); }
            }

            else if (cmbHuman.Text == "Staff")
            {
                Oracle ORA = new Oracle("myEmployee");
                ORA.User = tbUN.Text; ORA.Pass = tbPW.Text;
                ORA.LoginVerification();
                if (ORA.LoginVerification() == true) { MessageBox.Show("Correct!"); }
                else { MessageBox.Show("Wrong!"); }
            }

            else
            {
                MessageBox.Show("Please select Type","User Notification");
            }
            
            
        }


    }
}
