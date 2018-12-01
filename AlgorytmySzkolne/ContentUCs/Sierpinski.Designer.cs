namespace AlgorytmySzkolne.ContentUCs
{
    partial class Sierpinski
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sierpinski));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.LevelsBox = new System.Windows.Forms.TextBox();
			this.RunButton = new System.Windows.Forms.Button();
			this.DrawingPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.LevelsBox);
			this.panel1.Controls.Add(this.RunButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(533, 64);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Podaj ilość poziomów";
			// 
			// LevelsBox
			// 
			this.LevelsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LevelsBox.Location = new System.Drawing.Point(288, 18);
			this.LevelsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LevelsBox.Name = "LevelsBox";
			this.LevelsBox.Size = new System.Drawing.Size(72, 28);
			this.LevelsBox.TabIndex = 0;
			// 
			// RunButton
			// 
			this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RunButton.Location = new System.Drawing.Point(413, 9);
			this.RunButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(108, 46);
			this.RunButton.TabIndex = 1;
			this.RunButton.Text = "Pokaż";
			this.RunButton.UseVisualStyleBackColor = true;
			this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
			// 
			// DrawingPanel
			// 
			this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DrawingPanel.Location = new System.Drawing.Point(0, 64);
			this.DrawingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DrawingPanel.Name = "DrawingPanel";
			this.DrawingPanel.Size = new System.Drawing.Size(533, 480);
			this.DrawingPanel.TabIndex = 1;
			this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
			// 
			// Sierpinski
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 544);
			this.Controls.Add(this.DrawingPanel);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "Sierpinski";
			this.Text = Nazwy.tSierpiński;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox LevelsBox;
        private System.Windows.Forms.Label label1;
    }
}