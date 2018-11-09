using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class Graph : Form//generalnie działa
	{
		private PointF[] points;

		public Graph()
		{
			InitializeComponent();
			if (string.IsNullOrEmpty(AlgorytmyZachlanne.Fankszyn))
			{
				var result = MessageBox.Show("Nie ustawiono wzoru funkcji! Czy chcesz go wylosować?", "Błąd",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					RunAlgorithms.LosujFunkcje();
				}
				else
				{
					this.Close();
					return;
				}
			}
			points = new PointF[40];
			Calculate();
			this.Paint += new PaintEventHandler(this.MainPanel_Paint);
		}

		private void Calculate()
		{
			float y = 0;
			for (int x = -20; x < 20; x++)
			{
				try
				{
					y = checked((float)AlgorytmyZachlanne.FunkcjaWielomian(x));
				}
				catch (OverflowException)
				{
					y = float.MaxValue;
				}
				points[x + 20] = new PointF(x, y);
			}
		}

		private void MainPanel_Paint(object sender, PaintEventArgs e)
		{
			//narysuj osie
			e.Graphics.DrawLine(Pens.Black, new Point(0, MainPanel.Height / 2), new Point(MainPanel.Width, MainPanel.Height / 2));
			e.Graphics.DrawLine(Pens.Black, new Point(MainPanel.Width / 2, 0), new Point(MainPanel.Width / 2, MainPanel.Height));

			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			e.Graphics.TranslateTransform(MainPanel.Width / 2, MainPanel.Height / 2);
			e.Graphics.ScaleTransform(4, -1f);

			e.Graphics.DrawLines(Pens.Blue, points);
		}
	}
}