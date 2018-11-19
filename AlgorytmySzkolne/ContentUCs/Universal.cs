using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class Universal : UserControl
	{
		#region Overloads

		public void SetLabels(string w1)
		{
			inputLabel1.Text = w1;
		}

		public void SetLabels(string w1, string w2)
		{
			inputLabel1.Text = w1;
			outputLabel1.Text = w2;
		}

		public void SetLabels(string w1, string w2, string w3)
		{
			inputLabel1.Text = w1;
			inputLabel2.Text = w2;
			outputLabel1.Text = w3;
		}

		public void SetLabels(string w1, string w2, string w3, string w4)
		{
			inputLabel1.Text = w1;
			inputLabel2.Text = w2;
			outputLabel1.Text = w3;
			outputLabel2.Text = w4;
		}

		public void SetResult(string w1)
		{
			outputBox1.Text = w1;
		}

		public void SetResult(string w1, string w2)
		{
			outputBox1.Text = w1;
			outputBox2.Text = w2;
		}

		public void SetVisibility()
		{
			inputBox2.Visible = false;
			inputLabel2.Visible = false;
			outputBox2.Visible = false;
			outputLabel2.Visible = false;
			CopyButton2.Visible = false;
		}

		public void SetSecondOutputVisibility()
		{
			outputBox2.Visible = false;
			outputLabel2.Visible = false;
			CopyButton2.Visible = false;
		}

		public void SetEpsilonVisibility(string nazwa)
		{
			EpsilonLabel.Visible = true;
			EpsilonBox.Visible = true;

			if (nazwa == Nazwy.strCalka)
			{
				EpsilonBox.Text = Nazwy.strPodajIloscOdcinkow;
			}
			else if (nazwa == Nazwy.strPierwiastek)
			{
				EpsilonBox.Text = Nazwy.strPodajEpsilon;
			}
		}

		public void SetEpsilonLabel(string w1)
		{
			EpsilonLabel.Text = w1;
		}

		#endregion Overloads

		private AlgorytmyUC algorytmyUC;//dostęp do górnego panelu

		public void SetUC(AlgorytmyUC algorytmyUC)
		{
			this.algorytmyUC = algorytmyUC;
		}

		public Universal()
		{
			InitializeComponent();
		}

		private void Universal_Load(object sender, EventArgs e)
		{
			inputBox1.ForeColor = Color.SlateGray;
			inputBox1.Text = Nazwy.strPodajArgument;
			inputBox2.ForeColor = Color.SlateGray;
			inputBox2.Text = Nazwy.strPodajArgument;
			EpsilonBox.ForeColor = Color.SlateGray;

			RunAlgorithms.SetUniversal(this);

			string temp = algorytmyUC.GetTitle();

			if (temp == Nazwy.strEuklides)
			{
				HelpLabel.Text = Nazwy.iNWD;
			}
			else if (temp == Nazwy.strSilnia)
			{
				HelpLabel.Text = Nazwy.iSilnia;
			}
			else if (temp == Nazwy.strPierwsza)
			{
				HelpLabel.Text = Nazwy.iPierwsza;
			}
			else if (temp == Nazwy.strSumaDzielnikow)
			{
				HelpLabel.Text = Nazwy.iSumaDzielników;
			}
			else if (temp == Nazwy.strCzynnikiPierwsze)
			{
				HelpLabel.Text = Nazwy.iCzynnikiPierwsze;
			}
			else if (temp == Nazwy.strSumaPrzedzialu)
			{
				HelpLabel.Text = Nazwy.iSumaPrzedziału;
			}
			else if (temp == Nazwy.strSumaCyfr)
			{
				HelpLabel.Text = Nazwy.iSumaCyfr;
			}
			else if (temp == Nazwy.strRNG)
			{
				HelpLabel.Text = Nazwy.iRNG;
			}
			else if (temp == Nazwy.strZerowe)
			{
				HelpLabel.Text = Nazwy.iZerowe;
			}
			else if (temp == Nazwy.strCalka)
			{
				HelpLabel.Text = Nazwy.iCałka;
			}
			else if (temp == Nazwy.strPierwiastek)
			{
				HelpLabel.Text = Nazwy.iPierwiastek;
			}
			else
			{
				HelpLabel.Text = "Unhandled exception";
			}
		}

		private void inputBox1_Enter(object sender, EventArgs e)
		{
			if (inputBox1.Text == Nazwy.strPodajArgument)
			{
				inputBox1.Text = "";
				inputBox1.ForeColor = Color.Maroon;
			}
		}

		private void inputBox1_Leave(object sender, EventArgs e)
		{
			if (inputBox1.Text == "")
			{
				inputBox1.Text = Nazwy.strPodajArgument;
				inputBox1.ForeColor = Color.SlateGray;
			}
		}

		private void inputBox2_Enter(object sender, EventArgs e)
		{
			if (inputBox2.Text == Nazwy.strPodajArgument)
			{
				inputBox2.Text = "";
				inputBox2.ForeColor = Color.Maroon;
			}
		}

		private void inputBox2_Leave(object sender, EventArgs e)
		{
			if (inputBox2.Text == "")
			{
				inputBox2.Text = Nazwy.strPodajArgument;
				inputBox2.ForeColor = Color.SlateGray;
			}
		}

		private void ObliczButton_Click(object sender, EventArgs e)
		{
			if ((algorytmyUC.GetTitle() == Nazwy.strZerowe || algorytmyUC.GetTitle() == Nazwy.strCalka) && AlgorytmyZachlanne.Fankszyn == null)
			{
				DialogResult dialogResult = MessageBox.Show(Nazwy.emsgBłądFunkcji, Nazwy.eBłąd, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				if (dialogResult == DialogResult.Yes)
				{
					RunAlgorithms.LosujFunkcje();
					MessageBox.Show(Nazwy.eWylosowano, Nazwy.eSukces, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			if (inputBox1.Text == "" || inputBox1.Text == Nazwy.strPodajArgument)
			{
				MessageBox.Show(Nazwy.emsgBłądArgumentu, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (EpsilonBox.Visible && (algorytmyUC.GetTitle() == Nazwy.strPierwiastek || algorytmyUC.GetTitle() == Nazwy.strZerowe))
			{
				string content = EpsilonBox.Text;
				if (content.IndexOf('.') > -1)
				{
					content = content.Replace('.', ',');
				}
				AlgorytmyZachlanne.Eps = double.Parse(content);//przecinek zamiast kropki LOL
			}
			else if (EpsilonBox.Visible && algorytmyUC.GetTitle() == Nazwy.strCalka)
			{
				bool czy = uint.TryParse(EpsilonBox.Text, out uint content);
				if (czy)
				{
					AlgorytmyZachlanne.IloscOdcinkow = content;
				}
				else
				{
					MessageBox.Show(Nazwy.emsgIlośćOdcinków, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			string argument1 = inputBox1.Text;
			string argument2 = inputBox2.Text;
			try
			{
				RunAlgorithms.Run(algorytmyUC.GetTitle(), argument1, argument2);
			}
			catch (ArgumentException)
			{
				MessageBox.Show(Nazwy.emsgBłądArgumentu, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (FormatException)
			{
				MessageBox.Show(Nazwy.emsgFormatWejścia, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception)
			{
				MessageBox.Show(Nazwy.emsgException, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CopyButton1_Click(object sender, EventArgs e)
		{
			if (outputBox1.Text != "")
				Clipboard.SetText(outputBox1.Text);
		}

		private void CopyButton2_Click(object sender, EventArgs e)
		{
			if (outputBox2.Text != "")
				Clipboard.SetText(outputBox2.Text);
		}

		private void EpsilonBox_Enter(object sender, EventArgs e)
		{
			if (EpsilonBox.Text == Nazwy.strPodajEpsilon || EpsilonBox.Text == Nazwy.strPodajIloscOdcinkow)
			{
				EpsilonBox.Text = "";
				EpsilonBox.ForeColor = Color.Maroon;
			}
		}
	}
}