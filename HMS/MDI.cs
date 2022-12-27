using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Classes;

namespace HMS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\hms_connect";
            Console.WriteLine(path);
            if (File.Exists(path))
            {
                LoginWindow lw = new LoginWindow();
                MainClass.showWindow(lw, MDI.ActiveForm);
            }
            else
            {
                SettingsWindow sw = new SettingsWindow();
                MainClass.showWindow(sw, MDI.ActiveForm);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow sw = new SettingsWindow();
            MainClass.showWindow(sw, MDI.ActiveForm);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            MainClass.showWindow(lw, MDI.ActiveForm);
        }
    }
}
