using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AlgorytmySzkolne.ContentUCs;

namespace AlgorytmySzkolne
{
	public partial class AlgorytmyUC : UserControl
	{
		/*To be implemented™
        //public static string CurrentLanguage { get; set; }
        //public static string LangTarget { get; set; }
        //public static string LanguagePair { get; set; }

        //private static string Translator(string input)//input - tekst, languagePair - języki np. pl|en
        //{
        //    string url = string.Format(@"http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, LanguagePair);

        //    WebClient web = new WebClient
        //    {
        //        Encoding = Encoding.UTF8
        //    };

        //    string result = web.DownloadString(url);

        //    result = result.Substring(result.IndexOf("id=result_box") + 22, result.IndexOf("id=result_box") + 500);
        //    result = result.Substring(0, result.IndexOf("</div"));
        //    return result;
        //}

        //public static void Translate()
        //{
        //    Dictionary<string, string> LangDict = new Dictionary<string, string>
        //    {
        //        { Nazwy.lPolski, "pl" },
        //        { Nazwy.lAngielski, "en" },
        //        { Nazwy.lNiemiecki, "de" },
        //        { Nazwy.lRosyjski, "ru" },
        //        { Nazwy.lFrancuski, "fr" }
        //    };

        //    LanguagePair = LangDict.FirstOrDefault(x => x.Key == CurrentLanguage).Value + '|' + LangDict.FirstOrDefault(x => x.Key == LangTarget).Value;
        //}*/

		public static UserControl currentUC;
		public static Dictionary<string, UserControl> PreviousList = new Dictionary<string, UserControl>();

		public static void AddToList(string nazwa, UserControl c)
		{
			PreviousList.Add(nazwa, c);
		}

		public AlgorytmyUC()
		{
			InitializeComponent();
		}

		public void SetPanel(Control c)//to set panels from other places
		{
			MainPanel.Controls.Clear();
			MainPanel.Controls.Add(c);
		}

		public UserControl GetPanel()
		{
			var c = MainPanel.Controls;
			return (c[0] as UserControl);
		}

		public void SetTitle(string title)
		{
			this.CurrentFormNameLabel.Text = title;
		}

		public string GetTitle()
		{
			return CurrentFormNameLabel.Text;
		}

		public void UpdateTitle()
		{
			UserControl temp = PreviousList.Values.ElementAt(PreviousList.Count - 1);
			string tajtyl = PreviousList.Reverse().FirstOrDefault(x => x.Value == temp).Key;
			SetTitle(tajtyl);
		}

		public void GoBack()
		{
			if (PreviousList.Count > 1)
			{
				PreviousList.Remove(PreviousList.Keys.ElementAt(PreviousList.Count - 1));
				this.SetPanel(PreviousList.Values.ElementAt(PreviousList.Count - 1));
			}
			else if (PreviousList.Count == 1)//spróbujemy zrobić tak że homepage nigdy nie zniknie
			{
				this.SetPanel(PreviousList.Values.ElementAt(0));
			}
			else
			{
				//
			}

			try//debug only
			{
				UpdateTitle();
			}
			catch (Exception)
			{
				MessageBox.Show("DEBUG", "DEBUG", MessageBoxButtons.OK);
			}
		}

		private void AlgorytmyUC_Load(object sender, EventArgs e)
		{
			BackButton.Visible = false;
		}

		private void HomePageButton_Click(object sender, EventArgs e)
		{
			MainPanel.Controls.Clear();
			PreviousList.Clear();
			BackButton.Visible = false;//
			SetTitle(Nazwy.strGlowna);
			var homepage = new Homepage();
			homepage.SetUC(this);
			MainPanel.Controls.Add(homepage);
		}

		private void InfoPageButton_Click(object sender, EventArgs e)
		{
			MainPanel.Controls.Clear();
			SetTitle(Nazwy.strInfo);
			var infopage = new InfoPage();
			AddToList(Nazwy.strInfo, infopage);
			MainPanel.Controls.Add(infopage);
		}

		private void LanguageChangeButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("To be implemented™", "Not yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			GoBack();
		}

		private void MainPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			if (PreviousList.Count > 1)
			{
				BackButton.Visible = true;
			}
		}

		private void MainPanel_ControlRemoved(object sender, ControlEventArgs e)
		{
			if (PreviousList.Count == 1)
			{
				BackButton.Visible = false;
			}
		}
	}
}