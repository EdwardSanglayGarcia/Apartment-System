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
    public partial class TenantManagement : Form
    {
        public TenantManagement()
        {
            InitializeComponent();
           

        }

        double x;
        string j;
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
            string QF = cmbFL.Text;
            FactoryFloor FF = new FactoryFloor();
            IFloor IF = FF.GetFloor(QF);
            j = IF.QueryFloor();

            if (j == "1"){for (int i = 1; i <= 18; i++){cmbRM.Items.Add("A-" + i);}}
            else if (j=="2"){for (int i = 1; i <= 18; i++){cmbRM.Items.Add("B-" + i);}}
            else if (j=="3"){for (int i = 1; i <= 18; i++){cmbRM.Items.Add("C-" + i);}}
            else if (j=="4"){for (int i = 1; i <= 18; i++){cmbRM.Items.Add("D-" + i);}}
        }

        private void overallRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("myTenant");   // ORA.Query = "myTenant";
            ORA.StartDisplayAll();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }

        private void deleteTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("myTenant");
            ORA.Room = cmbRM.Text;
            ORA.Deleter();
            overallRecordsToolStripMenuItem_Click(null, null);
        }

        private void updateTenantToolStripMenuItem1_Click(object sender, EventArgs e)
        { //UPDATE TENANT
            Oracle ORA = new Oracle("myTenant");// ORA.Query = "myTenant";
            ORA.FN = tbFN.Text;
            ORA.LN = tbLN.Text;
            ORA.Type = cmbType.Text;
            ORA.CN = tbCN.Text;
            ORA.Price = x;
            ORA.Status = "OCCUPIED";
            ORA.Room = cmbRM.Text;
            ORA.Duration = "7";

            ORA.RegisterUpdateNew();
            ORA.EndDisplay();
            overallRecordsToolStripMenuItem_Click(null, null);
           
        }

        private void cmbRM_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider =MSDAORA;Data Source=XE;User ID=EDWARDORA;Password=ragnarok;Unicode=True");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from myTenant where ROOM_NO='" + cmbRM.SelectedItem.ToString() + "'";
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

            if (tbCN.Text != "" && tbFN.Text != "" && tbLN.Text != "")
            {
                addTenantToolStripMenuItem.Enabled = false;
            }
            else
            {
                addTenantToolStripMenuItem.Enabled = true;
            }
        }

        private void TenantManagement_Load(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("myTenant");   // ORA.Query = "myTenant";
            ORA.StartDisplayAll();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();

          
        }

        private void addTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TenantManagement_MouseHover(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("myTenant");// ORA.Query = "myTenant";
            ORA.FN = tbFN.Text;
            ORA.LN = tbLN.Text;
            ORA.Type = cmbType.Text;
            ORA.CN = tbCN.Text;
            ORA.Price = x;
            ORA.Status = "OCCUPIED";
            ORA.Room = cmbRM.Text;
            ORA.Duration = "7";
            ORA.RegisterUpdateNew();
            ORA.EndDisplay();
            overallRecordsToolStripMenuItem_Click(null, null);
        }

        private void perFloorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string QF = cmbFL.Text;
            FactoryFloor FF = new FactoryFloor();
            IFloor IF = FF.GetFloor(QF);
            j = IF.QueryFloor();
            Oracle ORA = new Oracle("myTenant");
            ORA.Column = "FLOOR_NO";
            ORA.Getter = j;
            ORA.StartDisplayConditions();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }

        private void perTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ch = cmbType.Text;
            Factory factory = new Factory();
            IPricer IP = factory.Create(ch);
            x = IP.GivePrice();
            Oracle ORA = new Oracle("myTenant");
            ORA.Column = "PRICE";
            ORA.Getter = ""+x;
            ORA.StartDisplayConditions();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }

        private void availableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("myTenant");
            ORA.Column = "STATUS";
            ORA.Getter = "AVAILABLE";
            ORA.StartDisplayConditions();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }

        private void occupiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oracle ORA = new Oracle("myTenant");
            ORA.Column = "Status";
            ORA.Getter = "OCCUPIED";
            ORA.StartDisplayConditions();
            dataGridView1.DataSource = ORA.Dt;
            ORA.EndDisplay();
        }
    }
}
