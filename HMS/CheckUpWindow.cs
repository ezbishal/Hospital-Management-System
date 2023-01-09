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
    public partial class CheckUpWindow : Sample2
    {
        public CheckUpWindow()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadTodaysPatients()
        {
            patientDD.DataSource = null;
            Hashtable ht = new Hashtable();
            ht.Add("@day", dateTimePicker1.Value.Day);
            ht.Add("@month", dateTimePicker1.Value.Month);
            ht.Add("@year", dateTimePicker1.Value.Year);
            crud.loadList("st_getTodaysPatients", patientDD, "PatientID", "Patient", ht);
        }
        private void CheckUpWindow_Load(object sender, EventArgs e)
        {
            loadTodaysPatients();
            Hashtable ht = new Hashtable();
            crud.loadList("st_getDiseases", diseaseDD, "ID", "Disease", ht);
            crud.loadList("st_getSymptoms", symptomDD, "SymptomID", "Symptom", ht);

            Hashtable ht1 = new Hashtable();
            ht1.Add("@type", 0);
            crud.loadList("st_getMedicineWRTType", internalDD, "ID", "Medicine", ht1);

            Hashtable ht2 = new Hashtable();
            ht2.Add("@type", 1);
            crud.loadList("st_getMedicineWRTType", externalDD, "ID", "Medicine", ht2);
        
            crud.loadList("st_getTests", testsDD, "ID", "Test", ht);

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void getLastMedicine(ListBox lb, Int64 appID, Int16 type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastPrescribedMedicine", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@appID", appID);
                MainClass.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lb.DisplayMember = "Medicine";
                lb.ValueMember= "ID";
                lb.DataSource= dt;
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close(); 
            }
        }

        public void getLastDetails(string proc, ListBox lb, string param, object val, string dMember, string vMember)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, val);
                MainClass.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lb.DisplayMember = dMember;
                lb.ValueMember = vMember;
                lb.DataSource = dt;
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }

        public static int turnNo;
        public static string patientName;
         Int64 patientAppID = 0;
        public void getLastCheckupDetails(Int16 status, Int64 patientID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastCheckupDetails1", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@patientID", patientID);

                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lastApptPicker.Value = Convert.ToDateTime(dr["AppointmentDate"].ToString());
                        consultedToTxt.Text = dr["Doctor"].ToString();
                        pTxt.Text = dr["Pulse"].ToString();
                        tTxt.Text = dr["Temperature"].ToString();
                        gTxt.Text = dr["Glucose"].ToString();
                        patientAppID = Convert.ToInt64(dr["AppID"].ToString());
                    }
                }
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }

        public void getLastRemarks()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastRemarks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@appID", patientAppID);
                MainClass.con.Open();
                string lastRemarks = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                if (lastRemarks != null)
                {
                    lastRemarksTxt.Text = lastRemarks;
                }
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
        }


        private void callBtn_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", dateTimePicker1.Value.Day);
            ht.Add("@month", dateTimePicker1.Value.Month);
            ht.Add("@year", dateTimePicker1.Value.Year);
            ht.Add("@patID", Convert.ToInt64(patientDD.SelectedValue.ToString()));
            turnNo = crud.getTurnNumber("st_getTurnNumberWRTpatientWRTToday", ht);
            getPatientInfo();
            getLastCheckupDetails(1, Convert.ToInt64(patientDD.SelectedValue.ToString()));
            getLastMedicine(lastMedicineInternalLB, patientAppID, 0);
            getLastMedicine(lastMedicineExternalLB, patientAppID, 1);
            getLastDetails("st_getLastTests", lastTestsLB, "@appID", patientAppID, "Test", "ID");
            getLastDetails("st_getLastSymptoms", lastSymptomsLB, "@appID", patientAppID, "Symptom", "ID");
            getLastDetails("st_getLastDisease", lastDiseasesLB, "@appID", patientAppID, "Disease", "ID");
            getLastRemarks();

            TurnWindow tw = new TurnWindow();
            tw.Show();
        }

        private int getDiseaseID(string name)
        {
            int did = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDiseaseIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                
                MainClass.con.Open();
                did = Convert.ToInt32((cmd.ExecuteScalar()).ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return did;
        }

        private Int64 getSymptomID(string name)
        {
            Int64 sid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSymptomIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                sid = Convert.ToInt64((cmd.ExecuteScalar()).ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close(); 
            }
            return sid;
        }

        private int getTestID(string name)
        {
            int tid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("getTestIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                tid = Convert.ToInt32((cmd.ExecuteScalar()).ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return tid;
        }

        private int getMedicineID(string name)
        {
            int mid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getMedicineIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                mid = Convert.ToInt32((cmd.ExecuteScalar()).ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();  
            }
            return mid;
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void patientDD_Enter(object sender, EventArgs e)
        {
            loadTodaysPatients();
        }

        private void getPatientInfo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPatientGuardianAndAge", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt64(patientDD.SelectedValue.ToString()));
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       guardianTxt.Text = dr[0].ToString();
                       ageTxt.Text = dr[1].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch(Exception)
            {
                MainClass.con.Close(); 
            }
        }

        private Int64 getPatientApointmentID()
        {
            Int64 appointmentID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPatientAppointmentID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patID", Convert.ToInt64(patientDD.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@day", dateTimePicker1.Value.Day);
                cmd.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
                cmd.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);

                MainClass.con.Open();
                appointmentID = Convert.ToInt64((cmd.ExecuteScalar()).ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                
            }
            return appointmentID;
        }

        private void diseaseAddBtn_Click(object sender, EventArgs e)
        {
            if(diseaseDD.Text != "")
            {
                if(!diseaseLB.Items.Contains(diseaseDD.Text))
                {
                    diseaseLB.Items.Add(diseaseDD.Text);
                }
            }
        }

        Hashtable htInternal = new Hashtable();
        private void presIntAddBtn_Click(object sender, EventArgs e)
        {

            if (internalDD.Text != "")
            {
                if(!mRB.Checked && !anbsRB.Checked && !meRB.Checked && !oadRB.Checked && !bmRB.Checked && !otherRB.Checked)
                {
                    MainClass.showMessage("Please select dosage of this medicine.", "error");
                }
                else
                {
                    if (!internalLB.Items.Contains(internalDD.Text))
                    {
                        if (mRB.Checked)
                        {
                            htInternal.Add(internalDD.Text, 0);
                            internalLB.Items.Add(internalDD.Text + "-" + mRB.Text);

                        }
                        else if (anbsRB.Checked)
                        {
                            htInternal.Add(internalDD.Text, 1);
                            internalLB.Items.Add(internalDD.Text + "-" + anbsRB.Text);

                        }
                        else if (meRB.Checked)
                        {
                            htInternal.Add(internalDD.Text, 2);
                            internalLB.Items.Add(internalDD.Text + "-" + meRB.Text);

                        }
                        else if (oadRB.Checked)
                        {
                            htInternal.Add(internalDD.Text, 3);
                            internalLB.Items.Add(internalDD.Text + "-" + oadRB.Text);

                        }
                        else if (bmRB.Checked)
                        {
                            htInternal.Add(internalDD.Text, 4);
                            internalLB.Items.Add(internalDD.Text + "-" + bmRB.Text);

                        }
                        else if (otherRB.Checked)
                        {
                            htInternal.Add(internalDD.Text, 5);
                            internalLB.Items.Add(internalDD.Text + "-" + otherTxt.Text);

                        }

                        mRB.Checked = false;
                        anbsRB.Checked = false;
                        meRB.Checked = false;
                        oadRB.Checked = false;
                        bmRB.Checked = false;
                        otherRB.Checked = false;
                    }
                }
                
            }
        }

        Hashtable htExternal = new Hashtable();

        private void externalAddBtn_Click(object sender, EventArgs e)
        {
            if (externalDD.Text != "")
            {
                if (!m2RB.Checked && !anbs2RB.Checked && !me2RB.Checked && !oad2RB.Checked && !bm2RB.Checked && !other2RB.Checked)
                {
                    MainClass.showMessage("Please select dosage of this medicine.", "error");
                }
                else
                {
                    if (!externalLB.Items.Contains(externalDD.Text))
                    {
                        if (m2RB.Checked)
                        {
                            htExternal.Add(externalDD.Text, 0);
                            externalLB.Items.Add(internalDD.Text + "-" + m2RB.Text);

                        }
                        else if (anbs2RB.Checked)
                        {
                            htExternal.Add(externalDD.Text, 1);
                            externalLB.Items.Add(externalDD.Text + "-" + anbs2RB.Text);

                        }
                        else if (me2RB.Checked)
                        {
                            htExternal.Add(externalDD.Text, 2);
                            externalLB.Items.Add(externalDD.Text + "-" + me2RB.Text);

                        }
                        else if (oad2RB.Checked)
                        {
                            htExternal.Add(externalDD.Text, 3);
                            externalLB.Items.Add(externalDD.Text + "-" + oad2RB.Text);

                        }
                        else if (bm2RB.Checked)
                        {
                            htExternal.Add(externalDD.Text, 4);
                            externalLB.Items.Add(externalDD.Text + "-" + bm2RB.Text);

                        }
                        else if (other2RB.Checked)
                        {
                            htExternal.Add(externalDD.Text, 5);
                            externalLB.Items.Add(externalDD.Text + "- " + other2Txt.Text);

                        }

                        m2RB.Checked = false;
                        anbs2RB.Checked = false;
                        me2RB.Checked = false;
                        oad2RB.Checked = false;
                        bm2RB.Checked = false;
                        other2RB.Checked = false;
                    }
                }

            }
        }

        private void testsAddBtn_Click(object sender, EventArgs e)
        {
            if (testsDD.Text != "")
            {
                if (!testsLB.Items.Contains(testsDD.Text))
                {
                    testsLB.Items.Add(testsDD.Text);
                }
            }
        }

        private void sympAddBtn_Click(object sender, EventArgs e)
        {
            if (symptomDD.Text != "")
            {
                if (!symptomLB.Items.Contains(symptomDD.Text))
                {
                    symptomLB.Items.Add(symptomDD.Text);
                }
            }
        }

        private void otherRB_CheckedChanged(object sender, EventArgs e)
        {
            if (otherRB.Checked)
            {
                otherTxt.Enabled = true;
            }
            else
            {
                otherTxt.Enabled = false;
            }
        }

        private void internalRemoveBtn_Click(object sender, EventArgs e)
        {
            if (internalLB.SelectedItems.Count > 0)
            {
                char[] delim = { '-' };
                string[] arr = internalLB.SelectedItem.ToString().Split(delim);
                htInternal.Remove(arr[0]);

                internalLB.Items.Remove(internalLB.SelectedItem);

            }
        }

        private void externalRemoveBtn_Click(object sender, EventArgs e)
        {
            if (externalLB.SelectedItems.Count > 0)
            {
                char[] delim = { '-' };
                string[] arr = externalLB.SelectedItem.ToString().Split(delim);
                htExternal.Remove(arr[0]);

                externalLB.Items.Remove(externalLB.SelectedItem);

            }
        }

        private void diseaseRemoveBtn_Click(object sender, EventArgs e)
        {
            if (diseaseLB.SelectedItems.Count > 0)
            {
                diseaseLB.Items.Remove(diseaseLB.SelectedItem);
            }
        }

        private void testsRemoveBtn_Click(object sender, EventArgs e)
        {
            if (testsLB.SelectedItems.Count > 0)
            {
                testsLB.Items.Remove(testsLB.SelectedItem);
            }
        }

        private void sympRemoveBtn_Click(object sender, EventArgs e)
        {
            if (symptomLB.SelectedItems.Count > 0)
            {
                symptomLB.Items.Remove(symptomLB.SelectedItem);
            }
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            Int64 apptID = getPatientApointmentID();

            using (TransactionScope sc = new TransactionScope())
            {
                /////////////////Disease//////////////////////
                if (diseaseLB.Items.Count> 0)
                {
                    foreach (string item in diseaseLB.Items)
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add("@disease", item);
                        int diseaseID;

                        if (!crud.checkExistance("st_checkDiseaseExists", ht))
                        {
                            crud.insert_update_delete("st_insertDisease", ht);
                            diseaseID = Convert.ToInt32(crud.getLastID("st_getLastDiseaseID"));

                        }
                        else
                        {
                            diseaseID = getDiseaseID(item);

                        }
                        Hashtable patientDiseaseHT = new Hashtable();
                        patientDiseaseHT.Add("@appID", apptID);
                        patientDiseaseHT.Add("@diseaseID", diseaseID);
                        crud.insert_update_delete("st_insertPatientDisease", patientDiseaseHT);
                    }
                }
                
                ////////////////////////////////////////////////

                /////////////////Symptoms//////////////////////

                if(symptomLB.Items.Count> 0)
                {
                    foreach (string item in symptomLB.Items)
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add("@symptom", item);
                        Int64 symptomID;

                        if (!crud.checkExistance("st_checkSymptomExists", ht))
                        {
                            crud.insert_update_delete("st_insertSymptoms", ht);
                            symptomID = Convert.ToInt32(crud.getLastID("getLastSymptomID"));

                        }
                        else
                        {
                            symptomID = getSymptomID(item);

                        }
                        Hashtable patientSymptomHT = new Hashtable();
                        patientSymptomHT.Add("appID", apptID);
                        patientSymptomHT.Add("symID", symptomID);
                        crud.insert_update_delete("st_insertPatientSymptoms", patientSymptomHT);
                    }
                }

                ////////////////////////////////////////////////


                /////////////////Tests//////////////////////

                if (testsLB.Items.Count > 0)
                {
                    foreach (string item in testsLB.Items)
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add("@name", item);
                        int testID;
                        if(!crud.checkExistance("st_checkTestExists", ht))
                        {
                            crud.insert_update_delete("st_insertTests2", ht);
                            testID = Convert.ToInt32(crud.getLastID("st_getLastTestID"));
                        }
                        else
                        {
                            testID = getTestID(item);
                        }
                        Hashtable patientTestHT = new Hashtable();
                        patientTestHT.Add("appID", apptID);
                        patientTestHT.Add("testID", testID);
                        crud.insert_update_delete("st_insertPatientTests", patientTestHT);
                    }
                }

                ////////////////////////////////////////////////


                /////////////////Internal Medicine//////////////////////

                if (internalLB.Items.Count > 0)
                {
                    char[] delim = { '-' };
                    foreach (string item in internalLB.Items)
                    {
                        string[] med = item.Split(delim);

                        Hashtable ht = new Hashtable();
                        ht.Add("@name", med[0]);
                        ht.Add("@type", 0);
                        int medicineID;

                        if (!crud.checkExistance("st_checkMedicineExists", ht))
                        {
                            crud.insert_update_delete("st_insertMedicine2", ht);
                            medicineID = Convert.ToInt32(crud.getLastID("st_getLastMedicineID"));

                        }
                        else
                        {
                            medicineID = getMedicineID(med[0]);

                        }
                        Hashtable patientInternalHT = new Hashtable();
                        patientInternalHT.Add("@appID", apptID);
                        patientInternalHT.Add("@medicineID", medicineID);

                        Int16 dosageID = 0;
                        if (med[1] == "Morning")
                        {
                            dosageID = 0;
                        }
                        else if (med[1] == "At night before sleep")
                        {
                            dosageID = 1;
                        }
                        else if (med[1] == "Morning + Evening")
                        {
                            dosageID = 2;
                        }
                        else if (med[1] == "Once a day")
                        {
                            dosageID = 3;
                        }
                        else if (med[1] == "Before Meal")
                        {
                            dosageID = 4;
                        }
                        else if (med[1] == "Other")
                        {
                            dosageID = 5;
                        }
                        patientInternalHT.Add("@dosage", dosageID);
                        if (otherRB.Checked)
                        {
                            patientInternalHT.Add("@other", otherTxt.Text);
                            crud.insert_update_delete("st_insertPatientMedicineAll", patientInternalHT);
                        }
                        else
                        {
                            crud.insert_update_delete("st_insertPatientMedicine", patientInternalHT);

                        }
                    }
                }

                ////////////////////////////////////////////////

                /////////////////External Medicine//////////////////////

                if (externalLB.Items.Count > 0)
                {
                    char[] delim = { '-' };

                    foreach (string item in externalLB.Items)
                    {
                        string[] med = item.Split(delim);

                        Hashtable ht = new Hashtable();
                        ht.Add("@name", med[0]);
                        ht.Add("@type", 1);
                        int medicineID;

                        if (!crud.checkExistance("st_checkMedicineExists", ht))
                        {
                            crud.insert_update_delete("st_insertMedicine2", ht);
                            medicineID = Convert.ToInt32(crud.getLastID("st_getLastMedicineID"));

                        }
                        else
                        {
                            medicineID = getMedicineID(med[0]);

                        }
                        Hashtable patientExternalHT = new Hashtable();
                        patientExternalHT.Add("@appID", apptID);
                        patientExternalHT.Add("@medicineID", medicineID);

                        Int16 dosageID = 0;
                        if (med[1] == "Morning")
                        {
                            dosageID = 0;
                        }
                        else if (med[1] == "At night before sleep")
                        {
                            dosageID = 1;
                        }
                        else if (med[1] == "Morning + Evening")
                        {
                            dosageID = 2;
                        }
                        else if (med[1] == "Once a day")
                        {
                            dosageID = 3;
                        }
                        else if (med[1] == "Before Meal")
                        {
                            dosageID = 4;
                        }
                        else if (med[1] == "Other")
                        {
                            dosageID = 5;
                        }
                        patientExternalHT.Add("@dosage", dosageID);
                        if (other2RB.Checked)
                        {
                            patientExternalHT.Add("@other", other2Txt.Text);
                            crud.insert_update_delete("st_insertPatientMedicineAll", patientExternalHT);
                        }
                        else
                        {
                            crud.insert_update_delete("st_insertPatientMedicine", patientExternalHT);

                        }
                    }
                }

                ////////////////////////////////////////////////


                /////////////////Pulse, Temperature and Glucose//////////////////////
                Hashtable htPTG = new Hashtable();
                htPTG.Add("@appID", apptID);
                htPTG.Add("@pulse", pulseTxt.Text);
                htPTG.Add("@temp", tempTxt.Text);
                htPTG.Add("@glucose", glucoseTxt.Text);

                crud.insert_update_delete("st_insertPTG", htPTG);


                ////////////////////////////////////////////////

                /////////////////Pulse, Temperature and Glucose//////////////////////
                Hashtable htRemarks = new Hashtable();
                htRemarks.Add("@appID", apptID);
                htRemarks.Add("@rem", remarksTxt.Text);
                htRemarks.Add("@fees", feesTxt.Text);

                crud.insert_update_delete("st_insertPatientCheckUp", htRemarks);


                ////////////////////////////////////////////////

                Hashtable htStatus = new Hashtable();
                htStatus.Add("@appID", apptID);
                htStatus.Add("@status", 1);

                crud.insert_update_delete("st_updatePatientStatus", htStatus);

                DialogResult result = MessageBox.Show("Patient checkup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    {
                        this.Close();
                        CheckUpWindow cw = new CheckUpWindow();
                        MainClass.showWindow(cw, this, MDI.ActiveForm);
                    }
                
                sc.Complete();
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pulseTxt_Enter(object sender, EventArgs e)
        {
            pulseTxt.SelectAll();
        }

        private void tempTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pulseTxt_Leave(object sender, EventArgs e)
        {
            if (pulseTxt.Text == "")
            {
                pulseTxt.Text = "-";
            }
        }

        private void tempTxt_Enter(object sender, EventArgs e)
        {
            tempTxt.SelectAll();
        }

        private void tempTxt_Leave(object sender, EventArgs e)
        {
               if (tempTxt.Text == "")
            {
                tempTxt.Text = "-";
            }
        }

        private void glucoseTxt_Enter(object sender, EventArgs e)
        {
            glucoseTxt.SelectAll();
        }

        private void glucoseTxt_Leave(object sender, EventArgs e)
        {
            if (glucoseTxt.Text == "")
            {
                glucoseTxt.Text = "-";
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void other2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (other2RB.Checked)
            {
                other2Txt.Enabled = true;
            }
            else
            {
                other2Txt.Enabled = false;
            }
        }
    }
}
