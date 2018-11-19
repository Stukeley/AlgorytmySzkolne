using System;
using System.Windows.Forms;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class InfoPage : UserControl
	{
		public InfoPage()
		{
			InitializeComponent();
		}

		private void InfoPage_Load(object sender, EventArgs e)
		{
			InfoLabel.Text = Nazwy.strInfo1;
			InfoLabel2.Text = string.Format(Nazwy.strInfo2_1 + Environment.NewLine + Nazwy.strInfo2_2 + Environment.NewLine + Nazwy.strInfo2_3);
		}
	}
}