using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD;

namespace HMS
{
    public partial class Payments : Sample1
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
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
            crud.loadData("st_getPatientAppointmentReg2", dataGridView1, loadDa, ht);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadCheckedPatient();
        }
    }
}
