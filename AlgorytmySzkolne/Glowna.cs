using System;
using System.Windows.Forms;
using AlgorytmySzkolne.ContentUCs;

namespace AlgorytmySzkolne
{
	public partial class Glowna : Form
    {
        public static void ShowMessageBox(string kejs)
        {
            switch (kejs)
            {
                case "ZaDuzySystem":
                    MessageBox.Show("Maksymalna podstawa systemu liczbowego to 36 !", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "Argument":
                    MessageBox.Show("Nieprawidłowy format wejścia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "Inny":
                    MessageBox.Show("Coś poszło nie tak.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public Glowna()
        {
            InitializeComponent();
        }

        private void Glowna_Load(object sender, EventArgs e)
        {
            this.algorytmyUC1.SetTitle(Nazwy.strGlowna);
            var homepage = new Homepage();
            AlgorytmyUC.AddToList(Nazwy.strGlowna, homepage);
            homepage.SetUC(algorytmyUC1);
            algorytmyUC1.SetPanel(homepage);
            //AlgorytmyUC.CurrentLanguage = Nazwy.lPolski;
        }

        private void Glowna_OnClose(object sender, FormClosingEventArgs e)//Form.Closing
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wyjść z aplikacji?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Glowna_Close(object sender, FormClosedEventArgs e)
        {
        }

        private void algorytmyUC1_Load(object sender, EventArgs e)
        {
        }

        private void Glowna_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Back)//co z wpisywaniem??
            //{
            //    algorytmyUC1.GoBack();
            //}
            //else if (e.KeyCode == Keys.I)
            //{
            //    var infopage = new InfoPage();
            //    algorytmyUC1.SetTitle(Nazwy.strInfo);
            //    AlgorytmyUC.AddToList(Nazwy.strInfo, infopage);
            //    algorytmyUC1.SetPanel(infopage);
            //}
            //else if (e.KeyCode == Keys.H)
            //{
            //    var help = new ContentUCs.Help();
            //    var content = algorytmyUC1.GetPanel();
            //    help.Run(content);
            //    help.Show();
            //}
            //else
            //{
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else
            {
                var control = algorytmyUC1.GetPanel();
                int index = -1;

                if (control is Klasyczne)//działa
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D1:
                            index = 1;
                            break;

                        case Keys.D2:
                            index = 2;

                            break;

                        case Keys.D3:
                            index = 3;

                            break;

                        case Keys.D4:
                            index = 4;

                            break;

                        case Keys.D5:
                            index = 5;

                            break;

                        case Keys.D6:
                            index = 6;

                            break;

                        case Keys.D7:
                            index = 7;

                            break;

                        case Keys.D8:
                            index = 8;

                            break;

                        default:
                            break;
                    }
                    if (index != -1)
                    {
                        foreach (Button b in control.Controls)
                        {
                            if (b.TabIndex == index)
                            {
                                b.Select();
                            }
                        }
                    }
                }
                else if (control is Homepage)//działa
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D1:
                            index = 0;
                            break;

                        case Keys.D2:
                            index = 1;

                            break;

                        case Keys.D3:
                            index = 2;

                            break;

                        case Keys.D4:
                            index = 3;

                            break;

                        case Keys.D5:
                            index = 4;

                            break;

                        case Keys.D6:
                            index = 5;

                            break;

                        default:
                            break;
                    }
                    if (index != -1)
                    {
                        foreach (Button b in control.Controls)
                        {
                            if (b.TabIndex == index)
                            {
                                b.Select();
                            }
                        }
                    }
                }
                else if (control is Zachlanne)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D1:
                            index = 5;
                            break;

                        case Keys.D2:
                            index = 6;

                            break;

                        case Keys.D3:
                            index = 2;

                            break;

                        case Keys.D4:
                            index = 3;

                            break;

                        case Keys.D5:
                            index = 4;

                            break;

                        default:
                            break;
                    }
                    if (index != -1)
                    {
                        foreach (Button b in control.Controls)
                        {
                            if (b.TabIndex == index)
                            {
                                b.Select();
                            }
                        }
                    }
                }
                else if (control is Projekty)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D1:
                            index = 0;
                            break;

                        case Keys.D2:
                            index = 1;

                            break;

                        case Keys.D3:
                            index = 2;

                            break;

                        case Keys.D4:
                            index = 3;
                            break;

                        default:
                            break;
                    }
                    if (index != -1)
                    {
                        foreach (Button b in control.Controls)
                        {
                            if (b.TabIndex == index)
                            {
                                b.Select();
                            }
                        }
                    }
                }
                // }
            }
        }
    }
}