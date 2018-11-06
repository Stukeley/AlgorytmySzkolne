namespace AlgorytmySzkolne.ContentUCs
{
    partial class Universal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.outputBox1 = new System.Windows.Forms.TextBox();
            this.ObliczButton = new System.Windows.Forms.Button();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.outputBox2 = new System.Windows.Forms.TextBox();
            this.CopyButton1 = new System.Windows.Forms.Button();
            this.CopyButton2 = new System.Windows.Forms.Button();
            this.EpsilonBox = new System.Windows.Forms.TextBox();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel1
            // 
            this.inputLabel1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputLabel1.Location = new System.Drawing.Point(42, 214);
            this.inputLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(327, 46);
            this.inputLabel1.TabIndex = 0;
            this.inputLabel1.Text = "Placeholder";
            this.inputLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // inputLabel2
            // 
            this.inputLabel2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputLabel2.Location = new System.Drawing.Point(42, 334);
            this.inputLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(327, 46);
            this.inputLabel2.TabIndex = 1;
            this.inputLabel2.Text = "Placeholder";
            this.inputLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // outputLabel1
            // 
            this.outputLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputLabel1.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.outputLabel1.Location = new System.Drawing.Point(42, 26);
            this.outputLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(327, 46);
            this.outputLabel1.TabIndex = 2;
            this.outputLabel1.Text = "Placeholder";
            this.outputLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // inputBox1
            // 
            this.inputBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputBox1.ForeColor = System.Drawing.Color.Maroon;
            this.inputBox1.Location = new System.Drawing.Point(42, 265);
            this.inputBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(325, 41);
            this.inputBox1.TabIndex = 3;
            this.inputBox1.Enter += new System.EventHandler(this.inputBox1_Enter);
            this.inputBox1.Leave += new System.EventHandler(this.inputBox1_Leave);
            // 
            // inputBox2
            // 
            this.inputBox2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputBox2.ForeColor = System.Drawing.Color.Maroon;
            this.inputBox2.Location = new System.Drawing.Point(42, 385);
            this.inputBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(325, 41);
            this.inputBox2.TabIndex = 4;
            this.inputBox2.Enter += new System.EventHandler(this.inputBox2_Enter);
            this.inputBox2.Leave += new System.EventHandler(this.inputBox2_Leave);
            // 
            // outputBox1
            // 
            this.outputBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputBox1.Location = new System.Drawing.Point(42, 80);
            this.outputBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputBox1.Name = "outputBox1";
            this.outputBox1.ReadOnly = true;
            this.outputBox1.Size = new System.Drawing.Size(325, 41);
            this.outputBox1.TabIndex = 5;
            // 
            // ObliczButton
            // 
            this.ObliczButton.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObliczButton.Location = new System.Drawing.Point(1023, 34);
            this.ObliczButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObliczButton.Name = "ObliczButton";
            this.ObliczButton.Size = new System.Drawing.Size(135, 92);
            this.ObliczButton.TabIndex = 6;
            this.ObliczButton.Text = "Oblicz!";
            this.ObliczButton.UseVisualStyleBackColor = true;
            this.ObliczButton.Click += new System.EventHandler(this.ObliczButton_Click);
            // 
            // outputLabel2
            // 
            this.outputLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputLabel2.Font = new System.Drawing.Font("Gabriola", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.outputLabel2.Location = new System.Drawing.Point(531, 26);
            this.outputLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(327, 46);
            this.outputLabel2.TabIndex = 7;
            this.outputLabel2.Text = "Placeholder";
            this.outputLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // outputBox2
            // 
            this.outputBox2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputBox2.Location = new System.Drawing.Point(531, 80);
            this.outputBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputBox2.Name = "outputBox2";
            this.outputBox2.ReadOnly = true;
            this.outputBox2.Size = new System.Drawing.Size(325, 41);
            this.outputBox2.TabIndex = 8;
            // 
            // CopyButton1
            // 
            this.CopyButton1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyButton1.ForeColor = System.Drawing.Color.Black;
            this.CopyButton1.Location = new System.Drawing.Point(374, 80);
            this.CopyButton1.Margin = new System.Windows.Forms.Padding(0);
            this.CopyButton1.Name = "CopyButton1";
            this.CopyButton1.Size = new System.Drawing.Size(84, 46);
            this.CopyButton1.TabIndex = 10;
            this.CopyButton1.Text = "Kopiuj";
            this.CopyButton1.UseVisualStyleBackColor = true;
            this.CopyButton1.Click += new System.EventHandler(this.CopyButton1_Click);
            // 
            // CopyButton2
            // 
            this.CopyButton2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyButton2.ForeColor = System.Drawing.Color.Black;
            this.CopyButton2.Location = new System.Drawing.Point(862, 80);
            this.CopyButton2.Margin = new System.Windows.Forms.Padding(0);
            this.CopyButton2.Name = "CopyButton2";
            this.CopyButton2.Size = new System.Drawing.Size(84, 46);
            this.CopyButton2.TabIndex = 11;
            this.CopyButton2.Text = "Kopiuj";
            this.CopyButton2.UseVisualStyleBackColor = true;
            this.CopyButton2.Click += new System.EventHandler(this.CopyButton2_Click);
            // 
            // EpsilonBox
            // 
            this.EpsilonBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EpsilonBox.ForeColor = System.Drawing.Color.Maroon;
            this.EpsilonBox.Location = new System.Drawing.Point(42, 508);
            this.EpsilonBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EpsilonBox.Name = "EpsilonBox";
            this.EpsilonBox.Size = new System.Drawing.Size(325, 41);
            this.EpsilonBox.TabIndex = 12;
            this.EpsilonBox.Visible = false;
            this.EpsilonBox.Enter += new System.EventHandler(this.EpsilonBox_Enter);
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EpsilonLabel.Location = new System.Drawing.Point(42, 454);
            this.EpsilonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(327, 46);
            this.EpsilonLabel.TabIndex = 13;
            this.EpsilonLabel.Text = "Podaj dokladność";
            this.EpsilonLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EpsilonLabel.Visible = false;
            // 
            // HelpLabel
            // 
            this.HelpLabel.BackColor = System.Drawing.Color.Transparent;
            this.HelpLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpLabel.Location = new System.Drawing.Point(548, 198);
            this.HelpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(610, 355);
            this.HelpLabel.TabIndex = 14;
            this.HelpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Universal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.EpsilonLabel);
            this.Controls.Add(this.EpsilonBox);
            this.Controls.Add(this.CopyButton2);
            this.Controls.Add(this.CopyButton1);
            this.Controls.Add(this.outputBox2);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.ObliczButton);
            this.Controls.Add(this.outputBox1);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.inputLabel2);
            this.Controls.Add(this.inputLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Universal";
            this.Size = new System.Drawing.Size(1200, 572);
            this.Load += new System.EventHandler(this.Universal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.TextBox outputBox1;
        private System.Windows.Forms.Button ObliczButton;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.TextBox outputBox2;
        private System.Windows.Forms.Button CopyButton1;
        private System.Windows.Forms.Button CopyButton2;
        private System.Windows.Forms.TextBox EpsilonBox;
        private System.Windows.Forms.Label EpsilonLabel;
        private System.Windows.Forms.Label HelpLabel;
    }
}
