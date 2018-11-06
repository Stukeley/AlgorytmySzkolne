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
            this.ONPChoiceBox.Location = new System.Drawing.Point(447, 66);
            this.ONPChoiceBox.Name = "ONPChoiceBox";
            this.ONPChoiceBox.Size = new System.Drawing.Size(307, 36);
            this.ONPChoiceBox.TabIndex = 0;
            this.ONPChoiceBox.Text = "Wybierz algorytm";
            this.ONPChoiceBox.SelectionChangeCommitted += new System.EventHandler(this.ONPChoiceBox_SelectionChangeCommitted);
            // 
            // ArgumentBox
            // 
            this.ArgumentBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArgumentBox.ForeColor = System.Drawing.Color.SlateGray;
            this.ArgumentBox.Location = new System.Drawing.Point(282, 182);
            this.ArgumentBox.Name = "ArgumentBox";
            this.ArgumentBox.Size = new System.Drawing.Size(634, 41);
            this.ArgumentBox.TabIndex = 3;
            this.ArgumentBox.Text = "Podaj argument...";
            this.ArgumentBox.Enter += new System.EventHandler(this.ArgumentBox_Enter);
            this.ArgumentBox.Leave += new System.EventHandler(this.ArgumentBox_Leave);
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultBox.ForeColor = System.Drawing.Color.SlateGray;
            this.ResultBox.Location = new System.Drawing.Point(282, 303);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(634, 41);
            this.ResultBox.TabIndex = 4;
            this.ResultBox.Text = "Wynik";
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RunButton.Location = new System.Drawing.Point(507, 414);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(188, 92);
            this.RunButton.TabIndex = 5;
            this.RunButton.Text = "Oblicz!";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ONPUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ArgumentBox);
            this.Controls.Add(this.ONPChoiceBox);
            this.Name = "ONPUC";
            this.Size = new System.Drawing.Size(1200, 572);
            this.Click += new System.EventHandler(this.ONPUC_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ONPChoiceBox;
        private System.Windows.Forms.TextBox ArgumentBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button RunButton;
    }
}
