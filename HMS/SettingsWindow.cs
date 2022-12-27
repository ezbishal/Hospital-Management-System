using HMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS;
using Settings;
using Classes;

namespace HMS
{
    public partial class SettingsWindow : Sample1
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userIDTxt.AllowDrop = true;
                passwordTxt.AllowDrop = true;

                if (MainClass.checkControls(leftPanel).Count > 0)
                {
                    MainClass.showMessage("Fields with red color are mandatory.", "error");

                }
                else
                {
                    settings.createFile("\\hms_connect", 1, sourceTxt.Text, dbTxt.Text);

                }
            }
            else
            {
                userIDTxt.AllowDrop = false;
                passwordTxt.AllowDrop = false;

                if (MainClass.checkControls(leftPanel).Count > 0)
                {
                    MainClass.showMessage("Fields with red color are mandatory.", "error");

                }
                else
                {
                    settings.createFile("\\hms_connect", 0, sourceTxt.Text, dbTxt.Text, userIDTxt.Text, passwordTxt.Text);

                }

            }
            LoginWindow lw = new LoginWindow();
            MainClass.showWindow(lw, this, MDI.ActiveForm);
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userIDTxt.Enabled = false;
                passwordTxt.Enabled = false;
                userIDTxt.Text = "";
                passwordTxt.Text = "";
            }
            else
            {
                userIDTxt.Enabled = true;
                passwordTxt.Enabled = true;
            }
        }
    }
}
