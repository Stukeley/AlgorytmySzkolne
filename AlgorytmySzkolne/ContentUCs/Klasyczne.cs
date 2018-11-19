using System;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class Klasyczne : UserControl
	{
		private AlgorytmyUC algorytmyUC;

		public void SetUC(AlgorytmyUC algorytmyUC)
		{
			this.algorytmyUC = algorytmyUC;
		}

		public Klasyczne()
		{
			InitializeComponent();
		}

		private void Klasyczne_Load(object sender, EventArgs e)
		{
			AlgorytmyUC.currentUC = this;
		}

		private void EuklidesButton_Click(object sender, EventArgs e)
		{
			var euklides = new Universal();

			algorytmyUC.SetTitle(Nazwy.strEuklides);
			euklides.SetLabels(Nazwy.strPodajLiczbę1, Nazwy.strPodajLiczbę2, Nazwy.aDzielnik, Nazwy.aWielokrotność);
			euklides.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strEuklides, euklides);

			algorytmyUC.SetPanel(euklides);
		}

		private void SilniaButton_Click(object sender, EventArgs e)
		{
			var silnia = new Universal();
			silnia.SetVisibility();

			algorytmyUC.SetTitle(Nazwy.strSilnia);
			silnia.SetLabels(Nazwy.strPodajLiczbę, Nazwy.aWynik);
			silnia.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strSilnia, silnia);

			algorytmyUC.SetPanel(silnia);
		}

		private void PierwszaButton_Click(object sender, EventArgs e)
		{
			var pierwsza = new Universal();
			pierwsza.SetVisibility();

			algorytmyUC.SetTitle(Nazwy.strPierwsza);
			pierwsza.SetLabels(Nazwy.strPodajLiczbę, Nazwy.aPierwsza);
			pierwsza.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strPierwsza, pierwsza);

			algorytmyUC.SetPanel(pierwsza);
		}

		private void DzielnikiButton_Click(object sender, EventArgs e)
		{
			var dzielniki = new Universal();
			dzielniki.SetVisibility();

			algorytmyUC.SetTitle(Nazwy.strSumaDzielnikow);
			dzielniki.SetLabels(Nazwy.strPodajLiczbę, Nazwy.aWynik);
			dzielniki.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strSumaDzielnikow, dzielniki);

			algorytmyUC.SetPanel(dzielniki);
		}

		private void CzynnikiButton_Click(object sender, EventArgs e)
		{
			var czynniki = new Universal();
			czynniki.SetVisibility();

			algorytmyUC.SetTitle(Nazwy.strCzynnikiPierwsze);
			czynniki.SetLabels(Nazwy.strPodajLiczbę, Nazwy.aCzynniki);
			czynniki.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strCzynnikiPierwsze, czynniki);

			algorytmyUC.SetPanel(czynniki);
		}

		private void SumaPrzedzialButton_Click(object sender, EventArgs e)
		{
			var przedzial = new Universal();
			przedzial.SetSecondOutputVisibility();

			algorytmyUC.SetTitle(Nazwy.strSumaPrzedzialu);
			przedzial.SetLabels(Nazwy.strPrzedział1, Nazwy.strPrzedział2, Nazwy.aPrzedział);
			przedzial.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strSumaPrzedzialu, przedzial);

			algorytmyUC.SetPanel(przedzial);
		}

		private void SumaCyfrButton_Click(object sender, EventArgs e)
		{
			var sumacyfr = new Universal();
			sumacyfr.SetVisibility();

			algorytmyUC.SetTitle(Nazwy.strSumaCyfr);
			sumacyfr.SetLabels(Nazwy.strPodajLiczbę, Nazwy.aWynik);
			sumacyfr.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strSumaCyfr, sumacyfr);

			algorytmyUC.SetPanel(sumacyfr);
		}

		private void RNGButton_Click(object sender, EventArgs e)
		{
			var RNG = new Universal();
			RNG.SetSecondOutputVisibility();

			algorytmyUC.SetTitle(Nazwy.strRNG);
			RNG.SetLabels(Nazwy.strGranica1, Nazwy.strGranica2, Nazwy.aLiczba);
			RNG.SetUC(this.algorytmyUC);
			AlgorytmyUC.AddToList(Nazwy.strRNG, RNG);

			algorytmyUC.SetPanel(RNG);
		}
	}
}