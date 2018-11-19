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
			if (ArgumentBox.Text == Nazwy.pArgument)
			{
				ArgumentBox.ForeColor = Color.Maroon;
				ArgumentBox.Text = "";
			}
		}

		private void ONPChoiceBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			ArgumentBox.Text = Nazwy.pArgument;
			ArgumentBox.ForeColor = Color.SlateGray;
			ResultBox.Text = Nazwy.aWynik;
			ResultBox.ForeColor = Color.SlateGray;

			var selection = ONPChoiceBox.GetItemText(ONPChoiceBox.SelectedItem);
			if (selection == Nazwy.oWartosc)
			{
				RunButton.Text = Nazwy.pOblicz;
				HelpLabel.Text = Nazwy.iONPWartość;
				HelpLabel.Visible = true;
			}
			else if (selection == Nazwy.oZONP)
			{
				RunButton.Text = Nazwy.pWykonaj;
				HelpLabel.Text = Nazwy.iONPZ;
				HelpLabel.Visible = true;
			}
			else if (selection == Nazwy.oNaONP)
			{
				RunButton.Text = Nazwy.pWykonaj;
				HelpLabel.Text = Nazwy.iONPNa;
				HelpLabel.Visible = true;
			}
		}

		private void RunButton_Click(object sender, EventArgs e)
		{
			var title = ONPChoiceBox.GetItemText(ONPChoiceBox.SelectedItem);
			ResultBox.ForeColor = Color.Maroon;
			if (title == Nazwy.oZONP)
			{
				var result = MessageBox.Show(Nazwy.iNiepewne, Nazwy.iOstrzeżenie,
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
				ArgumentBox.Text = Nazwy.pArgument;
				ArgumentBox.ForeColor = Color.SlateGray;
			}
		}
	}
}