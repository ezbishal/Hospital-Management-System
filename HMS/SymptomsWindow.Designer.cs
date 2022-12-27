namespace HMS
{
    partial class SymptomsWindow
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
            this.label4 = new System.Windows.Forms.Label();
            this.symptomTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.diseaseDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sympIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sympGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(511, 71);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Size = new System.Drawing.Size(511, 313);
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(289, 450);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.diseaseDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.symptomTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Size = new System.Drawing.Size(289, 384);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.symptomTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.diseaseDD, 0);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Size = new System.Drawing.Size(511, 66);
            // 
            // right_panel
            // 
            this.right_panel.Size = new System.Drawing.Size(511, 450);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(511, 384);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Symptom\r\n";
            // 
            // symptomTxt
            // 
            this.symptomTxt.Location = new System.Drawing.Point(12, 127);
            this.symptomTxt.Name = "symptomTxt";
            this.symptomTxt.Size = new System.Drawing.Size(251, 27);
            this.symptomTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Disease";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // diseaseDD
            // 
            this.diseaseDD.Enabled = false;
            this.diseaseDD.FormattingEnabled = true;
            this.diseaseDD.Location = new System.Drawing.Point(12, 214);
            this.diseaseDD.Name = "diseaseDD";
            this.diseaseDD.Size = new System.Drawing.Size(251, 28);
            this.diseaseDD.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.sympIDGV,
            this.sympGV,
            this.diseaseIDGV,
            this.diseaseGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 287);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.MinimumWidth = 6;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 47;
            // 
            // sympIDGV
            // 
            this.sympIDGV.HeaderText = "SymptomID";
            this.sympIDGV.MinimumWidth = 6;
            this.sympIDGV.Name = "sympIDGV";
            this.sympIDGV.ReadOnly = true;
            this.sympIDGV.Visible = false;
            // 
            // sympGV
            // 
            this.sympGV.HeaderText = "Symptom";
            this.sympGV.MinimumWidth = 6;
            this.sympGV.Name = "sympGV";
            this.sympGV.ReadOnly = true;
            // 
            // diseaseIDGV
            // 
            this.diseaseIDGV.HeaderText = "DiseaseID";
            this.diseaseIDGV.MinimumWidth = 6;
            this.diseaseIDGV.Name = "diseaseIDGV";
            this.diseaseIDGV.ReadOnly = true;
            this.diseaseIDGV.Visible = false;
            // 
            // diseaseGV
            // 
            this.diseaseGV.HeaderText = "Disease";
            this.diseaseGV.MinimumWidth = 6;
            this.diseaseGV.Name = "diseaseGV";
            this.diseaseGV.ReadOnly = true;
            // 
            // SymptomsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "SymptomsWindow";
            this.Text = "SymptomsWindow";
            this.Load += new System.EventHandler(this.SymptomsWindow_Load);
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

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox diseaseDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox symptomTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sympIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sympGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseGV;
    }
}