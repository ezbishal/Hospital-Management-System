﻿using System;
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
    public partial class Sample1 : Form
    {
        public Sample1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Sample1_Load(object sender, EventArgs e)
        {
            if (Authentication.login.USERID > 0)
            {
                label2.Text = Authentication.login.NAME;
            }
            else
            {
                label2.Text = "User";
            }
        }
    }
}
