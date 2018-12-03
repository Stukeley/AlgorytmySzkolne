namespace AlgorytmySzkolne.ContentUCs
{
    partial class SPOJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPOJ));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CopyButton = new System.Windows.Forms.Button();
            this.AlgorytmChoiceBox = new System.Windows.Forms.ComboBox();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.CopyButton);
            this.panel1.Controls.Add(this.AlgorytmChoiceBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 80);
            this.panel1.TabIndex = 0;
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.SystemColors.Control;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyButton.ForeColor = System.Drawing.Color.Maroon;
            this.CopyButton.Location = new System.Drawing.Point(719, 20);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(100, 40);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = Nazwy.bKopiuj;
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // AlgorytmChoiceBox
            // 
            this.AlgorytmChoiceBox.FormattingEnabled = true;
            this.AlgorytmChoiceBox.Items.AddRange(new object[] {
            "Liczby pierwsze",
            "SkarbFinder",
            "Zabawne Dodawanie Piotrusia",
            "Dwie cyfry silni",
            "Czy umiesz potęgować",
            "Konwersja dat",
            "Not So Fast Multiplication"});
            this.AlgorytmChoiceBox.Location = new System.Drawing.Point(60, 29);
            this.AlgorytmChoiceBox.Name = "AlgorytmChoiceBox";
            this.AlgorytmChoiceBox.Size = new System.Drawing.Size(360, 28);
            this.AlgorytmChoiceBox.TabIndex = 0;
            this.AlgorytmChoiceBox.Text = Nazwy.bWybierzAlgorytm;
            this.AlgorytmChoiceBox.SelectionChangeCommitted += new System.EventHandler(this.AlgorytmChoiceBox_SelectionChangeCommitted);
            // 
            // OutputBox
            // 
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutputBox.Location = new System.Drawing.Point(0, 80);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(878, 464);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "";
            // 
            // SPOJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SPOJ";
            this.Text = "SPOJ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.ComboBox AlgorytmChoiceBox;
    }
}