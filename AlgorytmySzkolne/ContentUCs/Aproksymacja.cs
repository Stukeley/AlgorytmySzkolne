using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class Aproksymacja : Form
	{
		private Pen myPen = new Pen(Color.White);

		private int IloscPunktow = 0;
		private bool WasClicked = false;
		private int wkole, punkty;
		private int timeout = 0;

		public Aproksymacja()
		{
			InitializeComponent();
			myPen.Width = 1.5F;
		}

		private void RunButton_Click(object sender, EventArgs e)
		{
			bool czy = int.TryParse(InputBox.Text, out IloscPunktow);
			if (czy)
			{
				if (IloscPunktow < 1)
				{
					MessageBox.Show(Nazwy.emsgAproksymacjaPunkty, Nazwy.eBłąd,
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					IloscPunktow = 2000;
					InputBox.Text = "2000";
				}
			}
			else
			{
				MessageBox.Show(Nazwy.emsgAproksymacjaPunkty, Nazwy.eBłąd,
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				IloscPunktow = 2000;
				InputBox.Text = "2000";
			}
			WasClicked = true;
			OutputBox.Text = "";
			DrawingPanel.Refresh();
		}

		private void DrawingPanel_Paint(object sender, PaintEventArgs e)
		{
			int w = DrawingPanel.Width, h = DrawingPanel.Height;
			e.Graphics.TranslateTransform(w / 2, h / 2);

			Rectangle rect = new Rectangle(-w / 2, -h / 2, w - 1, h - 5);
			e.Graphics.DrawRectangle(myPen, rect);
			e.Graphics.DrawEllipse(myPen, rect);

			if (WasClicked)//do tego momentu chyba dobrze
			{
				double paj;
				wkole = 0; punkty = 0;
				int X, Y;
				Random random = new Random();

				for (int i = 0; i < IloscPunktow; i++)
				{
					X = random.Next(-(w / 2), (w / 2) + 1);
					Y = random.Next(-(h / 2), (h / 2) + 1);
					punkty++;

					if ((X * X) + (Y * Y) < (w / 2 * h / 2))
					{
						wkole++;
						e.Graphics.FillRectangle(Brushes.LimeGreen, X, Y, 1, 1);
					}
					else
					{
						e.Graphics.FillRectangle(Brushes.Cyan, X, Y, 1, 1);
					}
					timeout++;
					if (timeout % 50 == 0)
					{
						Thread.Sleep(1);
					}
					Application.DoEvents();//!
				}
				paj = 4 * ((double)wkole / (double)punkty);
				string wynik = String.Format("{0:F4}", paj);
				OutputBox.Text = wynik;
			}
		}
	}
}