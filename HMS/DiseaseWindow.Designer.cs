namespace HMS
{
    partial class DiseaseWindow
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
            this.diseaseTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(289, 71);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Size = new System.Drawing.Size(742, 309);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(742, 71);
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(289, 450);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.diseaseTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Size = new System.Drawing.Size(289, 380);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.diseaseTxt, 0);
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.Size = new System.Drawing.Size(289, 70);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Size = new System.Drawing.Size(742, 70);
            // 
            // right_panel
            // 
            this.right_panel.Location = new System.Drawing.Point(289, 0);
            this.right_panel.Size = new System.Drawing.Size(742, 450);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(742, 380);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(165, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Disease";
            // 
            // diseaseTxt
            // 
            this.diseaseTxt.Location = new System.Drawing.Point(16, 126);
            this.diseaseTxt.Name = "diseaseTxt";
            this.diseaseTxt.Size = new System.Drawing.Size(267, 27);
            this.diseaseTxt.TabIndex = 2;
            this.diseaseTxt.TextChanged += new System.EventHandler(this.diseaseTxt_TextChanged);
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
            this.diseaseIDGV,
            this.diseaseGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(736, 276);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // DiseaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Name = "DiseaseWindow";
            this.Text = "DiseaseWindow";
            this.Load += new System.EventHandler(this.DiseaseWindow_Load);
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
        private System.Windows.Forms.TextBox diseaseTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseGV;
    }
}