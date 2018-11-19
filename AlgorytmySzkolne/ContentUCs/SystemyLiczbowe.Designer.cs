namespace AlgorytmySzkolne.ContentUCs
{
    partial class SystemyLiczbowe
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
			this.GivenBox = new System.Windows.Forms.TextBox();
			this.TargetBox = new System.Windows.Forms.TextBox();
			this.NumberBox = new System.Windows.Forms.TextBox();
			this.ResultBox = new System.Windows.Forms.TextBox();
			this.GivenLabel = new System.Windows.Forms.Label();
			this.TargetLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ObliczButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GivenBox
			// 
			this.GivenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GivenBox.ForeColor = System.Drawing.Color.Maroon;
			this.GivenBox.Location = new System.Drawing.Point(245, 92);
			this.GivenBox.Margin = new System.Windows.Forms.Padding(4);
			this.GivenBox.Name = "GivenBox";
			this.GivenBox.Size = new System.Drawing.Size(208, 30);
			this.GivenBox.TabIndex = 1;
			// 
			// TargetBox
			// 
			this.TargetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TargetBox.ForeColor = System.Drawing.Color.Maroon;
			this.TargetBox.Location = new System.Drawing.Point(612, 92);
			this.TargetBox.Margin = new System.Windows.Forms.Padding(4);
			this.TargetBox.Name = "TargetBox";
			this.TargetBox.Size = new System.Drawing.Size(208, 30);
			this.TargetBox.TabIndex = 2;
			// 
			// NumberBox
			// 
			this.NumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberBox.ForeColor = System.Drawing.Color.Maroon;
			this.NumberBox.Location = new System.Drawing.Point(162, 210);
			this.NumberBox.Margin = new System.Windows.Forms.Padding(4);
			this.NumberBox.Name = "NumberBox";
			this.NumberBox.Size = new System.Drawing.Size(743, 34);
			this.NumberBox.TabIndex = 3;
			// 
			// ResultBox
			// 
			this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultBox.ForeColor = System.Drawing.Color.Maroon;
			this.ResultBox.Location = new System.Drawing.Point(162, 306);
			this.ResultBox.Margin = new System.Windows.Forms.Padding(4);
			this.ResultBox.Name = "ResultBox";
			this.ResultBox.ReadOnly = true;
			this.ResultBox.Size = new System.Drawing.Size(743, 34);
			this.ResultBox.TabIndex = 5;
			// 
			// GivenLabel
			// 
			this.GivenLabel.Font = new System.Drawing.Font("Trebuchet MS", 13F);
			this.GivenLabel.Location = new System.Drawing.Point(245, 58);
			this.GivenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.GivenLabel.Name = "GivenLabel";
			this.GivenLabel.Size = new System.Drawing.Size(210, 30);
			this.GivenLabel.TabIndex = 13;
			this.GivenLabel.Text = Nazwy.bSystemZKtórego;
			this.GivenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TargetLabel
			// 
			this.TargetLabel.Font = new System.Drawing.Font("Trebuchet MS", 13F);
			this.TargetLabel.Location = new System.Drawing.Point(612, 58);
			this.TargetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TargetLabel.Name = "TargetLabel";
			this.TargetLabel.Size = new System.Drawing.Size(210, 30);
			this.TargetLabel.TabIndex = 14;
			this.TargetLabel.Text = Nazwy.bSystemNaKtóry;
			this.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13F);
			this.label1.Location = new System.Drawing.Point(162, 176);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(744, 30);
			this.label1.TabIndex = 15;
			this.label1.Text = Nazwy.bSystemPodaj;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13F);
			this.label2.Location = new System.Drawing.Point(162, 272);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(744, 30);
			this.label2.TabIndex = 16;
			this.label2.Text = Nazwy.aWynik;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ObliczButton
			// 
			this.ObliczButton.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ObliczButton.Location = new System.Drawing.Point(445, 359);
			this.ObliczButton.Margin = new System.Windows.Forms.Padding(4);
			this.ObliczButton.Name = "ObliczButton";
			this.ObliczButton.Size = new System.Drawing.Size(177, 62);
			this.ObliczButton.TabIndex = 4;
			this.ObliczButton.Text = Nazwy.pOblicz;
			this.ObliczButton.UseVisualStyleBackColor = true;
			this.ObliczButton.Click += new System.EventHandler(this.ObliczButton_Click);
			// 
			// SystemyLiczbowe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.ObliczButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TargetLabel);
			this.Controls.Add(this.GivenLabel);
			this.Controls.Add(this.ResultBox);
			this.Controls.Add(this.NumberBox);
			this.Controls.Add(this.TargetBox);
			this.Controls.Add(this.GivenBox);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SystemyLiczbowe";
			this.Size = new System.Drawing.Size(1067, 458);
			this.Load += new System.EventHandler(this.SystemyLiczbowe_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GivenBox;
        private System.Windows.Forms.TextBox TargetBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label GivenLabel;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ObliczButton;
    }
}
