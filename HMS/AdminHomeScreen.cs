using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class AdminHomeScreen : Sample1
    {
        public AdminHomeScreen()
        {
            InitializeComponent();
        }

        private void roleBtn_Click(object sender, EventArgs e)
        {
            RoleWindow rw = new RoleWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffWindow sw = new StaffWindow(); 
            MainClass.showWindow(sw, this, MDI.ActiveForm); 
        }

        private void medicineBtn_Click(object sender, EventArgs e)
        {
            MedicineWindow mw = new MedicineWindow();
            MainClass.showWindow(mw, this, MDI.ActiveForm);
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            PatientRegistration pr = new PatientRegistration();
            MainClass.showWindow(pr, this, MDI.ActiveForm);
        }

        private void diseaseBtn_Click(object sender, EventArgs e)
        {
            DiseaseWindow dw = new DiseaseWindow();
            MainClass.showWindow(dw, this, MDI.ActiveForm);
        }

        private void symptomBtn_Click(object sender, EventArgs e)
        {
            SymptomsWindow sw = new SymptomsWindow();
            MainClass.showWindow(sw, this, MDI.ActiveForm);
        }

        private void turnScreenBtn_Click(object sender, EventArgs e)
        {
            TurnWindow tw = new TurnWindow();
            tw.Show();
        }

        private void checkupBtn_Click(object sender, EventArgs e)
        {
            CheckUpWindow cw = new CheckUpWindow();
            MainClass.showWindow(cw, this, MDI.ActiveForm);
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            TestWindow tw = new TestWindow();
            MainClass.showWindow(tw, this, MDI.ActiveForm);
        }

        private void AdminHomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roleBtn_Click_1(object sender, EventArgs e)
        {
            RoleWindow rw = new RoleWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void roleBtn_Click_2(object sender, EventArgs e)
        {
            RoleWindow rw = new RoleWindow();
            MainClass.showWindow(rw, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TokenReportForm tr = new TokenReportForm();
            MainClass.showWindow(tr, this, MDI.ActiveForm);
        }
    }
}
