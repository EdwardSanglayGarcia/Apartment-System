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
using FinalProjectT1;
using ProjectClass;

namespace FinalProjectA
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        double x;
         int d, m, y, r;
            string D_R, D_D;

        private void deleteReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("RESERVES");
            ORA.Room = cmbRM.Text;
            ORA.DeleteReserve();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
            overallReservationToolStripMenuItem_Click(null, null);
        }

        private void viewOverdueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("reserves");
            ORA.ViewOverdue();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            tbCN.Clear();
            tbFN.Clear();
            tbLN.Clear();
        }

        private void perFloorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("reserves");
            ORA.Fl = cmbFL.Text;
            ORA.FloorReserveConditions();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }

        private void perTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("reserves");
            ORA.Type = cmbType.Text;
            ORA.TypeReserveConditions();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }

        private void cmbRM_SelectedIndexChanged(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider =MSDAORA;Data Source=XE;User ID=EDWARDORA;Password=ragnarok;Unicode=True");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from RESERVES where ROOM='" + cmbRM.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                tbFN.Text = dr["FIRST_NAME"].ToString();
                tbLN.Text = dr["LAST_NAME"].ToString();
                tbCN.Text = dr["CONTACT_NO"].ToString();
            }
            con.Close();
        }

        private void deleteOverdueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("RESERVES");
            ORA.Room = cmbRM.Text;
            ORA.DeleteOverdue();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
            overallReservationToolStripMenuItem_Click(null, null);
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            d = DateTime.Now.Day; m = DateTime.Now.Month;y = DateTime.Now.Year;
            string date = System.DateTime.Today.ToString("dd/MM/yy");
            r = d + 10; D_R = y + "/" + m + "/" + d; D_D = y + "/" + m + "/" + r;
            Oracle ORA = new Oracle("lola");
            ORA.FN = tbFN.Text;ORA.LN = tbLN.Text;ORA.CN = tbCN.Text;ORA.Type = cmbType.Text;ORA.Room = cmbRM.Text;ORA.Price = x;ORA.Fl = cmbFL.Text;ORA.Status = "Reserved"; ORA.D_R1 = D_R;ORA.D_D1 = D_D;
            ORA.AddReserves();
            ORA.EndDisplay();
            overallReservationToolStripMenuItem_Click(null, null);
        }

        private void overallReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("RESERVES");   // ORA.Query = "myTenant";
            ORA.StartDisplayAll();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }

    
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ch = cmbType.Text;
            Factory factory = new Factory();
            IPricer IP = factory.Create(ch);
            x = IP.GivePrice();
        }

        private void cmbFL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRM.Items.Clear();
            if (cmbFL.Text == "1") { for (int i = 1; i <= 18; i++) { cmbRM.Items.Add("A-" + i); } }
            else if (cmbFL.Text == "2") { for (int i = 1; i <= 18; i++) { cmbRM.Items.Add("B-" + i); } }
            else if (cmbFL.Text == "3") { for (int i = 1; i <= 18; i++) { cmbRM.Items.Add("C-" + i); } }
            else if (cmbFL.Text == "4") { for (int i = 1; i <= 18; i++) { cmbRM.Items.Add("D-" + i); } }
        }

    
    }
}
