﻿using System;
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
				var result = MessageBox.Show(Nazwy.emsgBłądFunkcji, Nazwy.eBłąd,
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
			//dla łatwiejszej kontroli nad penami
			var BlackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 2);
			var BluePen = new Pen(Color.FromArgb(255, 0, 0, 255), 1);

			//narysuj osie
			e.Graphics.DrawLine(BlackPen, new Point(0, MainPanel.Height / 2), new Point(MainPanel.Width, MainPanel.Height / 2));
			e.Graphics.DrawLine(BlackPen, new Point(MainPanel.Width / 2, 0), new Point(MainPanel.Width / 2, MainPanel.Height));

			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			e.Graphics.TranslateTransform(MainPanel.Width / 2, MainPanel.Height / 2);
			e.Graphics.ScaleTransform(4, -1f);//

			e.Graphics.DrawLines(BluePen, points);
		}
	}
}