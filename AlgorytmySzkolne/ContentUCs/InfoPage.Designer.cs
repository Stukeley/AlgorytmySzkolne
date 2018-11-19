namespace AlgorytmySzkolne.ContentUCs
{
    partial class InfoPage
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
			this.InfoLabel = new System.Windows.Forms.Label();
			this.InfoLabel2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// InfoLabel
			// 
			this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InfoLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.InfoLabel.ForeColor = System.Drawing.Color.Indigo;
			this.InfoLabel.Location = new System.Drawing.Point(70, 57);
			this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.InfoLabel.Name = "InfoLabel";
			this.InfoLabel.Size = new System.Drawing.Size(926, 136);
			this.InfoLabel.TabIndex = 0;
			this.InfoLabel.Text = "Aplikacja będąca kompilacją większości algorytmów które pisaliśmy\r\nna lekcjach in" +
    "formatyki w klasie\r\n2. liceum w roku szkolnym 2017/2018.\r\nObsługuje kilka podsta" +
    "wowych skrótów klawiszowych.";
			this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InfoLabel2
			// 
			this.InfoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InfoLabel2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.InfoLabel2.ForeColor = System.Drawing.Color.Crimson;
			this.InfoLabel2.Location = new System.Drawing.Point(76, 218);
			this.InfoLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.InfoLabel2.Name = "InfoLabel2";
			this.InfoLabel2.Size = new System.Drawing.Size(920, 144);
			this.InfoLabel2.TabIndex = 0;
			this.InfoLabel2.Text = "ESC: wyjście z aplikacji\r\n1-8: wybór danego algorytmu (tylko na ekranie wyboru al" +
    "gorytmów)\r\nTAB: następna kontrolka";
			this.InfoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InfoPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.InfoLabel2);
			this.Controls.Add(this.InfoLabel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "InfoPage";
			this.Size = new System.Drawing.Size(1067, 458);
			this.Load += new System.EventHandler(this.InfoPage_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
		private System.Windows.Forms.Label InfoLabel2;
	}
}
