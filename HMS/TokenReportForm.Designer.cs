namespace HMS
{
    partial class TokenReportForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.left_panel.SuspendLayout();
            this.backBtnPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(243, 713);
            // 
            // leftPanel
            // 
            this.leftPanel.Location = new System.Drawing.Point(0, 70);
            this.leftPanel.Size = new System.Drawing.Size(243, 643);
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.Size = new System.Drawing.Size(243, 70);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Size = new System.Drawing.Size(864, 70);
            // 
            // right_panel
            // 
            this.right_panel.Location = new System.Drawing.Point(243, 0);
            this.right_panel.Size = new System.Drawing.Size(864, 713);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.button1);
            this.rightPanel.Controls.Add(this.crystalReportViewer1);
            this.rightPanel.Location = new System.Drawing.Point(0, 70);
            this.rightPanel.Size = new System.Drawing.Size(864, 643);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(119, 0);
            this.label1.Size = new System.Drawing.Size(124, 70);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(609, 70);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowExportButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(864, 643);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(864, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "PRINT\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TokenReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 713);
            this.ControlBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TokenReportForm";
            this.Text = "TokenReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TokenReportForm_FormClosing);
            this.Load += new System.EventHandler(this.TokenReportForm_Load);
            this.left_panel.ResumeLayout(false);
            this.backBtnPanel.ResumeLayout(false);
            this.usernamePanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
    }
}