using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class Alternative : Form
	{
		public Alternative()
		{
			InitializeComponent();
		}

		private void PodajButton_Click(object sender, EventArgs e)
		{
			string funkcja = "";
			ushort stopień = 0;
			bool first = false;

			#region Garbage

			bool czy = double.TryParse(Box5.Text, out double result);
			if (czy)
			{
				if (!first && result != 0)
				{
					first = true;
					funkcja = funkcja + result + " ";
					stopień = 5;
				}
			}
			else
			{
				MessageBox.Show(Nazwy.emsgNiepoprawnyWspółczynnikFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			czy = double.TryParse(Box4.Text, out result);
			if (czy)
			{
				if (!first && result != 0)
				{
					first = true;
					funkcja = funkcja + result + " ";
					stopień = 4;
				}
				else if (first)
				{
					funkcja = funkcja + result + " ";
				}
			}
			else
			{
				MessageBox.Show(Nazwy.emsgNiepoprawnyWspółczynnikFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			czy = double.TryParse(Box3.Text, out result);
			if (czy)
			{
				if (!first && result != 0)
				{
					first = true;
					funkcja = funkcja + result + " ";
					stopień = 3;
				}
				else if (first)
				{
					funkcja = funkcja + result + " ";
				}
			}
			else
			{
				MessageBox.Show(Nazwy.emsgNiepoprawnyWspółczynnikFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			czy = double.TryParse(Box2.Text, out result);
			if (czy)
			{
				if (!first && result != 0)
				{
					first = true;
					funkcja = funkcja + result + " ";
					stopień = 2;
				}
				else if (first)
				{
					funkcja = funkcja + result + " ";
				}
			}
			else
			{
				MessageBox.Show(Nazwy.emsgNiepoprawnyWspółczynnikFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			czy = double.TryParse(Box1.Text, out result);
			if (czy)
			{
				if (!first && result != 0)
				{
					first = true;
					funkcja = funkcja + result + " ";
					stopień = 1;
				}
				else if (first)
				{
					funkcja = funkcja + result + " ";
				}
			}
			else
			{
				MessageBox.Show(Nazwy.emsgNiepoprawnyWspółczynnikFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			czy = double.TryParse(Box0.Text, out result);
			if (czy)
			{
				if (!first && result != 0)
				{
					first = true;
					funkcja = funkcja + result + " ";
					stopień = 0;
				}
				else if (first)
				{
					funkcja = funkcja + result + " ";
				}
			}
			else
			{
				MessageBox.Show(Nazwy.emsgNiepoprawnyWspółczynnikFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			#endregion Garbage

			if (String.IsNullOrEmpty(funkcja))
			{
				MessageBox.Show(Nazwy.emsgNiepoprawnyWspółczynnikFunkcji, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				AlgorytmyZachlanne.Fankszyn = funkcja;
				AlgorytmyZachlanne.TypFankszynu = Nazwy.fWielomian;
				AlgorytmyZachlanne.Stopien = stopień;

				MessageBox.Show(Nazwy.eSukces, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}