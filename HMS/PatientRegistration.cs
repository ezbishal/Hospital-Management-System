using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Classes;
using CRUD;

namespace HMS
{
    public partial class PatientRegistration : Sample2
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        public static int d, m, y;

        private void loadPatients()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(turnGV);
            loadDa.Items.Add(patientIDGV);
            loadDa.Items.Add(patientGV);
            loadDa.Items.Add(guardianGV);
            loadDa.Items.Add(apptDTGV);
            loadDa.Items.Add(ageGV);
            loadDa.Items.Add(doctorGV);
            loadDa.Items.Add(doctorIDGV);
            loadDa.Items.Add(statusGV);
            loadDa.Items.Add(apptIDGV);
            loadDa.Items.Add(phoneGV);

            crud.loadData("st_getPatientAppointmentRegistration", dataGridView1, loadDa);
        }

        Int64 patID;
        Int64 appointmentID;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            crud.loadList("st_getDoctors", apptForDD, "ID", "Doctor", ht);

            dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            phoneTxt.BackColor = Color.White;
        }

        private bool get_checkPatientRecord(string phone)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkPatientRegistrationExists", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    check = true;
                    while (dr.Read())
                    {
                        patID = Convert.ToInt64(dr["PatientID"].ToString());
                        patientTxt.Text = dr["Patient"].ToString();
                        guardianTxt.Text = dr["Guardian"].ToString();
                        ageTxt.Text = dr["Age"].ToString();
                        lastApptDT.Value = Convert.ToDateTime(dr["LastAppointment"].ToString());
                        consultedToTxt.Text = dr["Doctor"].ToString();
                        statusTxt.Text = dr["Status"].ToString();
                    }

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


        
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            using (TransactionScope sc = new TransactionScope())
            {


                if (MainClass.checkControls(leftPanel).Count > 0)
                {
                    MainClass.showMessage("Fields with RED are mandatory!", "error");
                }
                else
                {
                    d = apptDT.Value.Day;
                    m = apptDT.Value.Month;
                    y = apptDT.Value.Year;

                    if (edit == 0) // Code for save
                    {
                        if (get_checkPatientRecord(phoneTxt.Text))
                        {
                            Hashtable htt = new Hashtable();
                            htt.Add("@date", apptDT.Value.ToString("dd-MMM-yyyy hh:mm tt"));
                            htt.Add("@doctorID", Convert.ToInt32(apptForDD.SelectedValue.ToString()));
                            htt.Add("@patientID", patID);
                            htt.Add("@status", 0);
                            htt.Add("@day", apptDT.Value.Day);
                            htt.Add("@month", apptDT.Value.Month);
                            htt.Add("@year", apptDT.Value.Year);

                            if (crud.insert_update_delete("st_insertAppointment", htt) > 0)
                            {
                                MainClass.showMessage(patientTxt.Text + " added successfully!", "success");
                                MainClass.resetDisable(leftPanel);
                                loadPatients();
                                TokenReportForm tt = new TokenReportForm();
                                tt.Show();
                            }
                        }
                        else
                        {
                            Hashtable ht = new Hashtable();
                            ht.Add("@name", patientTxt.Text);
                            ht.Add("@guard", guardianTxt.Text);
                            ht.Add("@phone", phoneTxt.Text);
                            ht.Add("@age", ageTxt.Text);

                            if (crud.insert_update_delete("st_insertPatientReg", ht) > 0)
                            {
                                Int64 patientID = Convert.ToInt64(crud.getLastID("st_getLastPatientID"));

                                Hashtable htt = new Hashtable();
                                htt.Add("@date", apptDT.Value.ToString("dd-MMM-yyyy hh:mm tt"));
                                htt.Add("@doctorID", Convert.ToInt32(apptForDD.SelectedValue.ToString()));
                                htt.Add("@patientID", patientID);
                                htt.Add("@status", 0);
                                htt.Add("@day", apptDT.Value.Day);
                                htt.Add("@month", apptDT.Value.Month);
                                htt.Add("@year", apptDT.Value.Year);

                                if (crud.insert_update_delete("st_insertAppointment", htt) > 0)
                                {
                                    MainClass.showMessage(patientTxt.Text + " added successfully!", "success");
                                    MainClass.resetDisable(leftPanel);
                                    loadPatients();
                                    TokenReportForm tt = new TokenReportForm();
                                    tt.Show();
                                }


                            }
                            else
                            {
                                MainClass.showMessage("Unable to save record.", "error");
                            }
                        }
                    }
                    else if (edit == 1) //Code for update
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add("@name", patientTxt.Text);
                        ht.Add("@guard", guardianTxt.Text);
                        ht.Add("@phone", phoneTxt.Text);
                        ht.Add("@age", ageTxt.Text);
                        ht.Add("@id", patID);

                        if (crud.insert_update_delete("st_updatePatientReg", ht) > 0)
                        {
                            //Int64 patientID = Convert.ToInt64(crud.getLastID("st_getLastPatientID"));

                            Hashtable htt = new Hashtable();
                            htt.Add("@date", apptDT.Text);
                            htt.Add("@doctorID", Convert.ToInt32(apptForDD.SelectedValue.ToString()));
                            htt.Add("@patientID", patID);
                            htt.Add("@status", 0);
                            htt.Add("@id", appointmentID);


                            if (crud.insert_update_delete("st_updateAppointment", htt) > 0)
                            {
                                MainClass.showMessage(patientTxt.Text + " updated successfully!", "success");
                                MainClass.resetDisable(leftPanel);
                                loadPatients();
                            }


                        }
                        else
                        {
                            MainClass.showMessage("Unable to save record.", "error");
                        }
                    }

                }
                
                sc.Complete();
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", patID);

                    if (crud.insert_update_delete("st_deletePatientReg", ht) > 0)
                    {
                        MainClass.showMessage(patientTxt.Text + " deleted successfully from the system.", "success");
                        MainClass.resetDisable(leftPanel);
                        loadPatients();
                    }
                }
            }
        }

        public override void viewBtn_Click_1(object sender, EventArgs e)
        {
            loadPatients();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                patID = Convert.ToInt64(row.Cells["patientIDGV"].Value.ToString());
                appointmentID = Convert.ToInt64(row.Cells["apptIDGV"].Value.ToString());
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                patientTxt.Text = row.Cells["patientGV"].Value.ToString();
                guardianTxt.Text = row.Cells["guardianGV"].Value.ToString();
                apptDT.Value = Convert.ToDateTime(row.Cells["apptDTGV"].Value.ToString());
                apptForDD.SelectedValue = row.Cells["doctorIDGV"].Value;
                ageTxt.Text = row.Cells["ageGV"].Value.ToString();
                get_checkPatientRecord(phoneTxt.Text);
            }
        }
        public static int hours, minutes;
        public static int gridClick = 0;

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneTxt.BackColor = Color.Firebrick; } else { phoneTxt.BackColor = Color.White; }

        }

        private void patientTxt_TextChanged(object sender, EventArgs e)
        {
            if (patientTxt.Text == "") { patientTxt.BackColor = Color.Firebrick; } else { patientTxt.BackColor = Color.White; }

        }

        private void guardianTxt_TextChanged(object sender, EventArgs e)
        {
            if (guardianTxt.Text == "") { guardianTxt.BackColor = Color.Firebrick; } else { guardianTxt.BackColor = Color.White; }

        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {
            if (ageTxt.Text == "") { ageTxt.BackColor = Color.Firebrick; } else { ageTxt.BackColor = Color.White; }

        }

        private void apptForDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (apptForDD.SelectedIndex == -1) { phoneTxt.BackColor = Color.Firebrick; } else { phoneTxt.BackColor = Color.White; }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                gridClick = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                d = Convert.ToDateTime(row.Cells["apptDTGV"].Value.ToString()).Day;
                m = Convert.ToDateTime(row.Cells["apptDTGV"].Value.ToString()).Month;
                y = Convert.ToDateTime(row.Cells["apptDTGV"].Value.ToString()).Year;
                hours = Convert.ToDateTime(row.Cells["apptDTGV"].Value.ToString()).Hour;
                minutes = Convert.ToDateTime(row.Cells["apptDTGV"].Value.ToString()).Minute;
                TokenReportForm tt = new TokenReportForm();
                tt.Show();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void phoneTxt_Leave_1(object sender, EventArgs e)
        {
            if (phoneTxt.Text != "")
            {
                if (get_checkPatientRecord(phoneTxt.Text))
                {
                }
                else
                {
                }
            }
        }
    }
}
