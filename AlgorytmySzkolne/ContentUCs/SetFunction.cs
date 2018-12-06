using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class SetFunction : UserControl
	{
		public SetFunction()
		{
			InitializeComponent();
		}

		private void SetFunctionButton_Click(object sender, EventArgs e)
		{
			var typ = FunctionChoiceBox.GetItemText(FunctionChoiceBox.SelectedItem);

			if (typ == Nazwy.fLosuj)//wylosuj funkcję o danym stopniu
			{
				bool sprawdz = ushort.TryParse(StopienBox1.Text, out ushort result);
				if (sprawdz)
				{
					RunAlgorithms.LosujFunkcje(result);
					MessageBox.Show(Nazwy.eWylosowano, Nazwy.eSukces, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show(Nazwy.emsgStopieńLosowejFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				AlgorytmyZachlanne.Fankszyn = SetFunctionBox.Text;
				AlgorytmyZachlanne.TypFankszynu = typ;
				if (ArgumentChoiceBox1.Visible)
				{
					if (ArgumentChoiceBox1.GetItemText(ArgumentChoiceBox1.SelectedItem) == Nazwy.aX)
					{
						AlgorytmyZachlanne.TypArgumentu = Nazwy.aX;
						MessageBox.Show(Nazwy.eUstawiono, Nazwy.eSukces, MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (ArgumentChoiceBox1.GetItemText(ArgumentChoiceBox1.SelectedItem) == Nazwy.aPI)
					{
						AlgorytmyZachlanne.TypArgumentu = Nazwy.aPI;

						string selection = SetFunctionBox.Text;
						if (selection.IndexOf('.') > 0)
							selection = selection.Replace('.', ',');

						bool sprawdz = double.TryParse(selection, out double temp);
						if (sprawdz)
						{
							AlgorytmyZachlanne.IloscPI = temp;
							MessageBox.Show(Nazwy.eUstawiono, Nazwy.eSukces, MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else//gdy użytkownik poda coś swojego zamiast wyboru z listy
					{
						MessageBox.Show("Incorrect type of argument! Please choose one from the list, rather than typing something in.", Nazwy.eBłąd,
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

				if (AlgorytmyZachlanne.TypFankszynu == Nazwy.fWielomian)
				{
					bool sprawdz = ushort.TryParse(StopienBox1.Text, out ushort temp);
					if (sprawdz)
					{
						AlgorytmyZachlanne.Stopien = temp;
						MessageBox.Show(Nazwy.eUstawiono, Nazwy.eUstawiono, MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show(Nazwy.emsgNieprawidłowyStopień, Nazwy.eBłądStopnia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else if (AlgorytmyZachlanne.TypFankszynu == Nazwy.fWymierna)
				{
					bool sprawdz1 = ushort.TryParse(StopienBox1.Text, out ushort temp1);
					bool sprawdz2 = ushort.TryParse(StopienBox2.Text, out ushort temp2);
					if (sprawdz1 && sprawdz2)
					{
						AlgorytmyZachlanne.stLicz = temp1;
						AlgorytmyZachlanne.stMian = temp2;
						MessageBox.Show(Nazwy.eUstawiono, Nazwy.eSukces, MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show(Nazwy.emsgNieprawidłowyStopień, Nazwy.eBłądStopnia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else if (AlgorytmyZachlanne.TypFankszynu == Nazwy.fPierwiastek)
				{
					bool sprawdz1 = ushort.TryParse(StopienBox1.Text, out ushort temp1);
					bool sprawdz2 = ushort.TryParse(StopienBox2.Text, out ushort temp2);
					if (sprawdz1 && sprawdz2)
					{
						AlgorytmyZachlanne.stF = temp1;
						AlgorytmyZachlanne.stPierw = temp2;
						MessageBox.Show(Nazwy.eUstawiono, Nazwy.eSukces, MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show(Nazwy.emsgNieprawidłowyStopień, Nazwy.eBłądStopnia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else if (AlgorytmyZachlanne.TypFankszynu == Nazwy.fSin || AlgorytmyZachlanne.TypFankszynu == Nazwy.fCos ||
							AlgorytmyZachlanne.TypFankszynu == Nazwy.fTg || AlgorytmyZachlanne.TypFankszynu == Nazwy.fCtg)
				{
					//
				}
				else//gdy użytkownik poda coś swojego zamiast wyboru z listy
				{
					MessageBox.Show("Incorrect type of function! Please choose one from the list, rather than typing something in.", Nazwy.eBłąd,
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			//tutaj
		}

		private void FunctionChoiceBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			string selection = FunctionChoiceBox.GetItemText(FunctionChoiceBox.SelectedItem);
			ArgumentChoiceBox1.ResetText();

			if (selection == Nazwy.fWielomian)
			{
				StopienBox1.Visible = true;
				StopienBox1.Text = Nazwy.bPodajStopień;
				StopienBox1.ForeColor = Color.SlateGray;
				StopienBox1.Location = new Point(322, 57);
				StopienBox2.Visible = false;
				HelpLabel.Visible = true;
				//HelpLabel.Text = String.Format("Wybierz stopień wielomianu, a nastepnie podaj wszystkie{0}współczynniki oddzielone spacjami. Podaj współczynniki{0}nawet gdy " +
				//	"wynoszą one zero.{0}Ułamki póki co nie działają, więc podaj tylko liczby całkowite.", Environment.NewLine);
				HelpLabel.Text = Nazwy.iFWielomian;
				SetFunctionBox.Text = Nazwy.bPrzykład + ": 1 0 3 2 4 0";
				SetFunctionBox.ForeColor = Color.SlateGray;
				SetFunctionButton.Visible = true;
				ArgumentChoiceBox1.Visible = false;
			}
			else if (selection == Nazwy.fWymierna)
			{
				StopienBox1.Visible = true;
				StopienBox1.Text = Nazwy.bPodajStopieńLicznika;
				StopienBox1.ForeColor = Color.SlateGray;
				StopienBox1.Location = new Point(240, 57);
				StopienBox2.Visible = true;
				StopienBox2.Text = Nazwy.bPodajStopieńMianownika;
				StopienBox2.ForeColor = Color.SlateGray;
				HelpLabel.Visible = true;
				//HelpLabel.Text = String.Format("Wybierz stopień licznika i mianownika, a nastepnie podaj wszystkie{0}współczynniki oddzielone spacjami w nawiasach{0}(rownież oddzielonych spacjami) poprzedzonych" +
				//	"literami L i M. Ułamki póki co nie dzialają, więc podaj tylko liczby całkowite.", Environment.NewLine);
				HelpLabel.Text = Nazwy.iFWymierna;
				SetFunctionBox.Text = Nazwy.bPrzykład + ": L(2 1 3 0) M(7 1 2)";
				SetFunctionBox.ForeColor = Color.SlateGray;
				SetFunctionButton.Visible = true;
				ArgumentChoiceBox1.Visible = false;
			}
			else if (selection == Nazwy.fPierwiastek)
			{
				StopienBox1.Visible = true;
				StopienBox1.Text = Nazwy.bPodajStopieńFunkcji;
				StopienBox1.ForeColor = Color.SlateGray;
				StopienBox1.Location = new Point(240, 57);
				StopienBox2.Visible = true;
				StopienBox2.Text = Nazwy.bPodajStopieńPierwiastka;
				StopienBox2.ForeColor = Color.SlateGray;
				HelpLabel.Visible = true;
				//HelpLabel.Text = String.Format("Wybierz stopień funkcji pod pierwiastkiem oraz stopień pierwiastka.{0}Następnie podaj stopień pierwiastka poprzedzony " +
				//	"literą S, po czym{0}podaj oddzielone spacjami wszystkie współczynniki, nawet gdy wynoszą 0. Ułamki póki co nie dzialaja, więc podaj tylko liczby calkowite.", Environment.NewLine);
				HelpLabel.Text = Nazwy.iFPierwiastek;
				SetFunctionBox.Text = Nazwy.bPrzykład + ": S3 2 1 -3 0";
				SetFunctionBox.ForeColor = Color.SlateGray;
				SetFunctionButton.Visible = true;
				ArgumentChoiceBox1.Visible = false;
			}
			else if (selection == Nazwy.fLosuj)
			{
				StopienBox1.Visible = true;
				StopienBox1.Text = Nazwy.bPodajStopień;
				StopienBox1.ForeColor = Color.SlateGray;
				StopienBox1.Location = new Point(322, 57);
				StopienBox2.Visible = false;
				HelpLabel.Visible = true;
				//HelpLabel.Text = String.Format("Podaj stopień funkcji (musi być to liczba całkowita dodatnia).{0}Następnie program sam wylosuje wszystkie współczynniki " +
				//	"i funkcja będzie gotowa do użycia.", Environment.NewLine);
				HelpLabel.Text = Nazwy.iFLosuj;
				SetFunctionBox.Visible = false;
				SetFunctionButton.Visible = true;
				ArgumentChoiceBox1.Visible = false;
			}
			else if (selection == Nazwy.fAlternatywa)
			{
				var alt = new Alternative();
				alt.Show();
			}
			else if (selection == Nazwy.fSin || selection == Nazwy.fCos || selection == Nazwy.fTg || selection == Nazwy.fCtg)
			{
				StopienBox1.Visible = false;
				StopienBox2.Visible = false;
				HelpLabel.Visible = true;
				HelpLabel.Text = Nazwy.bWybierzTypArgumentu;
				ArgumentChoiceBox1.Visible = true;
				ArgumentChoiceBox1.Text = Nazwy.bWybierzArgument;
				SetFunctionBox.Text = "";
				SetFunctionBox.ForeColor = Color.Maroon;
			}
		}

		private void StopienBox1_Enter(object sender, EventArgs e)
		{
			if (StopienBox1.Text == Nazwy.bPodajStopień || StopienBox1.Text == Nazwy.bPodajStopieńLicznika || StopienBox1.Text == Nazwy.bPodajStopieńFunkcji)
			{
				StopienBox1.Text = "";
				StopienBox1.ForeColor = Color.Maroon;
			}
		}

		private void ArgumentChoiceBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			string selection = ArgumentChoiceBox1.GetItemText(ArgumentChoiceBox1.SelectedItem);
			SetFunctionButton.Visible = true;

			if (selection == Nazwy.aX)
			{
				StopienBox1.Visible = true;
				StopienBox1.Text = Nazwy.bPodajStopień;
				StopienBox1.ForeColor = Color.SlateGray;
				StopienBox1.Location = new Point(322, 57);
				//HelpLabel.Text = String.Format("Podaj stopień argumentu, a następnie wszystkie{0}współczynniki oddzielone spacjami. Podaj współczynniki{0}nawet gdy " +
				//	"wynoszą one zero. Póki co bez ułamków, ale już wkrótce!", Environment.NewLine);
				HelpLabel.Text = Nazwy.iFTrygonometrycznaX;
				SetFunctionBox.Text = Nazwy.bPrzykład + ": 1 0 3 2 4 0";
				SetFunctionBox.ForeColor = Color.SlateGray;
				SetFunctionButton.Visible = true;
			}
			else if (selection == Nazwy.aPI)
			{
				StopienBox1.Visible = false;
				//HelpLabel.Text = String.Format("Funkcja {0}(x) przesunięta o podaną ilość PI, np.{1}{0}(x+0,3). Może zawierać ułamki, ale tylko w postaci dziesiętnej. " +
				//	"Podaj tylko liczbę.", FunctionChoiceBox.GetItemText(FunctionChoiceBox.SelectedItem), Environment.NewLine);
				HelpLabel.Text = Nazwy.iFTrygonometrycznaPI;
				SetFunctionBox.Text = Nazwy.bPrzykład + ": 2,78";
				SetFunctionBox.ForeColor = Color.SlateGray;
				SetFunctionButton.Visible = true;
			}
		}

		private void StopienBox2_Enter(object sender, EventArgs e)
		{
			if (StopienBox2.Text == Nazwy.bPodajStopieńMianownika || StopienBox2.Text == Nazwy.bPodajStopieńPierwiastka)
			{
				StopienBox2.Text = "";
				StopienBox2.ForeColor = Color.Maroon;
			}
		}

		private void SetFunctionBox_Enter(object sender, EventArgs e)
		{
			string content = SetFunctionBox.Text;
			if (content == Nazwy.bPrzykład + ": L(2 1 3 0) M(7 1 2)" || content == Nazwy.bPrzykład + ": S3 2 1 -3 0" || content == Nazwy.bPrzykład + ": 1 0 3 2 4 0"
				|| content == Nazwy.bPrzykład + ": 2,78")
			{
				SetFunctionBox.Text = "";
				SetFunctionBox.ForeColor = Color.Maroon;
			}
		}
	}
}