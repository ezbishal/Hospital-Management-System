using HMS.Properties;

namespace HMS
{
    partial class AdminHomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.staffBtn = new System.Windows.Forms.Button();
            this.roleBtn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.checkupBtn = new System.Windows.Forms.Button();
            this.symptomBtn = new System.Windows.Forms.Button();
            this.diseaseBtn = new System.Windows.Forms.Button();
            this.medicineBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.turnScreenBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.left_panel.SuspendLayout();
            this.backBtnPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(289, 688);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(289, 622);
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.Size = new System.Drawing.Size(289, 66);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Size = new System.Drawing.Size(918, 66);
            // 
            // right_panel
            // 
            this.right_panel.Location = new System.Drawing.Point(289, 0);
            this.right_panel.Size = new System.Drawing.Size(918, 688);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(918, 622);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(165, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.staffBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.roleBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientsBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkupBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.symptomBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.diseaseBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.medicineBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.testBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.turnScreenBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.reportBtn, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 622);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // staffBtn
            // 
            this.staffBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffBtn.FlatAppearance.BorderSize = 2;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Image = global::HMS.Properties.Resources.staff;
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.staffBtn.Location = new System.Drawing.Point(232, 3);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(223, 149);
            this.staffBtn.TabIndex = 1;
            this.staffBtn.Text = "Staff";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // roleBtn
            // 
            this.roleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleBtn.FlatAppearance.BorderSize = 2;
            this.roleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleBtn.Image = global::HMS.Properties.Resources.roles;
            this.roleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roleBtn.Location = new System.Drawing.Point(3, 3);
            this.roleBtn.Name = "roleBtn";
            this.roleBtn.Size = new System.Drawing.Size(223, 149);
            this.roleBtn.TabIndex = 16;
            this.roleBtn.Text = "Roles";
            this.roleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roleBtn.UseVisualStyleBackColor = true;
            this.roleBtn.Click += new System.EventHandler(this.roleBtn_Click_2);
            // 
            // patientsBtn
            // 
            this.patientsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientsBtn.FlatAppearance.BorderSize = 2;
            this.patientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsBtn.Image = global::HMS.Properties.Resources.patient;
            this.patientsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.patientsBtn.Location = new System.Drawing.Point(461, 3);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Size = new System.Drawing.Size(223, 149);
            this.patientsBtn.TabIndex = 3;
            this.patientsBtn.Text = "Patients";
            this.patientsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.patientsBtn.UseVisualStyleBackColor = true;
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click);
            // 
            // checkupBtn
            // 
            this.checkupBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkupBtn.FlatAppearance.BorderSize = 2;
            this.checkupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkupBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkupBtn.Image = global::HMS.Properties.Resources.checkup;
            this.checkupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkupBtn.Location = new System.Drawing.Point(690, 3);
            this.checkupBtn.Name = "checkupBtn";
            this.checkupBtn.Size = new System.Drawing.Size(225, 149);
            this.checkupBtn.TabIndex = 8;
            this.checkupBtn.Text = "Check Up";
            this.checkupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkupBtn.UseVisualStyleBackColor = true;
            this.checkupBtn.Click += new System.EventHandler(this.checkupBtn_Click);
            // 
            // symptomBtn
            // 
            this.symptomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symptomBtn.FlatAppearance.BorderSize = 2;
            this.symptomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.symptomBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomBtn.Image = global::HMS.Properties.Resources.symptom;
            this.symptomBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.symptomBtn.Location = new System.Drawing.Point(3, 158);
            this.symptomBtn.Name = "symptomBtn";
            this.symptomBtn.Size = new System.Drawing.Size(223, 149);
            this.symptomBtn.TabIndex = 6;
            this.symptomBtn.Text = "Symptoms";
            this.symptomBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.symptomBtn.UseVisualStyleBackColor = true;
            this.symptomBtn.Click += new System.EventHandler(this.symptomBtn_Click);
            // 
            // diseaseBtn
            // 
            this.diseaseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diseaseBtn.FlatAppearance.BorderSize = 2;
            this.diseaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseaseBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseaseBtn.Image = global::HMS.Properties.Resources.disease;
            this.diseaseBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.diseaseBtn.Location = new System.Drawing.Point(232, 158);
            this.diseaseBtn.Name = "diseaseBtn";
            this.diseaseBtn.Size = new System.Drawing.Size(223, 149);
            this.diseaseBtn.TabIndex = 5;
            this.diseaseBtn.Text = "Diseases";
            this.diseaseBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.diseaseBtn.UseVisualStyleBackColor = true;
            this.diseaseBtn.Click += new System.EventHandler(this.diseaseBtn_Click);
            // 
            // medicineBtn
            // 
            this.medicineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineBtn.FlatAppearance.BorderSize = 2;
            this.medicineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicineBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineBtn.Image = global::HMS.Properties.Resources.medicine;
            this.medicineBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.medicineBtn.Location = new System.Drawing.Point(461, 158);
            this.medicineBtn.Name = "medicineBtn";
            this.medicineBtn.Size = new System.Drawing.Size(223, 149);
            this.medicineBtn.TabIndex = 2;
            this.medicineBtn.Text = "Medicine";
            this.medicineBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.medicineBtn.UseVisualStyleBackColor = true;
            this.medicineBtn.Click += new System.EventHandler(this.medicineBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testBtn.FlatAppearance.BorderSize = 2;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn.Image = global::HMS.Properties.Resources.test;
            this.testBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.testBtn.Location = new System.Drawing.Point(690, 158);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(225, 149);
            this.testBtn.TabIndex = 9;
            this.testBtn.Text = "Tests";
            this.testBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // turnScreenBtn
            // 
            this.turnScreenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnScreenBtn.FlatAppearance.BorderSize = 2;
            this.turnScreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnScreenBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnScreenBtn.Image = global::HMS.Properties.Resources.turnScreen;
            this.turnScreenBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.turnScreenBtn.Location = new System.Drawing.Point(3, 313);
            this.turnScreenBtn.Name = "turnScreenBtn";
            this.turnScreenBtn.Size = new System.Drawing.Size(223, 149);
            this.turnScreenBtn.TabIndex = 7;
            this.turnScreenBtn.Text = "Turn Screen";
            this.turnScreenBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.turnScreenBtn.UseVisualStyleBackColor = true;
            this.turnScreenBtn.Click += new System.EventHandler(this.turnScreenBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBtn.FlatAppearance.BorderSize = 2;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Image = global::HMS.Properties.Resources.report;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportBtn.Location = new System.Drawing.Point(232, 313);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(223, 149);
            this.reportBtn.TabIndex = 18;
            this.reportBtn.Text = "Report and Payment";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 688);
            this.Name = "AdminHomeScreen";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.AdminHomeScreen_Load);
            this.left_panel.ResumeLayout(false);
            this.backBtnPanel.ResumeLayout(false);
            this.usernamePanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button checkupBtn;
        private System.Windows.Forms.Button turnScreenBtn;
        private System.Windows.Forms.Button symptomBtn;
        private System.Windows.Forms.Button diseaseBtn;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Button medicineBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button roleBtn;
        private System.Windows.Forms.Button reportBtn;
    }
}