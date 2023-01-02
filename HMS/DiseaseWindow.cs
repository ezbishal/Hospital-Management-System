using Classes;
using CRUD;
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

namespace HMS
{
    public partial class DiseaseWindow : Sample2
    {
        public DiseaseWindow()
        {
            InitializeComponent();
        }

        private void DiseaseWindow_Load(object sender, EventArgs e)
        {

        }

        private void loadDiseases()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(diseaseIDGV);
            loadDa.Items.Add(diseaseGV);
            crud.loadData("st_getDiseases", dataGridView1, loadDa);
        }

        int diseaseID;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count > 0)
            {
                MainClass.showMessage("Fields with RED are mandatory.", "error");
            }
            else
            {
                if(edit == 0) // for SAVE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@disease", diseaseTxt.Text);

                    if (crud.insert_update_delete("st_insertDisease", ht) > 0)
                    {
                        MainClass.showMessage(diseaseTxt.Text + " added successfully!", "success");
                        MainClass.resetDisable(leftPanel);
                        loadDiseases();
                    }
                    else
                    {
                        MainClass.showMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1) // for UPDATE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@disease", diseaseTxt.Text);
                    ht.Add("@did", diseaseID);

                    if (crud.insert_update_delete("st_updateDisease", ht) > 0)
                    {
                        MainClass.showMessage(diseaseTxt.Text + " updated successfully into the system", "success");
                        MainClass.resetDisable(leftPanel);
                        loadDiseases();
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
                    ht.Add("@did", diseaseID);

                    if (crud.insert_update_delete("st_deleteDisease", ht) > 0)
                    {
                        MainClass.showMessage(diseaseTxt.Text + " deleted successfully from the system.", "success");
                        MainClass.resetDisable(leftPanel);
                        loadDiseases();
                    }
                }
            }
        }

        public override void viewBtn_Click_1(object sender, EventArgs e)
        {
            loadDiseases();
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
                diseaseID = Convert.ToInt32(row.Cells["diseaseIDGV"].Value.ToString());
                diseaseTxt.Text = row.Cells["diseaseGV"].Value.ToString();
            }
        }

        private void diseaseTxt_TextChanged(object sender, EventArgs e)
        {
            if (diseaseTxt.Text == "") { diseaseTxt.BackColor = Color.Firebrick; } else { diseaseTxt.BackColor = Color.White; }

        }
    }
}
