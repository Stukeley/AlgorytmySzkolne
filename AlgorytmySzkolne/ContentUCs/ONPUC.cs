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
			ResultBox.Text = "Wynik";
			ResultBox.ForeColor = Color.SlateGray;

			var selection = ONPChoiceBox.GetItemText(ONPChoiceBox.SelectedItem);
			if (selection == "Wartość wyrażenia w ONP")
			{
				RunButton.Text = "Oblicz!";
				HelpLabel.Text = "Podaj wyrażenie w ONP aby uzyskać jego wartość.\n" +
					"Przykład: 2 3 + 4 *\n" +
					"Wynik: 20";
				HelpLabel.Visible = true;
			}
			else if (selection == "Z ONP")
			{
				RunButton.Text = "Wykonaj!";
				HelpLabel.Text = "Podaj wyrażenie w ONP aby uzyskać jego odpowiednik w notacji normalnej.\n" +
					"Przykład: 2 3 + 4 *\n" +
					"Wynik: (2+3)*4";
				HelpLabel.Visible = true;
			}
			else if (selection == "Na ONP")
			{
				RunButton.Text = "Wykonaj!";
				HelpLabel.Text = "Podaj wyrażenie w notacji normalnej aby uzyskać jego odpowiednik w ONP.\n" +
					"Przykład: (2+3)*4\n" +
					"Wynik: 2 3 + 4 *";
				HelpLabel.Visible = true;
			}
		}

		private void RunButton_Click(object sender, EventArgs e)
		{
			var title = ONPChoiceBox.GetItemText(ONPChoiceBox.SelectedItem);
			ResultBox.ForeColor = Color.Maroon;
			if (title == Nazwy.oZONP)
			{
				var result = MessageBox.Show("Uwaga! Chuj wie czy to działa. Czy na pewno chcesz spróbować?", "Ostrzeżenie",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					RunAlgorithms.Run(title, ArgumentBox.Text);
				}
			}
			else
			{
				RunAlgorithms.Run(title, ArgumentBox.Text);
			}
		}

		private void ONPUC_Load(object sender, EventArgs e)
		{
			RunAlgorithms.SetONPUC(this);
			ResultBox.BackColor = ResultBox.BackColor;//to jest wymagane żeby działał ForeColor xD!

			//var coll = new List<string>()
			//{
			//	Nazwy.oWartosc,
			//	Nazwy.oNaONP,
			//	Nazwy.oZONP
			//};
			//ONPChoiceBox.DataSource = coll;
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