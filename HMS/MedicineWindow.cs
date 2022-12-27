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
    public partial class MedicineWindow : Sample2
    {
        public MedicineWindow()
        {
            InitializeComponent();
        }

        private void loadMedicine()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(medicineIDGV);
            loadDa.Items.Add(medicineGV);
            loadDa.Items.Add(typeGV);
            loadDa.Items.Add(companyGV);

            crud.loadData("st_getMedicine", dataGridView1, loadDa);
        }
        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MedicineWindow_Load(object sender, EventArgs e)
        {

        }

        int medID = 0;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count > 0)
            {
                MainClass.showMessage("Fields with RED are mandatory!", "error");
            }
            else
            {
                if (edit == 0) // Code for save
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", medicineTxt.Text);
                    if(companyTxt.Text == "")
                    {
                        ht.Add("@comp", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@comp", companyTxt.Text);
                    }
                    ht.Add("@type", typeDD.SelectedIndex);
                    

                    if (crud.insert_update_delete("st_insertMedicine", ht) > 0)
                    {
                        MainClass.showMessage(medicineTxt.Text + " added successfully!", "success");
                        MainClass.resetDisable(leftPanel);
                        loadMedicine();
                    }
                    else
                    {
                        MainClass.showMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1) //Code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", medicineTxt.Text);
                    if (companyTxt.Text == "")
                    {
                        ht.Add("@comp", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@comp", companyTxt.Text);
                    }
                    ht.Add("@type", typeDD.SelectedIndex);
                    ht.Add("@id", medID);

                    if (crud.insert_update_delete("st_updateMedicine", ht) > 0)
                    {
                        MainClass.showMessage(medicineTxt.Text + " updated successfully into the system", "success");
                        MainClass.resetDisable(leftPanel);
                        loadMedicine();
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
                    ht.Add("@id", medID);

                    if (crud.insert_update_delete("st_deleteMedicine", ht) > 0)
                    {
                        MainClass.showMessage(medicineTxt.Text + " deleted successfully from the system.", "success");
                        MainClass.resetDisable(leftPanel);
                        loadMedicine();
                    }
                }
            }

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadMedicine();
        }

        private void medicineTxt_TextChanged(object sender, EventArgs e)
        {
            if(medicineTxt.Text == "") { medicineTxt.BackColor = Color.Firebrick; } else { medicineTxt.BackColor = Color.White; }
        }

        private void typeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeDD.SelectedIndex == -1) { typeDD.BackColor = Color.Firebrick; } else { typeDD.BackColor = Color.White; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                medID = Convert.ToInt32(row.Cells["medicineIDGV"].Value.ToString());
                medicineTxt.Text = row.Cells["medicineGV"].Value.ToString();
                companyTxt.Text = row.Cells["companyGV"].Value.ToString();
                typeDD.SelectedItem = row.Cells["typeGV"].Value.ToString();

            }
        }
    }
}
