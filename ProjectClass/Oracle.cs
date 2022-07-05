using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ProjectClass
{
    public class Oracle
    {
        OleDbConnection con = new OleDbConnection("Provider =MSDAORA;Data Source=XE;User ID=EDWARDORA;Password=ragnarok;Unicode=True");
        DataTable dt = new DataTable();
        OleDbDataAdapter oda;

        public Oracle(string query)
        {
            this.query = query;
        }

        string query;
        string column;
        string getter;

        string fN;
        string lN;
        string type;
        string cN;
        double price;
        string status;
        string room;
        string duration;
        string fl;

        string user;
        string pass;

        string iD;
        string uN;
        string pW;

        string D_R;
        string D_D;

        public DataTable Dt
        { get { return dt; } set { dt = value; } }

        public string Query
        { get { return query; } set { query = value; } }

        public string Column
        { get { return column; } set { column = value; } }

        public string Getter
        { get { return getter; } set { getter = value; } }

        public string FN
        { get { return fN; } set { fN = value; } }

        public string LN
        { get { return lN; } set { lN = value; } }

        public string Type
        { get { return type; } set { type = value; } }

        public string CN
        { get { return cN; } set { cN = value; } }

        public double Price
        { get { return price; } set { price = value; } }

        public string Status
        { get { return status; } set { status = value; } }

        public string Room
        { get { return room; } set { room = value; } }

        public OleDbDataAdapter Oda
        { get { return oda; } set { oda = value; } }

        public string Duration
        { get { return duration; } set { duration = value; } }

        public string User
        { get { return user; } set { user = value; } }

        public string Pass
        { get { return pass; } set { pass = value; } }

        public string ID
        { get { return iD; } set { iD = value; } }

        public string UN
        { get { return uN; } set { uN = value; } }

        public string PW
        { get { return pW; } set { pW = value; } }

        public string D_R1 { get => D_R; set => D_R = value; }
        public string D_D1 { get => D_D; set => D_D = value; }
        public string Fl { get => fl; set => fl = value; }


        public void StartDisplayConditions()
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM " + query + " WHERE " + Column + " = '" + Getter+"'", con);
            oda.Fill(dt);
        }

        public void RegisterUpdateNew()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE myTenant SET FIRST_NAME =  '" + fN + "', LAST_NAME= '" + lN + "', TYPE='" + type + "', CONTACT_NO='" + cN + "', PRICE='" + price + "', STATUS='" + status + "', DURATION='" + duration + "' WHERE ROOM_NO='" + room + "'", con);
            cmd.ExecuteNonQuery();
        }

        public void StartDisplayAll()
        {
            con.Open();
            oda = new OleDbDataAdapter("SELECT * FROM " + query, con);
            oda.Fill(dt);
        }

        public void Deleter()
        {   // OleDbCommand cmd = new OleDbCommand("UPDATE myTenant SET Duration = 0",con);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Update " + query + " set First_Name='',Type='', Last_Name='',Contact_No='',Price='',Status='AVAILABLE', Duration='0000' where Room_No= '" + room + "'", con);
            cmd.ExecuteNonQuery();
        }

        public bool LoginVerification()
        {//For Login
            string str1 = "SELECT USER_NAME, PASS_WORD FROM " + query + " WHERE USER_NAME='" + user + "' AND PASS_WORD='" + pass + "'";
            OleDbCommand cmd = new OleDbCommand(str1, con);
            OleDbDataAdapter da = new OleDbDataAdapter(str1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0) { return true; }
            else { return false; }
        }

        public void Creator()
        {//For Register
            con.Open();
            string str = "insert into myAdmin(Employee_No,First_Name,Last_Name,User_Name,Pass_Word) values('" + iD + "' , '" + fN + "' , '" + lN + "' , '" + uN + "' , '" + pW + "')";
            OleDbCommand cmd = new OleDbCommand(str, con);
            cmd.ExecuteNonQuery();
        }

        public void CreatorS()
        {//For Register
            con.Open();
            string str = "insert into myEmployee(Employee_No,First_Name,Last_Name,User_Name,Pass_Word) values('" + iD + "' , '" + fN + "' , '" + lN + "' , '" + uN + "' , '" + pW + "')";
            OleDbCommand cmd = new OleDbCommand(str, con);
            cmd.ExecuteNonQuery();
        }

        public void Delete()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from " + query + " WHERE Employee_No=" + iD, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE myEmployee SET PASS_WORD =  '" + pW + "' WHERE Employee_No ='" + iD + "'", con);
            cmd.ExecuteNonQuery();
        }

        public void EndDisplay()
        {//Fr closing
            con.Close();
        }

        public void AddReserve()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO RESERVES VALUES('" + fN + "','" + lN + "','" + cN + "','" + type + "','" + price + "','" + fl + "','" + room + "','" + status + "',TO_DATE('" + D_D + "', 'YYYY/MM/DD'),TO_DATE('" + D_R + "','YYYY/MM/DD'))", con);
            //OleDbCommand cmd = new OleDbCommand(,con);
            cmd.ExecuteNonQuery();
        }

        public void DeleteReserve()
        {//Delete from
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from " + query + " WHERE ROOM='" + room + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ViewOverdue()
        {
            con.Open();
            oda = new OleDbDataAdapter("SELECT * FROM " + query + " WHERE SYSDATE > DATE_DUE", con);
            oda.Fill(dt);
        }

        public void DeleteOverdue()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from " + query + " WHERE SYSDATE > DATE_DUE", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void TypeReserveConditions()
        {
            con.Open();
            oda = new OleDbDataAdapter("SELECT * FROM " + query + " WHERE TYPE ='" + type + "'", con);
            oda.Fill(dt);
        }

        public void FloorReserveConditions()
        {
            con.Open();
            oda = new OleDbDataAdapter("SELECT * FROM " + query + " WHERE FLOOR ='" + fl + "'", con);
            oda.Fill(dt);
        }

  
        public void AddReserves()
        {
            try
            {
                string che = @"SELECT COUNT(*) FROM RESERVES WHERE ROOM='" + room + "'";
                OleDbCommand cmd = new OleDbCommand("INSERT INTO RESERVES VALUES('" + fN + "','" + lN + "','" + cN + "','" + type + "','" + price + "','" + fl + "','" + room + "','" + status + "',TO_DATE('" + D_R + "', 'YYYY/MM/DD'),TO_DATE('" + D_D + "','YYYY/MM/DD'))", con);
                con.Open();
                OleDbCommand cmda = new OleDbCommand(che, con);
                if (Convert.ToInt32(cmda.ExecuteScalar()) > 0)
                {
                    //DONT
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }

            }


            catch (Exception ex)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }
     


    }
}

