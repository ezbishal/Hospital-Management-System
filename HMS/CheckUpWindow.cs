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
    public partial class CheckUpWindow : Sample2
    {
        public CheckUpWindow()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckUpWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", dateTimePicker1.Value.Day);
            ht.Add("@month", dateTimePicker1.Value.Month);
            ht.Add("@year", dateTimePicker1.Value.Year);
            crud.loadList("st_getTodaysPatients", patientDD, "Patient ID", "Patient", ht);
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public static int turnNo;
        public static string patientName;
        private void callBtn_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@day", dateTimePicker1.Value.Day);
            ht.Add("@month", dateTimePicker1.Value.Month);
            ht.Add("@year", dateTimePicker1.Value.Year);
            ht.Add("@patID", Convert.ToInt64(patientDD.SelectedValue.ToString()));
            turnNo = crud.getTurnNumber("st_getTurnNumberWRTpatientWRTToday", ht);
        }
    }
}
