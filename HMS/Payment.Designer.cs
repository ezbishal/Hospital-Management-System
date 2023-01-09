
namespace HMS
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loadBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptDTGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prtBtnGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.left_panel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.backBtnPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(309, 682);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.loadBtn);
            this.leftPanel.Controls.Add(this.dateTimePicker1);
            this.leftPanel.Location = new System.Drawing.Point(0, 70);
            this.leftPanel.Size = new System.Drawing.Size(309, 612);
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.Controls.Add(this.backBtn);
            this.backBtnPanel.Size = new System.Drawing.Size(309, 70);
            this.backBtnPanel.Controls.SetChildIndex(this.label1, 0);
            this.backBtnPanel.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Size = new System.Drawing.Size(1014, 70);
            // 
            // right_panel
            // 
            this.right_panel.Location = new System.Drawing.Point(309, 0);
            this.right_panel.Size = new System.Drawing.Size(1014, 682);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView2);
            this.rightPanel.Location = new System.Drawing.Point(0, 70);
            this.rightPanel.Size = new System.Drawing.Size(1014, 612);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(185, 0);
            this.label1.Size = new System.Drawing.Size(124, 70);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(609, 70);
            // 
            // loadBtn
            // 
            this.loadBtn.FlatAppearance.BorderSize = 2;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.Location = new System.Drawing.Point(25, 143);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(249, 38);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "LOAD";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(25, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(61, 51);
            this.backBtn.TabIndex = 6;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.turnGV,
            this.patientIDGV,
            this.patientGV,
            this.guardianGV,
            this.ageGV,
            this.phoneGV,
            this.apptDTGV,
            this.doctorGV,
            this.doctorIDGV,
            this.apptIDGV,
            this.statusGV,
            this.prtBtnGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1014, 612);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 47;
            // 
            // turnGV
            // 
            this.turnGV.HeaderText = "Turn";
            this.turnGV.MinimumWidth = 6;
            this.turnGV.Name = "turnGV";
            this.turnGV.ReadOnly = true;
            // 
            // patientIDGV
            // 
            this.patientIDGV.HeaderText = "ID";
            this.patientIDGV.MinimumWidth = 6;
            this.patientIDGV.Name = "patientIDGV";
            this.patientIDGV.ReadOnly = true;
            this.patientIDGV.Visible = false;
            // 
            // patientGV
            // 
            this.patientGV.HeaderText = "Patient";
            this.patientGV.MinimumWidth = 6;
            this.patientGV.Name = "patientGV";
            this.patientGV.ReadOnly = true;
            // 
            // guardianGV
            // 
            this.guardianGV.HeaderText = "Guardian";
            this.guardianGV.MinimumWidth = 6;
            this.guardianGV.Name = "guardianGV";
            this.guardianGV.ReadOnly = true;
            // 
            // ageGV
            // 
            this.ageGV.HeaderText = "Age";
            this.ageGV.MinimumWidth = 6;
            this.ageGV.Name = "ageGV";
            this.ageGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.MinimumWidth = 6;
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // apptDTGV
            // 
            this.apptDTGV.HeaderText = "Appointment Date";
            this.apptDTGV.MinimumWidth = 6;
            this.apptDTGV.Name = "apptDTGV";
            this.apptDTGV.ReadOnly = true;
            // 
            // doctorGV
            // 
            this.doctorGV.HeaderText = "Doctor";
            this.doctorGV.MinimumWidth = 6;
            this.doctorGV.Name = "doctorGV";
            this.doctorGV.ReadOnly = true;
            // 
            // doctorIDGV
            // 
            this.doctorIDGV.HeaderText = "DoctorID";
            this.doctorIDGV.MinimumWidth = 6;
            this.doctorIDGV.Name = "doctorIDGV";
            this.doctorIDGV.ReadOnly = true;
            this.doctorIDGV.Visible = false;
            // 
            // apptIDGV
            // 
            this.apptIDGV.HeaderText = "Appointment ID";
            this.apptIDGV.MinimumWidth = 6;
            this.apptIDGV.Name = "apptIDGV";
            this.apptIDGV.ReadOnly = true;
            this.apptIDGV.Visible = false;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // prtBtnGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.prtBtnGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.prtBtnGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prtBtnGV.HeaderText = "Action";
            this.prtBtnGV.MinimumWidth = 6;
            this.prtBtnGV.Name = "prtBtnGV";
            this.prtBtnGV.ReadOnly = true;
            this.prtBtnGV.Text = "";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 682);
            this.Name = "Payment";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            this.left_panel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.backBtnPanel.ResumeLayout(false);
            this.usernamePanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptDTGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewButtonColumn prtBtnGV;
    }
}