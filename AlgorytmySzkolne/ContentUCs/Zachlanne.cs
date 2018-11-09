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

		private void Zachlanne_Load(object sender, EventArgs e)
		{
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
			zerowe.SetLabels("Podaj początek przedziału", "Podaj koniec przedziału", "Miejsce zerowe");
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
			pierwiastek.SetLabels("Podaj liczbę", "Pierwiastek kwadratowy z liczby");
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
			calka.SetLabels("Podaj początek przedziału", "Podaj koniec przedziału", "Pole pod wykresem");
			calka.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strCalka, calka);

			algorytmyUC.SetPanel(calka);
		}

		private void PokazFunkcjeButton_Click(object sender, EventArgs e)
		{
			string f = AlgorytmyZachlanne.Fankszyn;
			if (string.IsNullOrEmpty(f))
			{
				MessageBox.Show("Nie podano wzoru funkcji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MessageBox.Show(f, "Wzór funkcji", MessageBoxButtons.OK);
			}
		}
	}
}