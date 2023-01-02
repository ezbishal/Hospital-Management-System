namespace HMS
{
    partial class MedicineWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.medicineTxt = new System.Windows.Forms.TextBox();
            this.companyTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typeDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.backBtnPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(289, 71);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Size = new System.Drawing.Size(840, 390);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(840, 71);
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(289, 531);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.typeDD);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.companyTxt);
            this.leftPanel.Controls.Add(this.medicineTxt);
            this.leftPanel.Size = new System.Drawing.Size(289, 461);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.medicineTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.companyTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.typeDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.Size = new System.Drawing.Size(289, 70);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Size = new System.Drawing.Size(840, 70);
            // 
            // right_panel
            // 
            this.right_panel.Location = new System.Drawing.Point(289, 0);
            this.right_panel.Size = new System.Drawing.Size(840, 531);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(840, 461);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(165, 0);
            // 
            // medicineTxt
            // 
            this.medicineTxt.Enabled = false;
            this.medicineTxt.Location = new System.Drawing.Point(12, 147);
            this.medicineTxt.MaxLength = 100;
            this.medicineTxt.Name = "medicineTxt";
            this.medicineTxt.Size = new System.Drawing.Size(254, 27);
            this.medicineTxt.TabIndex = 2;
            this.medicineTxt.TextChanged += new System.EventHandler(this.medicineTxt_TextChanged);
            // 
            // companyTxt
            // 
            this.companyTxt.AllowDrop = true;
            this.companyTxt.Enabled = false;
            this.companyTxt.Location = new System.Drawing.Point(12, 220);
            this.companyTxt.MaxLength = 100;
            this.companyTxt.Name = "companyTxt";
            this.companyTxt.Size = new System.Drawing.Size(254, 27);
            this.companyTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type";
            // 
            // typeDD
            // 
            this.typeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeDD.Enabled = false;
            this.typeDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeDD.FormattingEnabled = true;
            this.typeDD.Items.AddRange(new object[] {
            "Internal",
            "External"});
            this.typeDD.Location = new System.Drawing.Point(12, 296);
            this.typeDD.Name = "typeDD";
            this.typeDD.Size = new System.Drawing.Size(254, 28);
            this.typeDD.TabIndex = 6;
            this.typeDD.SelectedIndexChanged += new System.EventHandler(this.typeDD_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.medicineIDGV,
            this.medicineGV,
            this.companyGV,
            this.typeGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(834, 357);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.MinimumWidth = 6;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 53;
            // 
            // medicineIDGV
            // 
            this.medicineIDGV.HeaderText = "MedID";
            this.medicineIDGV.MinimumWidth = 6;
            this.medicineIDGV.Name = "medicineIDGV";
            this.medicineIDGV.ReadOnly = true;
            this.medicineIDGV.Visible = false;
            // 
            // medicineGV
            // 
            this.medicineGV.HeaderText = "Medicine";
            this.medicineGV.MinimumWidth = 6;
            this.medicineGV.Name = "medicineGV";
            this.medicineGV.ReadOnly = true;
            // 
            // companyGV
            // 
            this.companyGV.HeaderText = "Company";
            this.companyGV.MinimumWidth = 6;
            this.companyGV.Name = "companyGV";
            this.companyGV.ReadOnly = true;
            // 
            // typeGV
            // 
            this.typeGV.HeaderText = "Type";
            this.typeGV.MinimumWidth = 6;
            this.typeGV.Name = "typeGV";
            this.typeGV.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Medicine";
            // 
            // MedicineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 531);
            this.Name = "MedicineWindow";
            this.Text = "Medicine Window";
            this.Load += new System.EventHandler(this.MedicineWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.backBtnPanel.ResumeLayout(false);
            this.usernamePanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox medicineTxt;
        private System.Windows.Forms.ComboBox typeDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companyTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}