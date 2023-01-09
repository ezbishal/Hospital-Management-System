namespace HMS
{
    partial class TestWindow
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
            this.testTxtLabel = new System.Windows.Forms.Label();
            this.testTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.priceTxtLabel = new System.Windows.Forms.Label();
            this.precautionsTxt = new System.Windows.Forms.TextBox();
            this.precautionsTxtLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precautionsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Size = new System.Drawing.Size(839, 309);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(839, 71);
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(289, 450);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.precautionsTxt);
            this.leftPanel.Controls.Add(this.precautionsTxtLabel);
            this.leftPanel.Controls.Add(this.priceTxt);
            this.leftPanel.Controls.Add(this.priceTxtLabel);
            this.leftPanel.Controls.Add(this.testTxt);
            this.leftPanel.Controls.Add(this.testTxtLabel);
            this.leftPanel.Size = new System.Drawing.Size(289, 380);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.Controls.SetChildIndex(this.testTxtLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.testTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTxtLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.precautionsTxtLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.precautionsTxt, 0);
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.Size = new System.Drawing.Size(289, 70);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Size = new System.Drawing.Size(839, 70);
            // 
            // right_panel
            // 
            this.right_panel.Location = new System.Drawing.Point(289, 0);
            this.right_panel.Size = new System.Drawing.Size(839, 450);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(839, 380);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(165, 0);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // testTxtLabel
            // 
            this.testTxtLabel.AutoSize = true;
            this.testTxtLabel.Location = new System.Drawing.Point(12, 114);
            this.testTxtLabel.Name = "testTxtLabel";
            this.testTxtLabel.Size = new System.Drawing.Size(79, 20);
            this.testTxtLabel.TabIndex = 1;
            this.testTxtLabel.Text = "Test Name";
            // 
            // testTxt
            // 
            this.testTxt.Enabled = false;
            this.testTxt.Location = new System.Drawing.Point(16, 137);
            this.testTxt.Name = "testTxt";
            this.testTxt.Size = new System.Drawing.Size(256, 27);
            this.testTxt.TabIndex = 2;
            this.testTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // priceTxt
            // 
            this.priceTxt.Enabled = false;
            this.priceTxt.Location = new System.Drawing.Point(16, 201);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(256, 27);
            this.priceTxt.TabIndex = 4;
            this.priceTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // priceTxtLabel
            // 
            this.priceTxtLabel.AutoSize = true;
            this.priceTxtLabel.Location = new System.Drawing.Point(12, 178);
            this.priceTxtLabel.Name = "priceTxtLabel";
            this.priceTxtLabel.Size = new System.Drawing.Size(41, 20);
            this.priceTxtLabel.TabIndex = 3;
            this.priceTxtLabel.Text = "Price";
            // 
            // precautionsTxt
            // 
            this.precautionsTxt.Enabled = false;
            this.precautionsTxt.Location = new System.Drawing.Point(16, 264);
            this.precautionsTxt.Name = "precautionsTxt";
            this.precautionsTxt.Size = new System.Drawing.Size(256, 27);
            this.precautionsTxt.TabIndex = 6;
            this.precautionsTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // precautionsTxtLabel
            // 
            this.precautionsTxtLabel.AutoSize = true;
            this.precautionsTxtLabel.Location = new System.Drawing.Point(12, 241);
            this.precautionsTxtLabel.Name = "precautionsTxtLabel";
            this.precautionsTxtLabel.Size = new System.Drawing.Size(85, 20);
            this.precautionsTxtLabel.TabIndex = 5;
            this.precautionsTxtLabel.Text = "Precautions";
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
            this.testGV,
            this.testIDGV,
            this.priceGV,
            this.precautionsGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
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
            this.dataGridView1.Size = new System.Drawing.Size(833, 276);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
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
            // testGV
            // 
            this.testGV.HeaderText = "Test Name";
            this.testGV.MinimumWidth = 6;
            this.testGV.Name = "testGV";
            this.testGV.ReadOnly = true;
            // 
            // testIDGV
            // 
            this.testIDGV.HeaderText = "TestID";
            this.testIDGV.MinimumWidth = 6;
            this.testIDGV.Name = "testIDGV";
            this.testIDGV.ReadOnly = true;
            this.testIDGV.Visible = false;
            // 
            // priceGV
            // 
            this.priceGV.HeaderText = "Price";
            this.priceGV.MinimumWidth = 6;
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // precautionsGV
            // 
            this.precautionsGV.HeaderText = "Precautions";
            this.precautionsGV.MinimumWidth = 6;
            this.precautionsGV.Name = "precautionsGV";
            this.precautionsGV.ReadOnly = true;
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Name = "TestWindow";
            this.Text = "TestWindow";
            this.Load += new System.EventHandler(this.TestWindow_Load);
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

        private System.Windows.Forms.TextBox precautionsTxt;
        private System.Windows.Forms.Label precautionsTxtLabel;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label priceTxtLabel;
        private System.Windows.Forms.TextBox testTxt;
        private System.Windows.Forms.Label testTxtLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn testGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn precautionsGV;
    }
}