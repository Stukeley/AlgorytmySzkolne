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
					MessageBox.Show("Wylosowano funkcję pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Nieporawnie podano stopień losowej funkcji. Pamiętaj, że dozwolone są tylko liczby całkowite dodatnie.",
						"Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
						MessageBox.Show("Ustawiono funkcję pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
							MessageBox.Show("Ustawiono funkcję pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}

				if (AlgorytmyZachlanne.TypFankszynu == Nazwy.fWielomian)
				{
					bool sprawdz = ushort.TryParse(StopienBox1.Text, out ushort temp);
					if (sprawdz)
					{
						AlgorytmyZachlanne.Stopien = temp;
						MessageBox.Show("Ustawiono funkcję pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Nieprawidłowy stopień funkcji", "Błąd stopnia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
						MessageBox.Show("Ustawiono funkcję pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Nieprawidłowy stopień funkcji", "Błąd stopnia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else if (AlgorytmyZachlanne.TypFankszynu == Nazwy.fPieriwastek)
				{
					bool sprawdz1 = ushort.TryParse(StopienBox1.Text, out ushort temp1);
					bool sprawdz2 = ushort.TryParse(StopienBox2.Text, out ushort temp2);
					if (sprawdz1 && sprawdz2)
					{
						AlgorytmyZachlanne.stF = temp1;
						AlgorytmyZachlanne.stPierw = temp2;
						MessageBox.Show("Ustawiono funkcję pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Nieprawidłowy stopień funkcji", "Błąd stopnia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
			//tutaj
		}

		private void FunctionChoiceBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			string selection = FunctionChoiceBox.GetItemText(FunctionChoiceBox.SelectedItem);
			ArgumentChoiceBox1.ResetText();

			switch (selection)
			{
				case Nazwy.fWielomian:
					StopienBox1.Visible = true;
					StopienBox1.Text = "Podaj stopień";
					StopienBox1.ForeColor = Color.SlateGray;
					StopienBox1.Location = new Point(322, 57);
					StopienBox2.Visible = false;
					HelpLabel.Visible = true;
					HelpLabel.Text = String.Format("Wybierz stopień wielomianu, a nastepnie podaj wszystkie{0}współczynniki oddzielone spacjami. Podaj współczynniki{0}nawet gdy " +
						"wynoszą one zero.{0}Ułamki póki co nie działają, więc podaj tylko liczby całkowite.", Environment.NewLine);
					SetFunctionBox.Text = "Przyklad: 1 0 3 2 4 0";
					SetFunctionBox.ForeColor = Color.SlateGray;
					SetFunctionButton.Visible = true;
					break;

				case Nazwy.fWymierna:
					StopienBox1.Visible = true;
					StopienBox1.Text = "Podaj st. licznika";
					StopienBox1.ForeColor = Color.SlateGray;
					StopienBox1.Location = new Point(240, 57);
					StopienBox2.Visible = true;
					StopienBox2.Text = "Podaj st. mianownika";
					StopienBox2.ForeColor = Color.SlateGray;
					HelpLabel.Visible = true;
					HelpLabel.Text = String.Format("Wybierz stopień licznika i mianownika, a nastepnie podaj wszystkie{0}współczynniki oddzielone spacjami w nawiasach{0}(rownież oddzielonych spacjami) poprzedzonych" +
						"literami L i M. Ułamki póki co nie dzialają, więc podaj tylko liczby całkowite.", Environment.NewLine);
					SetFunctionBox.Text = "Przyklad: L(2 1 3 0) M(7 1 2)";
					SetFunctionBox.ForeColor = Color.SlateGray;
					SetFunctionButton.Visible = true;
					break;

				case Nazwy.fPieriwastek:
					StopienBox1.Visible = true;
					StopienBox1.Text = "Podaj st. funkcji";
					StopienBox1.ForeColor = Color.SlateGray;
					StopienBox1.Location = new Point(240, 57);
					StopienBox2.Visible = true;
					StopienBox2.Text = "Podaj st. pierw.";
					StopienBox2.ForeColor = Color.SlateGray;
					HelpLabel.Visible = true;
					HelpLabel.Text = String.Format("Wybierz stopień funkcji pod pierwiastkiem oraz stopień pierwiastka.{0}Następnie podaj stopień pierwiastka poprzedzony " +
						"literą S, po czym{0}podaj oddzielone spacjami wszystkie współczynniki, nawet gdy wynoszą 0. Ułamki póki co nie dzialaja, więc podaj tylko liczby calkowite.", Environment.NewLine);
					SetFunctionBox.Text = "Przyklad: S3 2 1 -3 0";
					SetFunctionBox.ForeColor = Color.SlateGray;
					SetFunctionButton.Visible = true;
					break;

				case Nazwy.fLosuj:
					StopienBox1.Visible = true;
					StopienBox1.Text = "Podaj stopień";
					StopienBox1.ForeColor = Color.SlateGray;
					StopienBox1.Location = new Point(322, 57);
					StopienBox2.Visible = false;
					HelpLabel.Visible = true;
					HelpLabel.Text = String.Format("Podaj stopień funkcji (musi być to liczba całkowita dodatnia).{0}Następnie program sam wylosuje wszystkie współczynniki " +
						"i funkcja będzie gotowa do użycia.", Environment.NewLine);
					SetFunctionBox.Visible = false;
					SetFunctionButton.Visible = true;
					break;

				default:
					StopienBox1.Visible = false;
					StopienBox2.Visible = false;
					HelpLabel.Visible = true;
					HelpLabel.Text = "Wybierz typ argumentu.";
					ArgumentChoiceBox1.Visible = true;
					ArgumentChoiceBox1.Text = "Wybierz agrument";
					SetFunctionBox.Text = "";
					SetFunctionBox.ForeColor = Color.Maroon;
					break;
			}
		}

		private void StopienBox1_Enter(object sender, EventArgs e)
		{
			if (StopienBox1.Text == "Podaj stopień" || StopienBox1.Text == "Podaj st. licznika" || StopienBox1.Text == "Podaj st. funkcji")
			{
				StopienBox1.Text = "";
				StopienBox1.ForeColor = Color.Maroon;
			}
		}

		private void SetFunction_Load(object sender, EventArgs e)
		{
		}

		private void ArgumentChoiceBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			string selection = ArgumentChoiceBox1.GetItemText(ArgumentChoiceBox1.SelectedItem);
			SetFunctionButton.Visible = true;
			switch (selection)
			{
				case Nazwy.aX:
					StopienBox1.Visible = true;
					StopienBox1.Text = "Podaj stopien";
					StopienBox1.ForeColor = Color.SlateGray;
					StopienBox1.Location = new Point(322, 57);
					HelpLabel.Text = String.Format("Podaj stopień argumentu, a następnie wszystkie{0}współczynniki oddzielone spacjami. Podaj współczynniki{0}nawet gdy " +
						"wynoszą one zero. Póki co bez ułamków, ale już wkrótce!", Environment.NewLine);
					SetFunctionBox.Text = "Przyklad: 1 0 3 2 4 0";
					SetFunctionBox.ForeColor = Color.SlateGray;
					break;

				case Nazwy.aPI:
					StopienBox1.Visible = false;
					HelpLabel.Text = String.Format("Funkcja {0}(x) przesunięta o podaną ilość PI, np.{1}{0}(x+0,3). Może zawierać ułamki, ale tylko w postaci dziesiętnej. " +
						"Podaj tylko liczbę.", FunctionChoiceBox.GetItemText(FunctionChoiceBox.SelectedItem), Environment.NewLine);
					SetFunctionBox.Text = "Przyklad: 2,78";
					SetFunctionBox.ForeColor = Color.SlateGray;
					break;
			}
		}

		private void StopienBox2_Enter(object sender, EventArgs e)
		{
			if (StopienBox2.Text == "Podaj st. mianownika" || StopienBox2.Text == "Podaj st. pierw.")
			{
				StopienBox2.Text = "";
				StopienBox2.ForeColor = Color.Maroon;
			}
		}

		private void SetFunctionBox_Enter(object sender, EventArgs e)
		{
			string content = SetFunctionBox.Text;
			if (content == "Przyklad: L(2 1 3 0) M(7 1 2)" || content == "Przyklad: S3 2 1 -3 0" || content == "Przyklad: 1 0 3 2 4 0" || content == "Przyklad: 2,78")
			{
				SetFunctionBox.Text = "";
				SetFunctionBox.ForeColor = Color.Maroon;
			}
		}
	}
}