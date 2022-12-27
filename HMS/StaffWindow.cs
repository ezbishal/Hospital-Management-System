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
using System.Collections;

namespace HMS
{
    public partial class StaffWindow : Sample2
    {
        public StaffWindow()
        {
            InitializeComponent();
        }

        private void loadUsers()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(userIDGV);
            loadDa.Items.Add(nameGV);
            loadDa.Items.Add(usernameGV);
            loadDa.Items.Add(passGV);
            loadDa.Items.Add(phoneGV);
            loadDa.Items.Add(addressGV);
            loadDa.Items.Add(roleIDGV);
            loadDa.Items.Add(RoleGV);

            crud.loadData("st_getUsers", dataGridView1, loadDa);
        }
        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if(nameTxt.Text == "") { nameTxt.BackColor = Color.Firebrick; } else { nameTxt.BackColor = Color.White;}
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (userTxt.Text == "") { userTxt.BackColor = Color.Firebrick; } else { userTxt.BackColor = Color.White; }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { passwordTxt.BackColor = Color.Firebrick; } else { passwordTxt.BackColor = Color.White; }

        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneTxt.BackColor = Color.Firebrick; } else { phoneTxt.BackColor = Color.White; }

        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "") { addressTxt.BackColor = Color.Firebrick; } else { addressTxt.BackColor = Color.White; }

        }

        private void roleDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleDD.SelectedIndex == -1) { roleDD.BackColor = Color.Firebrick; } else { roleDD.BackColor = Color.White; }

        }

        int userID = 0;

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
                    ht.Add("@name",nameTxt.Text);
                    ht.Add("@uname",userTxt.Text);
                    ht.Add("@password",passwordTxt.Text);
                    ht.Add("@phone",phoneTxt.Text);
                    ht.Add("@address",addressTxt.Text);
                    ht.Add("@roleID",Convert.ToInt32(roleDD.SelectedValue.ToString()));

                    if (crud.insert_update_delete("st_insertUsers", ht) > 0)
                    {
                        MainClass.showMessage(nameTxt.Text + " added successfully!", "success");
                        MainClass.resetDisable(leftPanel);
                        loadUsers();
                    }
                    else
                    {
                        MainClass.showMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1) //Code for update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    ht.Add("@uname", userTxt.Text);
                    ht.Add("@password", passwordTxt.Text);
                    ht.Add("@phone", phoneTxt.Text);
                    ht.Add("@address", addressTxt.Text);
                    ht.Add("@roleID", Convert.ToInt32(roleDD.SelectedValue.ToString()));
                    ht.Add("@id", userID);

                    if (crud.insert_update_delete("st_upadateUsers", ht) > 0)
                    {
                        MainClass.showMessage(nameTxt.Text + " updated successfully into the system", "success");
                        MainClass.resetDisable(leftPanel);
                        loadUsers();
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
                    ht.Add("@id", userID);

                    if (crud.insert_update_delete("st_deleteUsers", ht) > 0)
                    {
                        MainClass.showMessage(nameTxt.Text + " deleted successfully from the system.", "success");
                        MainClass.resetDisable(leftPanel);
                        loadUsers();
                    }
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGV"].Value.ToString();
                nameTxt.Text = row.Cells["usernameGV"].Value.ToString();
                nameTxt.Text = row.Cells["passwordGV"].Value.ToString();
                nameTxt.Text = row.Cells["phoneGV"].Value.ToString();
                nameTxt.Text = row.Cells["addressGV"].Value.ToString();
                roleDD.SelectedValue = row.Cells["roleIDGV"].Value;

            }
        }

        private void StaffWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            crud.loadList("st_getRoles", roleDD, "ID", "Role", ht);
        }
    }
}
