namespace AlgorytmySzkolne.ContentUCs
{
    partial class Hetman
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hetman));
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.RestartButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.HetmanProgressBar = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel1
			// 
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new System.Drawing.Point(0, 39);
			this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(533, 480);
			this.Panel1.TabIndex = 0;
			// 
			// Panel2
			// 
			this.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Panel2.Controls.Add(this.RestartButton);
			this.Panel2.Controls.Add(this.label2);
			this.Panel2.Controls.Add(this.HetmanProgressBar);
			this.Panel2.Controls.Add(this.label1);
			this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(533, 39);
			this.Panel2.TabIndex = 1;
			// 
			// RestartButton
			// 
			this.RestartButton.Location = new System.Drawing.Point(452, 7);
			this.RestartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.RestartButton.Name = "RestartButton";
			this.RestartButton.Size = new System.Drawing.Size(78, 30);
			this.RestartButton.TabIndex = 3;
			this.RestartButton.Text = "Restart";
			this.RestartButton.UseVisualStyleBackColor = true;
			this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(402, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = " z 8";
			// 
			// HetmanProgressBar
			// 
			this.HetmanProgressBar.Location = new System.Drawing.Point(207, 9);
			this.HetmanProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.HetmanProgressBar.Maximum = 8;
			this.HetmanProgressBar.Name = "HetmanProgressBar";
			this.HetmanProgressBar.Size = new System.Drawing.Size(144, 23);
			this.HetmanProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.HetmanProgressBar.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(4, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ilość hetmanów";
			// 
			// Hetman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 519);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Hetman";
			this.Text = "Hetman";
			this.Load += new System.EventHandler(this.Hetman_Load);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar HetmanProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RestartButton;
    }
}