namespace AlgorytmySzkolne.ContentUCs
{
	partial class Translator
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
			this.LanguagesBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.RunButton = new System.Windows.Forms.Button();
			this.RevertLanguageButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LanguagesBox
			// 
			this.LanguagesBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LanguagesBox.FormattingEnabled = true;
			this.LanguagesBox.Location = new System.Drawing.Point(130, 62);
			this.LanguagesBox.Name = "LanguagesBox";
			this.LanguagesBox.Size = new System.Drawing.Size(153, 31);
			this.LanguagesBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(128, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Choose target language";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RunButton
			// 
			this.RunButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RunButton.Location = new System.Drawing.Point(157, 170);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(99, 56);
			this.RunButton.TabIndex = 2;
			this.RunButton.Text = "Translate";
			this.RunButton.UseVisualStyleBackColor = true;
			this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
			// 
			// RevertLanguageButton
			// 
			this.RevertLanguageButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RevertLanguageButton.Location = new System.Drawing.Point(313, 179);
			this.RevertLanguageButton.Name = "RevertLanguageButton";
			this.RevertLanguageButton.Size = new System.Drawing.Size(87, 38);
			this.RevertLanguageButton.TabIndex = 3;
			this.RevertLanguageButton.Text = "Revert";
			this.RevertLanguageButton.UseVisualStyleBackColor = true;
			this.RevertLanguageButton.Click += new System.EventHandler(this.RevertLanguageButton_Click);
			// 
			// Translator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 313);
			this.Controls.Add(this.RevertLanguageButton);
			this.Controls.Add(this.RunButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LanguagesBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Translator";
			this.Text = "Translator";
			this.Load += new System.EventHandler(this.Translator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox LanguagesBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button RunButton;
		private System.Windows.Forms.Button RevertLanguageButton;
	}
}