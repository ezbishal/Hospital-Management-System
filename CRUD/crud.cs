using System;
using System.Data.SqlClient;
using Classes;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace CRUD
{
    public class crud
    {
        
        public static void showReport(string proc, ReportDocument rd, string reportName, Hashtable ht, CrystalReportViewer cr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                   
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\" + reportName);
                rd.SetDataSource(dt);
                cr.ReportSource = rd;
                cr.RefreshReport();
            }
            catch (Exception)
            {
                if (rd != null)
                {
                    rd.Close();
                }
            }
        }
        public static bool checkExistance(string proc, Hashtable ht)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return check;
        }

        public static int insert_update_delete(string proc, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value.ToString());
                }
                MainClass.con.Open();
                res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                
            }
            catch(Exception ex) 
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
            return res;
        }

        public static void loadData(string proc, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
                int count = 0;
                foreach (DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static void loadData(string proc, DataGridView gv, ListBox lb, Hashtable ht)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value.ToString());
                }
                MainClass.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
                int count = 0;
                foreach (DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public static void loadList(string proc, ComboBox cb, string valueMember, string displayMember, Hashtable ht)
        {
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MainClass.showMessage(ex.Message, "error");
            }
        }

        public static object getLastID(string proc)
        {
            object o = null;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                o = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
            return o;
        }



        public static int getTurnNumber(string proc, Hashtable ht)
        {
            int turnNo = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                MainClass.con.Open();
                turnNo = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
            return turnNo;
        }
    }
}
