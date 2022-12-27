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
    public partial class UserWindow : Sample2
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        public override void backBtn_Click(object sender, EventArgs e)
        {
            AdminHomeScreen hm = new AdminHomeScreen();
            MainClass.showWindow(hm, this, MDI.ActiveForm);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void roleTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
