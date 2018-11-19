using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public enum Typy
	{
		Skoczek,
		Hetman
	}

	public partial class Hetman : Form
	{
		public static Typy Typ;//Skoczek lub Hetman
		private int w, h;
		private int[,] liczby;
		public static Image img0, img1, img2;
		private static string LabelText;
		private bool First;//tylko Skoczek

		public Hetman()
		{
			InitializeComponent();
			liczby = new int[8, 8];//"siatka" liczb
			w = Panel1.Width / 8;
			h = Panel1.Height / 8;
			First = true;

			if (Typ == Typy.Hetman)
			{
				LabelText = "/8";
				HetmanProgressBar.Maximum = 8;
				label1.Text = Nazwy.hIlośćH;
			}
			else if (Typ == Typy.Skoczek)
			{
				LabelText = "/64";
				HetmanProgressBar.Maximum = 64;
				label1.Text = Nazwy.hIlośćS;
			}

			label2.Text = HetmanProgressBar.Value.ToString() + LabelText;

			img0 = Image.FromFile(@"Resources\0.png");
			img1 = Image.FromFile(@"Resources\1.png");
			img2 = Image.FromFile(@"Resources\2.png");
		}

		private void Hetman_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (Typ == Typy.Hetman)
					{
						liczby[i, j] = 0;
					}
					else if (Typ == Typy.Skoczek)
					{
						liczby[i, j] = 3;
					}

					int locX = i * w;
					int loxY = j * h;
					var loc = new Point(w * i, h * j);

					var box = new Kratka()
					{
						Location = loc,
						Size = new Size(w, h),
						row = i,
						col = j,
						SizeMode = PictureBoxSizeMode.CenterImage
					};

					if (Typ == Typy.Hetman)
					{
						box.Image = img0;
					}

					if ((i + j) % 2 == 0)
					{
						box.BackColor = Color.White;
					}
					else
					{
						box.BackColor = Color.Gray;
					}

					Panel1.Controls.Add(box);

					box.Click += Box_Click;
				}
			}
		}

		private void Box_Click(object sender, EventArgs e)
		{
			int tempRow, tempCol, i, j;
			tempRow = (sender as Kratka).row;
			tempCol = (sender as Kratka).col;

			if (Typ == Typy.Hetman)
			{
				if (liczby[tempRow, tempCol] == 1 || liczby[tempRow, tempCol] == 2)
				{
					MessageBox.Show(Nazwy.hNieMożnaH, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					HetmanProgressBar.Value++;

					liczby[tempRow, tempCol] = 2;

					for (i = 0; i < 8; i++)
					{
						if (i != tempRow)
							liczby[i, tempCol] = 1;

						if (i != tempCol)
							liczby[tempRow, i] = 1;
					}

					for (i = tempRow + 1, j = tempCol + 1; i < 8 && j < 8; i++, j++)
					{
						liczby[i, j] = 1;
					}
					for (i = tempRow - 1, j = tempCol - 1; i >= 0 && j >= 0; i--, j--)
					{
						liczby[i, j] = 1;
					}
					for (i = tempRow + 1, j = tempCol - 1; i < 8 && j >= 0; i++, j--)
					{
						liczby[i, j] = 1;
					}
					for (i = tempRow - 1, j = tempCol + 1; i >= 0 && j < 8; i--, j++)
					{
						liczby[i, j] = 1;
					}

					UpdateGrid();
					label2.Text = HetmanProgressBar.Value.ToString() + LabelText;

					if (HetmanProgressBar.Value == HetmanProgressBar.Maximum)
					{
						Congratulations();
					}
					else if (CountZeroes() == 0)//
					{
						Failed();
					}
				}
			}
			else if (Typ == Typy.Skoczek)
			{
				if (First && liczby[tempRow, tempCol] == 3)
				{
					First = false;
					Clicked(tempRow, tempCol);
				}
				else if (liczby[tempRow, tempCol] == 1 || liczby[tempRow, tempCol] == 2 || liczby[tempRow, tempCol] == 3)
				{
					MessageBox.Show(Nazwy.hNieMożnaS, Nazwy.eBłąd, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					Clicked(tempRow, tempCol);

					#region MyRegion

					//ResetGrid();
					//HetmanProgressBar.Value++;
					//liczby[tempRow, tempCol] = 2;

					//int tempI, tempJ;

					//tempI = tempRow + 1;
					//tempJ = tempCol + 2;
					//if (tempI < 8 && tempJ < 8)
					//{
					//	if (liczby[tempI, tempJ] != 1)
					//	{
					//		liczby[tempI, tempJ] = 0;
					//	}
					//}

					//tempI = tempRow + 2;
					//tempJ = tempCol + 1;
					//if (tempI < 8 && tempJ < 8)
					//{
					//	if (liczby[tempI, tempJ] != 1)
					//	{
					//		liczby[tempI, tempJ] = 0;
					//	}
					//}

					//tempI = tempRow - 1;
					//tempJ = tempCol + 2;
					//if (tempI >= 0 && tempJ < 8)
					//{
					//	if (liczby[tempI, tempJ] != 1)
					//	{
					//		liczby[tempI, tempJ] = 0;
					//	}
					//}

					//tempI = tempRow - 2;
					//tempJ = tempCol + 1;
					//if (tempI >= 0 && tempJ < 8)
					//{
					//	if (liczby[tempI, tempJ] != 1)
					//	{
					//		liczby[tempI, tempJ] = 0;
					//	}
					//}

					//tempI = tempRow - 1;
					//tempJ = tempCol - 2;
					//if (tempI >= 0 && tempJ >= 0)
					//{
					//	if (liczby[tempI, tempJ] != 1)
					//	{
					//		liczby[tempI, tempJ] = 0;
					//	}
					//}

					//tempI = tempRow - 2;
					//tempJ = tempCol - 1;
					//if (tempI >= 0 && tempJ >= 0)
					//{
					//	if (liczby[tempI, tempJ] != 1)
					//	{
					//		liczby[tempI, tempJ] = 0;
					//	}
					//}

					//tempI = tempRow + 1;
					//tempJ = tempCol - 2;
					//if (tempI < 8 && tempJ >= 0)
					//{
					//	if (liczby[tempI, tempJ] != 1)
					//	{
					//		liczby[tempI, tempJ] = 0;
					//	}
					//}

					//tempI = tempRow + 2;
					//tempJ = tempCol - 1;
					//if (tempI < 8 && tempJ >= 0)
					//{
					//	if (liczby[tempI, tempJ] != 1)
					//	{
					//		liczby[tempI, tempJ] = 0;
					//	}
					//}

					//UpdateGrid();
					//liczby[tempRow, tempCol] = 1;
					//label2.Text = HetmanProgressBar.Value.ToString() + LabelText;

					#endregion MyRegion
				}

				if (HetmanProgressBar.Value == HetmanProgressBar.Maximum)
				{
					Congratulations();
				}
				else if (CountZeroes() == 0)
				{
					Failed();
				}
			}
		}

		private void Clicked(int tempRow, int tempCol)
		{
			ResetGrid();
			HetmanProgressBar.Value++;
			liczby[tempRow, tempCol] = 2;

			int tempI, tempJ;

			tempI = tempRow + 1;
			tempJ = tempCol + 2;
			if (tempI < 8 && tempJ < 8)
			{
				if (liczby[tempI, tempJ] != 1)
				{
					liczby[tempI, tempJ] = 0;
				}
			}

			tempI = tempRow + 2;
			tempJ = tempCol + 1;
			if (tempI < 8 && tempJ < 8)
			{
				if (liczby[tempI, tempJ] != 1)
				{
					liczby[tempI, tempJ] = 0;
				}
			}

			tempI = tempRow - 1;
			tempJ = tempCol + 2;
			if (tempI >= 0 && tempJ < 8)
			{
				if (liczby[tempI, tempJ] != 1)
				{
					liczby[tempI, tempJ] = 0;
				}
			}

			tempI = tempRow - 2;
			tempJ = tempCol + 1;
			if (tempI >= 0 && tempJ < 8)
			{
				if (liczby[tempI, tempJ] != 1)
				{
					liczby[tempI, tempJ] = 0;
				}
			}

			tempI = tempRow - 1;
			tempJ = tempCol - 2;
			if (tempI >= 0 && tempJ >= 0)
			{
				if (liczby[tempI, tempJ] != 1)
				{
					liczby[tempI, tempJ] = 0;
				}
			}

			tempI = tempRow - 2;
			tempJ = tempCol - 1;
			if (tempI >= 0 && tempJ >= 0)
			{
				if (liczby[tempI, tempJ] != 1)
				{
					liczby[tempI, tempJ] = 0;
				}
			}

			tempI = tempRow + 1;
			tempJ = tempCol - 2;
			if (tempI < 8 && tempJ >= 0)
			{
				if (liczby[tempI, tempJ] != 1)
				{
					liczby[tempI, tempJ] = 0;
				}
			}

			tempI = tempRow + 2;
			tempJ = tempCol - 1;
			if (tempI < 8 && tempJ >= 0)
			{
				if (liczby[tempI, tempJ] != 1)
				{
					liczby[tempI, tempJ] = 0;
				}
			}

			UpdateGrid();
			liczby[tempRow, tempCol] = 1;
			label2.Text = HetmanProgressBar.Value.ToString() + LabelText;
		}

		private void Congratulations()
		{
			if (Typ == Typy.Hetman)
			{
				MessageBox.Show(Nazwy.hGratulacjeH);
			}
			else if (Typ == Typy.Skoczek)
			{
				MessageBox.Show(Nazwy.hGratulacjeS);
			}
		}

		private void RestartButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show(Nazwy.hRestart, Nazwy.strRestart,
				MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (dialogResult == DialogResult.Yes)
			{
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						if (Typ == Typy.Hetman)
						{
							liczby[i, j] = 0;
						}
						else if (Typ == Typy.Skoczek)
						{
							liczby[i, j] = 3;
						}
					}
				}
				UpdateGrid();
				HetmanProgressBar.Value = 0;
				First = true;
				label2.Text = HetmanProgressBar.Value.ToString() + LabelText;
			}
		}

		private void Failed()
		{
			if (Typ == Typy.Hetman)
			{
				MessageBox.Show(Nazwy.hFailH);
			}
			else if (Typ == Typy.Skoczek)
			{
				MessageBox.Show(Nazwy.hFailS);
			}
		}

		public void UpdateGrid()
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					foreach (Kratka k in Panel1.Controls)
					{
						if (k.row == i && k.col == j)
						{
							int temp = liczby[i, j];
							if (temp == 0)
							{
								k.Image = img0;
							}
							else if (temp == 1)
							{
								k.Image = img1;
							}
							else if (temp == 2)
							{
								k.Image = img2;
							}
							else if (temp == 3)
							{
								k.Image = null;
							}
						}
					}
				}
			}
		}

		private void ResetGrid()//tylko skoczek
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					int temp = liczby[i, j];
					if (temp == 0 || temp == 2)
					{
						liczby[i, j] = 3;
					}
				}
			}
		}

		private int CountZeroes()//dla Hetmana
		{
			int counter = 0;
			foreach (int num in liczby)
			{
				if (num == 0)
				{
					counter++;
				}
			}

			return counter;
		}
	}

	public partial class Kratka : PictureBox
	{
		public int row, col;

		public Kratka() : base()
		{
		}
	}
}