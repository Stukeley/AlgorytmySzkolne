namespace AlgorytmySzkolne.ContentUCs
{
    partial class SetFunction
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
			this.SetFunctionBox = new System.Windows.Forms.TextBox();
			this.HelpLabel = new System.Windows.Forms.Label();
			this.FunctionChoiceBox = new System.Windows.Forms.ComboBox();
			this.SetFunctionButton = new System.Windows.Forms.Button();
			this.StopienBox1 = new System.Windows.Forms.TextBox();
			this.StopienBox2 = new System.Windows.Forms.TextBox();
			this.ArgumentChoiceBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// SetFunctionBox
			// 
			this.SetFunctionBox.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SetFunctionBox.ForeColor = System.Drawing.Color.Maroon;
			this.SetFunctionBox.Location = new System.Drawing.Point(161, 161);
			this.SetFunctionBox.Margin = new System.Windows.Forms.Padding(4);
			this.SetFunctionBox.Name = "SetFunctionBox";
			this.SetFunctionBox.Size = new System.Drawing.Size(743, 35);
			this.SetFunctionBox.TabIndex = 4;
			this.SetFunctionBox.Enter += new System.EventHandler(this.SetFunctionBox_Enter);
			// 
			// HelpLabel
			// 
			this.HelpLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpLabel.Location = new System.Drawing.Point(161, 251);
			this.HelpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HelpLabel.Name = "HelpLabel";
			this.HelpLabel.Size = new System.Drawing.Size(743, 207);
			this.HelpLabel.TabIndex = 5;
			this.HelpLabel.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vulputate\r\nlibero " +
    "nisi, a lacinia velit hendrerit ut. Nunc aliquam ex nunc, sed egestas\r\naugue dig" +
    "nissim at. Cras vehicula odio orci.\r\n";
			this.HelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HelpLabel.Visible = false;
			// 
			// FunctionChoiceBox
			// 
			this.FunctionChoiceBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.FunctionChoiceBox.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FunctionChoiceBox.ForeColor = System.Drawing.Color.Maroon;
			this.FunctionChoiceBox.FormattingEnabled = true;
			this.FunctionChoiceBox.Text = Nazwy.bWybierzFunkcję;
			this.FunctionChoiceBox.Items.AddRange(new object[] {
			Nazwy.fWielomian,
			Nazwy.fWymierna,
			Nazwy.fPierwiastek,
			Nazwy.fSin,
			Nazwy.fCos,
			Nazwy.fTg,
			Nazwy.fCtg,
			Nazwy.fLosuj,
			Nazwy.fAlternatywa });
			this.FunctionChoiceBox.Location = new System.Drawing.Point(429, 30);
			this.FunctionChoiceBox.Margin = new System.Windows.Forms.Padding(4);
			this.FunctionChoiceBox.Name = "FunctionChoiceBox";
			this.FunctionChoiceBox.Size = new System.Drawing.Size(208, 31);
			this.FunctionChoiceBox.TabIndex = 6;
			this.FunctionChoiceBox.SelectionChangeCommitted += new System.EventHandler(this.FunctionChoiceBox_SelectionChangeCommitted);
			// 
			// SetFunctionButton
			// 
			this.SetFunctionButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SetFunctionButton.Location = new System.Drawing.Point(476, 206);
			this.SetFunctionButton.Margin = new System.Windows.Forms.Padding(4);
			this.SetFunctionButton.Name = "SetFunctionButton";
			this.SetFunctionButton.Size = new System.Drawing.Size(115, 42);
			this.SetFunctionButton.TabIndex = 7;
			this.SetFunctionButton.Text = Nazwy.bUstaw;
			this.SetFunctionButton.UseVisualStyleBackColor = true;
			this.SetFunctionButton.Visible = false;
			this.SetFunctionButton.Click += new System.EventHandler(this.SetFunctionButton_Click);
			// 
			// StopienBox1
			// 
			this.StopienBox1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StopienBox1.ForeColor = System.Drawing.Color.Maroon;
			this.StopienBox1.Location = new System.Drawing.Point(320, 70);
			this.StopienBox1.Margin = new System.Windows.Forms.Padding(4);
			this.StopienBox1.Name = "StopienBox1";
			this.StopienBox1.Size = new System.Drawing.Size(208, 31);
			this.StopienBox1.TabIndex = 8;
			this.StopienBox1.Visible = false;
			this.StopienBox1.Enter += new System.EventHandler(this.StopienBox1_Enter);
			// 
			// StopienBox2
			// 
			this.StopienBox2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StopienBox2.ForeColor = System.Drawing.Color.Maroon;
			this.StopienBox2.Location = new System.Drawing.Point(537, 70);
			this.StopienBox2.Margin = new System.Windows.Forms.Padding(4);
			this.StopienBox2.Name = "StopienBox2";
			this.StopienBox2.Size = new System.Drawing.Size(208, 31);
			this.StopienBox2.TabIndex = 9;
			this.StopienBox2.Visible = false;
			this.StopienBox2.Enter += new System.EventHandler(this.StopienBox2_Enter);
			// 
			// ArgumentChoiceBox1
			// 
			this.ArgumentChoiceBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ArgumentChoiceBox1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ArgumentChoiceBox1.ForeColor = System.Drawing.Color.Maroon;
			this.ArgumentChoiceBox1.FormattingEnabled = true;
			this.ArgumentChoiceBox1.Items.AddRange(new object[] {
            "x",
            "PI"});
			this.ArgumentChoiceBox1.Location = new System.Drawing.Point(429, 110);
			this.ArgumentChoiceBox1.Margin = new System.Windows.Forms.Padding(4);
			this.ArgumentChoiceBox1.Name = "ArgumentChoiceBox1";
			this.ArgumentChoiceBox1.Text = Nazwy.bWybierzTypArgumentu;
			this.ArgumentChoiceBox1.Size = new System.Drawing.Size(208, 31);
			this.ArgumentChoiceBox1.TabIndex = 10;
			this.ArgumentChoiceBox1.Visible = false;
			this.ArgumentChoiceBox1.SelectionChangeCommitted += new System.EventHandler(this.ArgumentChoiceBox1_SelectionChangeCommitted);
			// 
			// SetFunction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.ArgumentChoiceBox1);
			this.Controls.Add(this.StopienBox2);
			this.Controls.Add(this.StopienBox1);
			this.Controls.Add(this.SetFunctionButton);
			this.Controls.Add(this.FunctionChoiceBox);
			this.Controls.Add(this.HelpLabel);
			this.Controls.Add(this.SetFunctionBox);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SetFunction";
			this.Size = new System.Drawing.Size(1067, 458);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SetFunctionBox;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.ComboBox FunctionChoiceBox;
        private System.Windows.Forms.Button SetFunctionButton;
        private System.Windows.Forms.TextBox StopienBox1;
        private System.Windows.Forms.TextBox StopienBox2;
        private System.Windows.Forms.ComboBox ArgumentChoiceBox1;
    }
}
