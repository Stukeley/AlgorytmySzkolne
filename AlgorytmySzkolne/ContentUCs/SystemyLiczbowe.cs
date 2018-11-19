using System;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class SystemyLiczbowe : UserControl
	{
		public AlgorytmyUC algorytmyUC;

		public void SetUC(AlgorytmyUC algorytmyUC)
		{
			this.algorytmyUC = algorytmyUC;
		}

		public void SetResult(string wynik)
		{
			ResultBox.Text = wynik;
		}

		public SystemyLiczbowe()
		{
			InitializeComponent();
		}

		private void SystemyLiczbowe_Load(object sender, EventArgs e)
		{
		}

		private void ObliczButton_Click(object sender, EventArgs e)
		{
			string argument1 = GivenBox.Text;
			string argument2 = TargetBox.Text;
			string argument3 = NumberBox.Text;

			try
			{
				RunAlgorithms.Run(this, argument1, argument2, argument3);
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show(Nazwy.emsgPodstawaSystemu, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (ArgumentException)
			{
				MessageBox.Show(Nazwy.emsgBłądArgumentu, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception)
			{
				MessageBox.Show(Nazwy.emsgException, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}