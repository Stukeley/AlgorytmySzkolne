using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class ONPUC : UserControl
    {
        private AlgorytmyUC algorytmyUC;

        public void SetUC(AlgorytmyUC algorytmyUC)
        {
            this.algorytmyUC = algorytmyUC;
        }

        public void SetResult(string result)
        {
            ResultBox.ForeColor = Color.Maroon;
            this.ResultBox.Text = result;
        }

        public ONPUC()
        {
            InitializeComponent();
        }

        private void ArgumentBox_Enter(object sender, EventArgs e)
        {
            if (ArgumentBox.Text == "Podaj argument...")
            {
                ArgumentBox.ForeColor = Color.Maroon;
                ArgumentBox.Text = "";
            }
        }

        private void ONPChoiceBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ArgumentBox.Text = "Podaj argument...";
            ArgumentBox.ForeColor = Color.SlateGray;
            var selection = ONPChoiceBox.GetItemText(ONPChoiceBox.SelectedItem);
            if (selection == "Wartość wyrażenia w ONP")
            {
                RunButton.Text = "Oblicz!";
            }
            else
            {
                RunButton.Text = "Wykonaj!";
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var title = ONPChoiceBox.GetItemText(ONPChoiceBox.SelectedItem);
            if (title == Nazwy.oZONP)
            {
                var result = MessageBox.Show("Uwaga! Chuj wie czy to działa. Czy na pewno chcesz spróbować?", "Ostrzeżenie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    AlgorytmySzkolne.RunAlgorithms.Run(title, ArgumentBox.Text);
                }
            }
            else
            {
                AlgorytmySzkolne.RunAlgorithms.Run(title, ArgumentBox.Text);
            }
        }

        private void ONPUC_Load(object sender, EventArgs e)
        {
            RunAlgorithms.SetONPUC(this);
            var coll = new List<string>()
            {
                Nazwy.oWartosc,
                Nazwy.oNaONP,
                Nazwy.oZONP
            };
            ONPChoiceBox.DataSource = coll;
        }

        private void ONPUC_Click(object sender, EventArgs e)
        {
            this.ActiveControl = RunButton;//?
        }

        private void ArgumentBox_Leave(object sender, EventArgs e)
        {
            if (ArgumentBox.Text == "")
            {
                ArgumentBox.Text = "Podaj argument...";
                ArgumentBox.ForeColor = Color.SlateGray;
            }
        }
    }
}