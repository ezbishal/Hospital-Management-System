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
    public partial class HomeScreen : Sample1
    {
        public HomeScreen()
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
    }
}
