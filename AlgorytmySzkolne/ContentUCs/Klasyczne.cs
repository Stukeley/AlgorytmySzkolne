using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            euklides.SetLabels("Podaj pierwszą liczbę", "Podaj drugą liczbę", "Największy wspólny dzielnik", "Najmniejsza wielokrotność");
            euklides.SetUC(this.algorytmyUC);
            AlgorytmyUC.AddToList(Nazwy.strEuklides, euklides);

            algorytmyUC.SetPanel(euklides);
        }

        private void SilniaButton_Click(object sender, EventArgs e)
        {
            var silnia = new Universal();
            silnia.SetVisibility();

            algorytmyUC.SetTitle(Nazwy.strSilnia);
            silnia.SetLabels("Podaj liczbę", "Wynik");
            silnia.SetUC(this.algorytmyUC);
            AlgorytmyUC.AddToList(Nazwy.strSilnia, silnia);

            algorytmyUC.SetPanel(silnia);
        }

        private void PierwszaButton_Click(object sender, EventArgs e)
        {
            var pierwsza = new Universal();
            pierwsza.SetVisibility();

            algorytmyUC.SetTitle(Nazwy.strPierwsza);
            pierwsza.SetLabels("Podaj liczbę", "Liczba pierwsza?");
            pierwsza.SetUC(this.algorytmyUC);
            AlgorytmyUC.AddToList(Nazwy.strPierwsza, pierwsza);

            algorytmyUC.SetPanel(pierwsza);
        }

        private void DzielnikiButton_Click(object sender, EventArgs e)
        {
            var dzielniki = new Universal();
            dzielniki.SetVisibility();

            algorytmyUC.SetTitle(Nazwy.strSumaDzielnikow);
            dzielniki.SetLabels("Podaj liczbę", "Wynik");
            dzielniki.SetUC(this.algorytmyUC);
            AlgorytmyUC.AddToList(Nazwy.strSumaDzielnikow, dzielniki);

            algorytmyUC.SetPanel(dzielniki);
        }

        private void CzynnikiButton_Click(object sender, EventArgs e)
        {
            var czynniki = new Universal();
            czynniki.SetVisibility();

            algorytmyUC.SetTitle(Nazwy.strCzynnikiPierwsze);
            czynniki.SetLabels("Podaj liczbę", "Rozkład na czynniki");
            czynniki.SetUC(this.algorytmyUC);
            AlgorytmyUC.AddToList(Nazwy.strCzynnikiPierwsze, czynniki);

            algorytmyUC.SetPanel(czynniki);
        }

        private void SumaPrzedzialButton_Click(object sender, EventArgs e)
        {
            var przedzial = new Universal();
            przedzial.SetSecondOutputVisibility();

            algorytmyUC.SetTitle(Nazwy.strSumaPrzedzialu);
            przedzial.SetLabels("Podaj początek przedziału", "Podaj koniec przedziału", "Suma liczb całkowitych z tego przedziału");
            przedzial.SetUC(this.algorytmyUC);
            AlgorytmyUC.AddToList(Nazwy.strSumaPrzedzialu, przedzial);

            algorytmyUC.SetPanel(przedzial);
        }

        private void SumaCyfrButton_Click(object sender, EventArgs e)
        {
            var sumacyfr = new Universal();
            sumacyfr.SetVisibility();

            algorytmyUC.SetTitle(Nazwy.strSumaCyfr);
            sumacyfr.SetLabels("Podaj liczbę", "Wynik");
            sumacyfr.SetUC(this.algorytmyUC);
            AlgorytmyUC.AddToList(Nazwy.strSumaCyfr, sumacyfr);

            algorytmyUC.SetPanel(sumacyfr);
        }

        private void RNGButton_Click(object sender, EventArgs e)
        {
            var RNG = new Universal();
            RNG.SetSecondOutputVisibility();

            algorytmyUC.SetTitle(Nazwy.strRNG);
            RNG.SetLabels("Podaj dolną granicę", "Podaj górną granicę", "Liczba");
            RNG.SetUC(this.algorytmyUC);
            AlgorytmyUC.AddToList(Nazwy.strRNG, RNG);

            algorytmyUC.SetPanel(RNG);
        }
    }
}