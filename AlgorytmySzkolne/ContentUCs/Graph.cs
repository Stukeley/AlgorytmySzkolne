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
	public partial class Graph : Form//nie jest jeszcze skończone - są wyjątki, nie najlepsza skala + nie przetestowany do końca
	{
		private PointF[] points;
		private PointF[] points2;//tylko gdy jest overflow - nieoptymalne af
		private bool IsOverflown = false;

		public Graph()
		{
			InitializeComponent();
			if (string.IsNullOrEmpty(AlgorytmyZachlanne.Fankszyn))
			{
				MessageBox.Show("Nie ustawiono wzoru funkcji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();//
			}
			else
			{
				points = new PointF[200];
				points2 = new PointF[40];
				Calculate();
				this.Paint += MainPanel_Paint;//
			}
		}

		private void Calculate()
		{
			float y = 0;
			for (int x = -100; x < 100; x++)
			{
				try
				{
					y = (float)AlgorytmyZachlanne.FunkcjaWielomian(x);
				}
				catch (OverflowException)
				{
					var result = MessageBox.Show("Podany wzór funkcji wychodzi poza typ danych! Czy chcesz spróbować zawężyć dziedzinę funkcji?",
						"Błąd", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result == DialogResult.Yes)
					{
						IsOverflown = true;
						Calculate2();
						break;
					}
					else
					{
						this.Close();
					}
				}
				points[x + 100] = new PointF(x, -y);
			}
		}

		private void Calculate2()
		{
			float y = 0;

			for (int x = -20; x < 20; x++)
			{
				try
				{
					y = (float)AlgorytmyZachlanne.FunkcjaWielomian(x);
				}
				catch (OverflowException)
				{
					MessageBox.Show("Podany wzór funkcji wychodzi poza typ danych, nawet dla zawężonej dziedziny! Proszę spróbować " +
						"dla innego wzoru.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.Close();
				}
				points2[x + 20] = new PointF(x, -y);
			}
		}

		private void MainPanel_Paint(object sender, PaintEventArgs e)
		{
			//narysuj osie
			e.Graphics.DrawLine(Pens.Black, new Point(0, MainPanel.Height / 2), new Point(MainPanel.Width, MainPanel.Height / 2));
			e.Graphics.DrawLine(Pens.Black, new Point(MainPanel.Width / 2, 0), new Point(MainPanel.Width / 2, MainPanel.Height));

			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			e.Graphics.TranslateTransform(MainPanel.Width / 2f, MainPanel.Height / 2f);
			e.Graphics.ScaleTransform(1, 0.25f);

			if (IsOverflown)
			{
				e.Graphics.DrawLines(Pens.Blue, points2);
			}
			else
			{
				e.Graphics.DrawLines(Pens.Blue, points);
			}
		}
	}
}