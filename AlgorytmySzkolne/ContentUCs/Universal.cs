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
            inputBox1.Text = "Podaj argument";
            inputBox2.ForeColor = Color.SlateGray;
            inputBox2.Text = "Podaj argument";
            EpsilonBox.ForeColor = Color.SlateGray;

            RunAlgorithms.SetUniversal(this);

            switch (algorytmyUC.GetTitle())
            {
                case Nazwy.strEuklides:
                    HelpLabel.Text = "Podaj 2 liczby by uzyskać ich NWW i NWD.";
                    break;

                case Nazwy.strSilnia:
                    HelpLabel.Text = "";
                    break;

                case Nazwy.strPierwsza:
                    HelpLabel.Text = "";
                    break;

                case Nazwy.strSumaDzielnikow:
                    HelpLabel.Text = "";
                    break;

                case Nazwy.strCzynnikiPierwsze:
                    HelpLabel.Text = "";
                    break;

                case Nazwy.strSumaPrzedzialu:
                    HelpLabel.Text = "";
                    break;

                case Nazwy.strSumaCyfr:
                    HelpLabel.Text = "";
                    break;

                case Nazwy.strRNG:
                    HelpLabel.Text = "";
                    break;

                case Nazwy.strZerowe:
                    HelpLabel.Text = "Podaj początek i koniec przedziału by znaleźć miejsce zerowe. Pamiętaj, że jest to\n" +
                        "możliwe tylko gdy wartość funkcji na początku i końcu przedziału mają różne znaki.\n" +
                        "Pamiętaj również o podaniu wzoru funkcji przed uruchomieniem algorytmu. Jeżeli\n" +
                        "nie podano wzoru, istnieje możliwość jego wylosowania.";
                    break;

                case Nazwy.strCalka:
                    HelpLabel.Text = "Podaj dokładność(ilość odcinków) oraz początek i koniec przedziału by otrzymać\n" +
                        "pole pod wykresem podanej funkcji. Pamiętaj o podaniu wzoru funkcji przed uruchomieniem\n" +
                        "algorytmu. Jeżeli nie podano wzoru, istnieje możliwość jego wylosowania.\n" +
                        "Domyślna wartość: 10000 lub więcej.";
                    break;

                case Nazwy.strPierwiastek:
                    HelpLabel.Text = "Podaj dokładność obliczeń oraz liczbę aby otrzymać jej pierwiastek kwadratowy.\n" +
                        "Domyślna wartość: 0,0001 lub mniej. Dozwolone jest zarówno podawanie z kropką, jak i\n" +
                        "z przecinkiem.";
                    break;

                default:
                    MessageBox.Show("Coś poszło nie tak. To nie powinno było się stać.");
                    break;
            }
        }

        private void inputBox1_Enter(object sender, EventArgs e)
        {
            if (inputBox1.Text == "Podaj argument")
            {
                inputBox1.Text = "";
                inputBox1.ForeColor = Color.Maroon;
            }
        }

        private void inputBox1_Leave(object sender, EventArgs e)
        {
            if (inputBox1.Text == "")
            {
                inputBox1.Text = "Podaj argument";
                inputBox1.ForeColor = Color.SlateGray;
            }
        }

        private void inputBox2_Enter(object sender, EventArgs e)
        {
            if (inputBox2.Text == "Podaj argument")
            {
                inputBox2.Text = "";
                inputBox2.ForeColor = Color.Maroon;
            }
        }

        private void inputBox2_Leave(object sender, EventArgs e)
        {
            if (inputBox2.Text == "")
            {
                inputBox2.Text = "Podaj argument";
                inputBox2.ForeColor = Color.SlateGray;
            }
        }

        private void ObliczButton_Click(object sender, EventArgs e)
        {
            if ((algorytmyUC.GetTitle() == Nazwy.strZerowe || algorytmyUC.GetTitle() == Nazwy.strCalka) && AlgorytmyZachlanne.Fankszyn == null)
            {
                DialogResult dialogResult = MessageBox.Show("Nie podano funkcji! Czy chcesz wylosować wzór?", "Błąd", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    RunAlgorithms.LosujFunkcje();
                    MessageBox.Show("Wylosowano funkcję pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (inputBox1.Text == "" || inputBox1.Text == "Podaj argument")
            {
                MessageBox.Show("Błąd argumentu/ów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Błąd w ilości odcinków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Błąd argumentu/ów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Niepoprawny format wejścia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Coś poszło nie tak.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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