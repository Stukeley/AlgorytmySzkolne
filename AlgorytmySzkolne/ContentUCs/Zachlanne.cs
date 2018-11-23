using System;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class Zachlanne : UserControl
	{
		private AlgorytmyUC algorytmyUC;

		public void SetUC(AlgorytmyUC algorytmyUC)
		{
			this.algorytmyUC = algorytmyUC;
		}

		public Zachlanne()
		{
			InitializeComponent();
		}

		private void UstawFunkcjeButton_Click(object sender, EventArgs e)
		{
			var ustaw = new SetFunction();

			algorytmyUC.SetTitle(Nazwy.strUstaw);
			AlgorytmyUC.AddToList(Nazwy.strUstaw, ustaw);

			algorytmyUC.SetPanel(ustaw);
		}

		private void MiejsceZeroweButton_Click(object sender, EventArgs e)
		{
			var zerowe = new Universal();
			zerowe.SetSecondOutputVisibility();
			zerowe.SetEpsilonLabel(Nazwy.strPodajEpsilon);

			algorytmyUC.SetTitle(Nazwy.strZerowe);
			zerowe.SetLabels(Nazwy.strPrzedział1, Nazwy.strPrzedział2, Nazwy.strZerowe);
			zerowe.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strZerowe, zerowe);

			algorytmyUC.SetPanel(zerowe);
		}

		private void PierwiastekButton_Click(object sender, EventArgs e)
		{
			var pierwiastek = new Universal();
			pierwiastek.SetVisibility();
			pierwiastek.SetEpsilonVisibility(Nazwy.strPierwiastek);
			pierwiastek.SetEpsilonLabel(Nazwy.strPodajEpsilon);

			algorytmyUC.SetTitle(Nazwy.strPierwiastek);
			pierwiastek.SetLabels(Nazwy.strPodajLiczbę, Nazwy.strPierwiastek2);
			pierwiastek.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strPierwiastek, pierwiastek);

			algorytmyUC.SetPanel(pierwiastek);
		}

		private void CalkaButton_Click(object sender, EventArgs e)
		{
			var calka = new Universal();
			calka.SetSecondOutputVisibility();
			calka.SetEpsilonVisibility(Nazwy.strCalka);
			calka.SetEpsilonLabel(Nazwy.strPodajIloscOdcinkow);

			algorytmyUC.SetTitle(Nazwy.strCalka);
			calka.SetLabels(Nazwy.strPrzedział1, Nazwy.strPrzedział2, Nazwy.strCalka2);
			calka.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strCalka, calka);

			algorytmyUC.SetPanel(calka);
		}

		private void PokazFunkcjeButton_Click(object sender, EventArgs e)
		{
			string f = AlgorytmyZachlanne.Fankszyn;
			if (string.IsNullOrEmpty(f))
			{
				MessageBox.Show(Nazwy.emsgNiePodanoFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MessageBox.Show(Nazwy.iTypFunkcji + AlgorytmyZachlanne.TypFankszynu + Environment.NewLine + Nazwy.iFunkcja + f,
					Nazwy.iFunkcja, MessageBoxButtons.OK);
			}
		}
	}
}