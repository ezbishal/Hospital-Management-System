namespace HMS
{
    partial class Sample1
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
            this.left_panel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.backBtnPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.right_panel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.left_panel.SuspendLayout();
            this.backBtnPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.left_panel.Controls.Add(this.leftPanel);
            this.left_panel.Controls.Add(this.backBtnPanel);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.ForeColor = System.Drawing.Color.White;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(369, 745);
            this.left_panel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.ForeColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(0, 66);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(369, 679);
            this.leftPanel.TabIndex = 1;
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.backBtnPanel.Controls.Add(this.label1);
            this.backBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backBtnPanel.ForeColor = System.Drawing.Color.White;
            this.backBtnPanel.Location = new System.Drawing.Point(0, 0);
            this.backBtnPanel.Name = "backBtnPanel";
            this.backBtnPanel.Size = new System.Drawing.Size(369, 66);
            this.backBtnPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Controls.Add(this.label2);
            this.usernamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernamePanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.usernamePanel.Location = new System.Drawing.Point(0, 0);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(806, 66);
            this.usernamePanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 66);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseMnemonic = false;
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.rightPanel);
            this.right_panel.Controls.Add(this.usernamePanel);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.ForeColor = System.Drawing.Color.SteelBlue;
            this.right_panel.Location = new System.Drawing.Point(369, 0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(806, 745);
            this.right_panel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.rightPanel.Location = new System.Drawing.Point(0, 66);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(806, 679);
            this.rightPanel.TabIndex = 2;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Sample1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 745);
            this.ControlBox = false;
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.left_panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sample1";
            this.Load += new System.EventHandler(this.Sample1_Load);
            this.left_panel.ResumeLayout(false);
            this.backBtnPanel.ResumeLayout(false);
            this.usernamePanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel left_panel;
        protected System.Windows.Forms.Panel leftPanel;
        protected System.Windows.Forms.Panel backBtnPanel;
        protected System.Windows.Forms.Panel usernamePanel;
        protected System.Windows.Forms.Panel right_panel;
        protected System.Windows.Forms.Panel rightPanel;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
    }
}

