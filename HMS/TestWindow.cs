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
using CRUD;
using System.Collections;

namespace HMS
{
    public partial class TestWindow : Sample2
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void loadTests()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(testIDGV);
            loadDa.Items.Add(testGV);
            loadDa.Items.Add(priceGV);
            loadDa.Items.Add(precautionsGV);

            crud.loadData("st_getTests", dataGridView1, loadDa);
        }

        int testID = 0;
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
                    ht.Add("@name", testTxt.Text);
                    ht.Add("@price",Convert.ToInt32(priceTxt.Text));
                    ht.Add("@prec", precautionsTxt.Text);


                    if (crud.insert_update_delete("st_insertTests", ht) > 0)
                    {
                        MainClass.showMessage(testTxt.Text + " added successfully!", "success");
                        MainClass.resetDisable(leftPanel);
                        loadTests();
                    }
                    else
                    {
                        MainClass.showMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1) //Code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", testTxt.Text);
                    ht.Add("@price", priceTxt.Text);
                    ht.Add("@prec", precautionsTxt.Text);
                    ht.Add("@id", testID);

                    if (crud.insert_update_delete("st_updateTests", ht) > 0)
                    {
                        MainClass.showMessage(testTxt.Text + " updated successfully into the system", "success");
                        MainClass.resetDisable(leftPanel);
                        loadTests();
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
                    ht.Add("@id", testID);

                    if (crud.insert_update_delete("st_deleteTest", ht) > 0)
                    {
                        MainClass.showMessage(testTxt.Text + " deleted successfully from the system.", "success");
                        MainClass.resetDisable(leftPanel);
                        loadTests();
                    }
                }
                edit = 0;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TestWindow_Load(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click_1(object sender, EventArgs e)
        {
            loadTests();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (testTxt.Text == "") { testTxt.BackColor = Color.Firebrick; } else { testTxt.BackColor = Color.White; }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (priceTxt.Text == "") { priceTxt.BackColor = Color.Firebrick; } else { priceTxt.BackColor = Color.White; }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (precautionsTxt.Text == "") { precautionsTxt.BackColor = Color.Firebrick; } else { precautionsTxt.BackColor = Color.White; }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; 
                testID = Convert.ToInt32(row.Cells["testIDGV"].Value.ToString());
                testTxt.Text = row.Cells["testGV"].Value.ToString();
                decimal money = (decimal)row.Cells["priceGV"].Value;
                priceTxt.Text = String.Format("{0:0.0}", Math.Truncate(money * 10) / 10);
                precautionsTxt.Text = row.Cells["precautionsGV"].Value.ToString();

            }
        }
    }
}
