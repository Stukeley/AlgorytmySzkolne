namespace AlgorytmySzkolne
{
    partial class AlgorytmyUC
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.BackButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.LanguageChangeButton = new System.Windows.Forms.Button();
			this.InfoPageButton = new System.Windows.Forms.Button();
			this.HomePageButton = new System.Windows.Forms.Button();
			this.CurrentFormNameLabel = new System.Windows.Forms.Label();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.Controls.Add(this.BackButton);
			this.panel1.Controls.Add(this.ExitButton);
			this.panel1.Controls.Add(this.LanguageChangeButton);
			this.panel1.Controls.Add(this.InfoPageButton);
			this.panel1.Controls.Add(this.HomePageButton);
			this.panel1.Controls.Add(this.CurrentFormNameLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1067, 96);
			this.panel1.TabIndex = 0;
			// 
			// BackButton
			// 
			this.BackButton.BackColor = System.Drawing.Color.Transparent;
			this.BackButton.Image = global::AlgorytmySzkolne.Properties.Resources.arrow_icon;
			this.BackButton.Location = new System.Drawing.Point(11, 12);
			this.BackButton.Margin = new System.Windows.Forms.Padding(4);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(80, 74);
			this.BackButton.TabIndex = 5;
			this.BackButton.UseVisualStyleBackColor = false;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitButton.BackColor = System.Drawing.Color.Transparent;
			this.ExitButton.Image = global::AlgorytmySzkolne.Properties.Resources.exit_icon;
			this.ExitButton.Location = new System.Drawing.Point(974, 12);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(80, 74);
			this.ExitButton.TabIndex = 4;
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LanguageChangeButton
			// 
			this.LanguageChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LanguageChangeButton.BackColor = System.Drawing.Color.Transparent;
			this.LanguageChangeButton.Image = global::AlgorytmySzkolne.Properties.Resources.language_icon;
			this.LanguageChangeButton.Location = new System.Drawing.Point(851, 12);
			this.LanguageChangeButton.Margin = new System.Windows.Forms.Padding(4);
			this.LanguageChangeButton.Name = "LanguageChangeButton";
			this.LanguageChangeButton.Size = new System.Drawing.Size(80, 74);
			this.LanguageChangeButton.TabIndex = 3;
			this.LanguageChangeButton.UseVisualStyleBackColor = false;
			this.LanguageChangeButton.Click += new System.EventHandler(this.LanguageChangeButton_Click);
			// 
			// InfoPageButton
			// 
			this.InfoPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InfoPageButton.BackColor = System.Drawing.Color.Transparent;
			this.InfoPageButton.Image = global::AlgorytmySzkolne.Properties.Resources.info_icon;
			this.InfoPageButton.Location = new System.Drawing.Point(727, 12);
			this.InfoPageButton.Margin = new System.Windows.Forms.Padding(4);
			this.InfoPageButton.Name = "InfoPageButton";
			this.InfoPageButton.Size = new System.Drawing.Size(80, 74);
			this.InfoPageButton.TabIndex = 2;
			this.InfoPageButton.UseVisualStyleBackColor = false;
			this.InfoPageButton.Click += new System.EventHandler(this.InfoPageButton_Click);
			// 
			// HomePageButton
			// 
			this.HomePageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HomePageButton.BackColor = System.Drawing.Color.Transparent;
			this.HomePageButton.Image = global::AlgorytmySzkolne.Properties.Resources.home_icon;
			this.HomePageButton.Location = new System.Drawing.Point(603, 12);
			this.HomePageButton.Margin = new System.Windows.Forms.Padding(4);
			this.HomePageButton.Name = "HomePageButton";
			this.HomePageButton.Size = new System.Drawing.Size(80, 74);
			this.HomePageButton.TabIndex = 1;
			this.HomePageButton.UseVisualStyleBackColor = false;
			this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
			// 
			// CurrentFormNameLabel
			// 
			this.CurrentFormNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CurrentFormNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.CurrentFormNameLabel.Location = new System.Drawing.Point(98, 6);
			this.CurrentFormNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CurrentFormNameLabel.Name = "CurrentFormNameLabel";
			this.CurrentFormNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CurrentFormNameLabel.Size = new System.Drawing.Size(498, 82);
			this.CurrentFormNameLabel.TabIndex = 0;
			this.CurrentFormNameLabel.Text = "Lorem ipsum";
			this.CurrentFormNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// MainPanel
			// 
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MainPanel.Location = new System.Drawing.Point(0, 96);
			this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(1067, 458);
			this.MainPanel.TabIndex = 1;
			this.MainPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainPanel_ControlAdded);
			this.MainPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.MainPanel_ControlRemoved);
			// 
			// AlgorytmyUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AlgorytmyUC";
			this.Size = new System.Drawing.Size(1067, 554);
			this.Load += new System.EventHandler(this.AlgorytmyUC_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentFormNameLabel;
        private System.Windows.Forms.Button InfoPageButton;
        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.Button LanguageChangeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BackButton;
    }
}
