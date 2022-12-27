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
using Classes;
using CRUD;

namespace HMS
{
    public partial class SymptomsWindow : Sample2
    {
        public SymptomsWindow()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SymptomsWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            crud.loadList("st_getDiseases", diseaseDD, "ID", "Disease", ht);
        }

        private void loadSymptoms()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(sympIDGV);
            loadDa.Items.Add(sympGV);
            loadDa.Items.Add(diseaseIDGV);
            loadDa.Items.Add(diseaseGV);

            crud.loadData("st_getSymptoms", dataGridView1, loadDa);
        }

        Int64 symptomID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count > 0)
            {
                MainClass.showMessage("Fields with RED are mandatory.", "error");
            }
            else
            {
                if (edit == 0) // for SAVE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@symptom", symptomTxt.Text);
                    ht.Add("@did", Convert.ToInt32(diseaseDD.SelectedValue.ToString()));


                    if (crud.insert_update_delete("st_insertSymptoms", ht) > 0)
                    {
                        MainClass.showMessage(symptomTxt.Text + " added successfully!", "success");
                        MainClass.resetDisable(leftPanel);
                        loadSymptoms();
                    }
                    else
                    {
                        MainClass.showMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1) // for UPDATE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@symptom", symptomTxt.Text);
                    ht.Add("@did", Convert.ToInt32(diseaseDD.SelectedValue.ToString()));
                    ht.Add("@sid", symptomID);

                    if (crud.insert_update_delete("st_updateSymptom", ht) > 0)
                    {
                        MainClass.showMessage(symptomTxt.Text + " updated successfully into the system", "success");
                        MainClass.resetDisable(leftPanel);
                        loadSymptoms();
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@sid", symptomID);

                    if (crud.insert_update_delete("st_deleteSymptom", ht) > 0)
                    {
                        MainClass.showMessage(symptomTxt.Text + " deleted successfully from the system.", "success");
                        MainClass.resetDisable(leftPanel);
                        loadSymptoms();
                    }
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                symptomID = Convert.ToInt64(row.Cells["sympIDGV"].Value.ToString());
                symptomTxt.Text = row.Cells["sympGV"].Value.ToString();
                diseaseDD.SelectedValue = row.Cells["diseaseIDGV"].Value;
            }
        }
    }
}
