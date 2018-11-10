namespace AlgorytmySzkolne.ContentUCs
{
    partial class ONPUC
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
			this.ONPChoiceBox = new System.Windows.Forms.ComboBox();
			this.ArgumentBox = new System.Windows.Forms.TextBox();
			this.ResultBox = new System.Windows.Forms.TextBox();
			this.RunButton = new System.Windows.Forms.Button();
			this.HelpLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ONPChoiceBox
			// 
			this.ONPChoiceBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ONPChoiceBox.FormattingEnabled = true;
			this.ONPChoiceBox.Items.AddRange(new object[] {
            "Wartość wyrażenia w ONP",
            "Na ONP",
            "Z ONP"});
			this.ONPChoiceBox.Location = new System.Drawing.Point(397, 32);
			this.ONPChoiceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ONPChoiceBox.Name = "ONPChoiceBox";
			this.ONPChoiceBox.Size = new System.Drawing.Size(273, 32);
			this.ONPChoiceBox.TabIndex = 0;
			this.ONPChoiceBox.Text = "Wybierz algorytm";
			this.ONPChoiceBox.SelectionChangeCommitted += new System.EventHandler(this.ONPChoiceBox_SelectionChangeCommitted);
			// 
			// ArgumentBox
			// 
			this.ArgumentBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ArgumentBox.ForeColor = System.Drawing.Color.SlateGray;
			this.ArgumentBox.Location = new System.Drawing.Point(251, 178);
			this.ArgumentBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ArgumentBox.Name = "ArgumentBox";
			this.ArgumentBox.Size = new System.Drawing.Size(564, 35);
			this.ArgumentBox.TabIndex = 1;
			this.ArgumentBox.Text = "Podaj argument...";
			this.ArgumentBox.Enter += new System.EventHandler(this.ArgumentBox_Enter);
			this.ArgumentBox.Leave += new System.EventHandler(this.ArgumentBox_Leave);
			// 
			// ResultBox
			// 
			this.ResultBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ResultBox.ForeColor = System.Drawing.Color.SlateGray;
			this.ResultBox.Location = new System.Drawing.Point(251, 255);
			this.ResultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ResultBox.Name = "ResultBox";
			this.ResultBox.ReadOnly = true;
			this.ResultBox.Size = new System.Drawing.Size(564, 35);
			this.ResultBox.TabIndex = 3;
			this.ResultBox.Text = "Wynik";
			// 
			// RunButton
			// 
			this.RunButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RunButton.Location = new System.Drawing.Point(451, 331);
			this.RunButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(167, 74);
			this.RunButton.TabIndex = 2;
			this.RunButton.Text = "Oblicz!";
			this.RunButton.UseVisualStyleBackColor = true;
			this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
			// 
			// HelpLabel
			// 
			this.HelpLabel.BackColor = System.Drawing.Color.Transparent;
			this.HelpLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.HelpLabel.Location = new System.Drawing.Point(251, 76);
			this.HelpLabel.Name = "HelpLabel";
			this.HelpLabel.Size = new System.Drawing.Size(564, 89);
			this.HelpLabel.TabIndex = 6;
			this.HelpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.HelpLabel.Visible = false;
			// 
			// ONPUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.HelpLabel);
			this.Controls.Add(this.RunButton);
			this.Controls.Add(this.ResultBox);
			this.Controls.Add(this.ArgumentBox);
			this.Controls.Add(this.ONPChoiceBox);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ONPUC";
			this.Size = new System.Drawing.Size(1067, 458);
			this.Load += new System.EventHandler(this.ONPUC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ONPChoiceBox;
        private System.Windows.Forms.TextBox ArgumentBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button RunButton;
		private System.Windows.Forms.Label HelpLabel;
	}
}
