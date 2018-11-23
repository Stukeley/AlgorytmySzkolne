namespace AlgorytmySzkolne
{
    partial class Glowna
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glowna));
			this.algorytmyUC1 = new AlgorytmySzkolne.AlgorytmyUC();
			this.SuspendLayout();
			// 
			// algorytmyUC1
			// 
			this.algorytmyUC1.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.algorytmyUC1, "algorytmyUC1");
			this.algorytmyUC1.Name = "algorytmyUC1";
			// 
			// Glowna
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.algorytmyUC1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MinimizeBox = false;
			this.Name = "Glowna";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Glowna_OnClose);
			this.Load += new System.EventHandler(this.Glowna_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Glowna_KeyDown);
			this.ResumeLayout(false);

        }

        #endregion

        public AlgorytmyUC algorytmyUC1;
    }
}