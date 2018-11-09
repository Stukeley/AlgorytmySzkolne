namespace AlgorytmySzkolne.ContentUCs
{
    partial class Aproksymacja
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aproksymacja));
			this.DrawingPanel = new System.Windows.Forms.Panel();
			this.TopPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.RunButton = new System.Windows.Forms.Button();
			this.OutputBox = new System.Windows.Forms.TextBox();
			this.InputBox = new System.Windows.Forms.TextBox();
			this.TopPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// DrawingPanel
			// 
			this.DrawingPanel.BackColor = System.Drawing.Color.Black;
			this.DrawingPanel.Location = new System.Drawing.Point(0, 83);
			this.DrawingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DrawingPanel.Name = "DrawingPanel";
			this.DrawingPanel.Size = new System.Drawing.Size(356, 320);
			this.DrawingPanel.TabIndex = 1;
			this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.TopPanel.Controls.Add(this.label2);
			this.TopPanel.Controls.Add(this.label1);
			this.TopPanel.Controls.Add(this.RunButton);
			this.TopPanel.Controls.Add(this.OutputBox);
			this.TopPanel.Controls.Add(this.InputBox);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(356, 83);
			this.TopPanel.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(142, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Wynik";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(8, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Dokładność";
			// 
			// RunButton
			// 
			this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RunButton.Location = new System.Drawing.Point(256, 11);
			this.RunButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(88, 53);
			this.RunButton.TabIndex = 1;
			this.RunButton.Text = "Pokaż";
			this.RunButton.UseVisualStyleBackColor = true;
			this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
			// 
			// OutputBox
			// 
			this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.OutputBox.ForeColor = System.Drawing.Color.Maroon;
			this.OutputBox.Location = new System.Drawing.Point(146, 38);
			this.OutputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.ReadOnly = true;
			this.OutputBox.Size = new System.Drawing.Size(80, 26);
			this.OutputBox.TabIndex = 2;
			// 
			// InputBox
			// 
			this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.InputBox.ForeColor = System.Drawing.Color.Maroon;
			this.InputBox.Location = new System.Drawing.Point(12, 38);
			this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(72, 26);
			this.InputBox.TabIndex = 0;
			// 
			// Aproksymacja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 398);
			this.Controls.Add(this.TopPanel);
			this.Controls.Add(this.DrawingPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "Aproksymacja";
			this.Text = "Aproksymacja";
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}