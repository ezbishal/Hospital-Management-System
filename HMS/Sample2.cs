using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace HMS
{
    public partial class Sample2 : Sample1
    {
        public Sample2()
        {
            InitializeComponent();
        }

        public int edit = 0;
        private void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.resetEnable(leftPanel);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                MainClass.EnableControls(leftPanel);

            }
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminHomeScreen hm = new AdminHomeScreen();
            MainClass.showWindow(hm, this, MDI.ActiveForm);
        }

        public virtual void viewBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
