using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CRUD;
using Classes;

namespace HMS
{
    public partial class Payment : Sample1
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = false;
            
        }

        private void loadCheckedPatient()
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

            Hashtable ht = new Hashtable();
            ht.Add("@day", dateTimePicker1.Value.Day);
            ht.Add("@month", dateTimePicker1.Value.Month);
            ht.Add("@year", dateTimePicker1.Value.Year);
            ht.Add("@status", 1); //Consulted
            crud.loadData("st_getPatientAppointmentReg2", dataGridView2, loadDa, ht);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadCheckedPatient();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminHomeScreen hm = new AdminHomeScreen();
            MainClass.showWindow(hm, this, MDI.ActiveForm);
        }

        public static Int64 apptID;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                dataGridView2.Columns[e.ColumnIndex].Name == "prtBtnGV" &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                apptID = Convert.ToInt64(row.Cells["apptIDGV"].Value.ToString());
                Report r = new Report();
                r.Show();
            }
        }
    }
}