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
    public partial class TurnWindow : Sample1
    {
        public TurnWindow()
        {
            InitializeComponent();
        }

        int ticks = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void TurnWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
            turnLabel.Text = CheckUpWindow.turnNo.ToString();

        }

        private void TurnWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
