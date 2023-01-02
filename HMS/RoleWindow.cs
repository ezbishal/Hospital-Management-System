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
using System.Security.Cryptography;
using System.Collections;

namespace HMS
{
    public partial class RoleWindow : Sample2
    {
        public RoleWindow()
        {
            InitializeComponent();
        }

        int roleID;

        private void loadRoles()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(roleIDGV);
            loadDa.Items.Add(RoleGV);
            crud.loadData("st_getRoles", dataGridView1, loadDa);
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count > 0)
            {
                MainClass.showMessage("Field with RED are mandatory.", "error");
            }
            else
            {
                if (edit == 0) // Code for save
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", roleTxt.Text);

                    if (crud.insert_update_delete("st_insertRoles", ht) > 0)
                    {
                        MainClass.showMessage(roleTxt.Text + " added successfully!", "success");
                        MainClass.resetDisable(leftPanel);
                        loadRoles();
                    }
                    else
                    {
                        MainClass.showMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1) //Code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", roleTxt.Text);
                    ht.Add("@id", roleID);

                    if (crud.insert_update_delete("st_updateRoles", ht) > 0)
                    {
                        MainClass.showMessage(roleTxt.Text + " updated successfully into the system", "success");
                        MainClass.resetDisable(leftPanel);
                        loadRoles();
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", roleID);

                    if (crud.insert_update_delete("st_deleteRoles", ht) > 0)
                    {
                        MainClass.showMessage(roleTxt.Text + " deleted successfully from the system.", "success");
                        MainClass.resetDisable(leftPanel);
                        loadRoles();
                    }
                }
            }

        }

        public override void viewBtn_Click_1(object sender, EventArgs e)
        {
            loadRoles();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString());
                roleTxt.Text = row.Cells["RoleGV"].Value.ToString();
            }
        }

        private void roleTxt_TextChanged(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleTxt.BackColor = Color.Firebrick; } else { roleTxt.BackColor = Color.White; }
        }
    }
}
