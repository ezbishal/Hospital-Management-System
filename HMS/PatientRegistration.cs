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
        }

        private bool get_checkPatientRecord(string phone)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_CheckPatientRegistration", MainClass.con);
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
                throw;
            }
            return check;
        }

        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            if(phoneTxt.Text != "")
            {
                if(get_checkPatientRecord(phoneTxt.Text))
                {

                }
                else
                {
                    MainClass.resetEnable(leftPanel);
                }
            }
        }

        Int64 patID;
        Int64 appointmentID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count > 0)
            {
                MainClass.showMessage("Fields with RED are mandatory!", "error");
            }
            else
            {
                using(TransactionScope sc = new TransactionScope())
                {
                    if (edit == 0) // Code for save
                    {
                        if (get_checkPatientRecord(phoneTxt.Text))
                        {

                        }
                        else
                        {
                            Hashtable ht = new Hashtable();
                            ht.Add("@name", patientTxt.Text);
                            ht.Add("@guard", guardianTxt.Text);
                            ht.Add("@phone", phoneTxt.Text);
                            ht.Add("@age", ageTxt.Text);
                            ht.Add("@id", patID);

                            if (crud.insert_update_delete("st_updatePatientReg", ht) > 0)
                            {
                                Int64 patientID = patID;

                                Hashtable htt = new Hashtable();
                                htt.Add("@date", apptDT.Text);
                                htt.Add("@doctorID", Convert.ToInt32(apptForDD.SelectedValue.ToString()));
                                htt.Add("@patientID", patientID);
                                htt.Add("@status", 0);

                                if (crud.insert_update_delete("st_insertAppointment", htt) > 0)
                                {
                                    MainClass.showMessage(patientTxt.Text + " added successfully!", "success");
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
                            ht.Add("@date", apptDT.Text);
                            ht.Add("@doctorID", Convert.ToInt32(apptForDD.SelectedValue.ToString()));
                            ht.Add("@patientID", patID);
                            ht.Add("@status", 0);
                            ht.Add("@id", appointmentID);


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
                    sc.Complete();
                }
                if (edit == 0) // Code for save
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
                        ht.Add("@date", apptDT.Text);
                        ht.Add("@doctorID", Convert.ToInt32(apptForDD.SelectedValue.ToString()));
                        ht.Add("@patientID", patientID);
                        ht.Add("@status", 0);
                        ht.Add("@day", apptDT.Value.Day);
                        ht.Add("@month", apptDT.Value.Month);
                        ht.Add("@year", apptDT.Value.Year);


                        if (crud.insert_update_delete("st_insertAppointment", htt) > 0)
                        {
                            MainClass.showMessage(patientTxt.Text + " added successfully!", "success");
                            MainClass.resetDisable(leftPanel);
                            loadPatients();
                        }

                        
                    }
                    else
                    {
                        MainClass.showMessage("Unable to save record.", "error");
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
                        ht.Add("@date", apptDT.Text);
                        ht.Add("@doctorID", Convert.ToInt32(apptForDD.SelectedValue.ToString()));
                        ht.Add("@patientID", patID);
                        ht.Add("@status", 0);
                        ht.Add("@id", appointmentID);


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

        public override void viewBtn_Click(object sender, EventArgs e)
        {

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
                guardianTxt.Text = row.Cells["guardGV"].Value.ToString();
                apptDT.Value = Convert.ToDateTime(row.Cells["apptDTGV"].Value.ToString());
                apptForDD.SelectedValue = row.Cells["doctorIDGV"].Value;
                ageTxt.Text = row.Cells["ageGV"].Value.ToString();
                get_checkPatientRecord(phoneTxt.Text);
            }
        }
    }
}
