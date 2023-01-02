namespace HMS
{
    partial class TurnWindow
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.left_panel.SuspendLayout();
            this.backBtnPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Size = new System.Drawing.Size(350, 654);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(350, 588);
            // 
            // backBtnPanel
            // 
            this.backBtnPanel.Size = new System.Drawing.Size(350, 66);
            // 
            // usernamePanel
            // 
            this.usernamePanel.Size = new System.Drawing.Size(593, 66);
            // 
            // right_panel
            // 
            this.right_panel.Location = new System.Drawing.Point(350, 0);
            this.right_panel.Size = new System.Drawing.Size(593, 654);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.turnLabel);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Size = new System.Drawing.Size(593, 588);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(226, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Turn Number...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 1;
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(187, 195);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(189, 221);
            this.turnLabel.TabIndex = 2;
            this.turnLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TurnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 654);
            this.ControlBox = true;
            this.Name = "TurnWindow";
            this.Text = "TurnWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurnWindow_FormClosing);
            this.Load += new System.EventHandler(this.TurnWindow_Load);
            this.left_panel.ResumeLayout(false);
            this.backBtnPanel.ResumeLayout(false);
            this.usernamePanel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}