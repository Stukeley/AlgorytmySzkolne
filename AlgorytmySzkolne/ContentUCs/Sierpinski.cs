﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class Sierpinski : Form
	{
		private bool WasClicked;
		private Pen myPen = new Pen(Color.Black);//tylko na największy + outline mniejszych
		private Brush[] brushes;//wszystkie dostępne kolory
		private int x, y, n, iterator;//iterator - tablica

		public Sierpinski()
		{
			InitializeComponent();
			myPen.Width = 2F;

			brushes = new Brush[7]//typ kolorów: Tablica predefiniowana
            {
				Brushes.Red,
				Brushes.Blue,
				Brushes.DarkGreen,
				Brushes.Cyan,
				Brushes.Violet,
				Brushes.LimeGreen,
				Brushes.OrangeRed
			};
		}

		private void Sierpinski_Resize(object sender, EventArgs e)
		{
			var width = this.Width;
			var height = this.Height - panel1.Height;
			DrawingPanel.Size = new Size(width, height);
			DrawingPanel.Refresh();
		}

		private void DrawingPanel_Paint(object sender, PaintEventArgs e)
		{
			if (WasClicked)
			{
				WasClicked = false;
				x = DrawingPanel.Width;
				y = DrawingPanel.Height;
				iterator = 0;

				PointF[] punkty = new PointF[3]//największy trójkąt
                {
					new PointF(x/2, 0),
					new PointF(0, y),
					new PointF(x, y)
				};
				e.Graphics.DrawPolygon(myPen, punkty);

				Rysuj(x / 2, 0, 0, y, x, y, n, e);
			}
		}

		private void Rysuj(float x1, float y1, float x2, float y2, float x3, float y3, int n, PaintEventArgs e)
		{
			if (n > 0)
			{
				PointF[] punkty = new PointF[3]
				{
					new PointF(x1,y1),
					new PointF(x2,y2),
					new PointF(x3,y3)
				};

				e.Graphics.DrawPolygon(myPen, punkty);//outline
				e.Graphics.FillPolygon(brushes[iterator], punkty);//fill
				iterator++;
				if (iterator > 4)
				{
					iterator = 0;
				}

				float h1 = (x1 + x2) / 2f;
				float w1 = (y1 + y2) / 2f;
				float h2 = (x2 + x3) / 2f;
				float w2 = (y2 + y3) / 2f;
				float h3 = (x3 + x1) / 2f;
				float w3 = (y3 + y1) / 2f;

				Rysuj(x1, y1, h1, w1, h3, w3, n - 1, e);
				Rysuj(h1, w1, x2, y2, h2, w2, n - 1, e);
				Rysuj(h3, w3, h2, w2, x3, y3, n - 1, e);

				Application.DoEvents();//!
			}
		}

		private void RunButton_Click(object sender, EventArgs e)
		{
			bool czy = int.TryParse(LevelsBox.Text, out n);
			if (czy)
			{
				if (n <= 0)
				{
					MessageBox.Show(Nazwy.emsgSierpinskiPoziomy, Nazwy.eBłąd,
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					n = 8;
					LevelsBox.Text = "8";
				}
			}
			else
			{
				MessageBox.Show(Nazwy.emsgSierpinskiPoziomy, Nazwy.eBłąd,
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				n = 8;
				LevelsBox.Text = "8";
			}

			WasClicked = true;
			DrawingPanel.Refresh();
		}
	}
}