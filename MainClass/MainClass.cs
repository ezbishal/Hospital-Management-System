﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public static class MainClass
    {

        public static void sno(DataGridView gv, string snoGV)
        {
            int count = 0;
            foreach(DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[snoGV].Value = count;
            }
        }

        private static string path;

        private static string connectionString()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\hms_connect";

            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return "";
            }
        }

        public static SqlConnection con = new SqlConnection(connectionString());
        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }

        public static void showWindow(Form openWin, Form MDI)
        {
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }

        public static void showMessage(string msg, string type)
        {
            if (type == "success")
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void resetEnable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.TabStop == false)
                    {

                    }
                    else
                    {
                        tb.Text = "";
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.TabStop== false)
                    {

                    }
                    else
                    {
                        cb.SelectedIndex = -1;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }
                    
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.TabStop == false)
                    {

                    }
                    else
                    {
                        rb.Checked = false;
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                    
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Checked = false;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }
                    
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                        cb.Value = 0;
                    }
                    
                }
                if(c is Button)
                {
                    Button cb = (Button)c;
                    if(cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if(c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    if (dt.TabStop== false)
                    {

                    }
                    else
                    {
                        dt.Value = DateTime.Now;
                        dt.Enabled = true;
                    }
                }

            }
        }

        public static void resetDisable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;
                    tb.BackColor = Color.White;
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                    rb.BackColor = Color.White;
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                    cb.Value = 0;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = false;
                }
            }
        }

        public static void EnableControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if(tb.TabStop == false)
                    {

                    }
                    else
                    {
                        tb.Enabled = true;
                    }
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if(cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if(rb.TabStop == false)
                    {

                    }
                    else
                    {
                        rb.Enabled = true;
                    }
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if(cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if(cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    if(cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    if (dt.TabStop== false)
                    {

                    }
                    else
                    {
                        dt.Enabled = true;
                    }
                }
            }
        }

        public static void DisableControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = false;
                }
            }
        }

        public static ArrayList checkControls(Panel p)
        {
            ArrayList arr = new ArrayList();
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;

                    if (tb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (tb.Text == "")
                        {
                            arr.Add(tb);
                        }
                        else
                        {
                            if (arr.Contains(tb))
                            {
                                arr.Remove(tb);
                            }
                        }
                    }
                    tb.BackColor = tb.Text == "" ? tb.BackColor = Color.Firebrick : tb.BackColor = Color.White;

                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;

                    if (cb.AllowDrop == true)
                    {

                    }
                    else 
                    {
                        if (cb.SelectedIndex == -1)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }
                        }
                    }
                    cb.BackColor = cb.SelectedIndex == -1 ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;

                    if (rb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (!rb.Checked)
                        {
                            arr.Add(rb);
                        }
                        else
                        {
                            if (arr.Contains(rb))
                            {
                                arr.Remove(rb);
                            }
                        }
                    }
                    rb.BackColor = !rb.Checked ? rb.BackColor = Color.Firebrick : rb.BackColor = Color.White;
                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.AllowDrop == true)
                    {

                    }
                    else
                    {

                        if (!cb.Checked)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }
                        }
                    }
                    cb.BackColor = !cb.Checked ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.Value == 0)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                    cb.BackColor = cb.Value == 0 ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                }
                /*if(c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    if(dt.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (dt.Value < DateTime.Today)
                        {
                            arr.Add(dt);
                        }
                        else
                        {
                            if (arr.Contains(dt))
                            {
                                arr.Remove(dt);
                            }
                        }
                        dt.CalendarTitleBackColor = dt.Value < DateTime.Today ? dt.CalendarTitleBackColor = Color.Firebrick : dt.CalendarTitleBackColor = Color.White;
                    }
                }*/
            }

            return arr;
        }

    }

}
