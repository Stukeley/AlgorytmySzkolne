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
	public partial class Projekty : UserControl
	{
		public Projekty()
		{
			InitializeComponent();
		}

		private void HetmanButton_Click(object sender, EventArgs e)
		{
			Hetman.Typ = Typy.Hetman;
			var hetman = new Hetman();
			hetman.Show();
		}

		private void AproksymacjaButton_Click(object sender, EventArgs e)
		{
			var aproksymacja = new Aproksymacja();
			aproksymacja.Show();
		}

		private void SierpinskiButton_Click(object sender, EventArgs e)
		{
			var sierpinski = new Sierpinski();
			sierpinski.Show();
		}

		private void SkoczekButton_Click(object sender, EventArgs e)
		{
			Hetman.Typ = Typy.Skoczek;
			var skoczek = new Hetman();
			skoczek.Show();
		}

		private void GraphButton_Click(object sender, EventArgs e)
		{
			var graph = new Graph();
			graph.Show();
		}
	}
}