﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AlgorytmySzkolne.ContentUCs;
using System.Resources;
using System.Configuration;

namespace AlgorytmySzkolne
{
	public partial class AlgorytmyUC : UserControl
	{
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
			var result = MessageBox.Show(Nazwy.emsgTranslacjaNieDziała, ":(", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (result == DialogResult.Yes)
			{
				//get current language and change it to the other one

				var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				var settings = config.AppSettings.Settings;

				var currentLanguage = settings["language"].Value;

				if (currentLanguage == "en")
				{
					settings["language"].Value = "pl";
				}
				else
				{
					settings["language"].Value = "en";
				}

				config.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
				Application.Restart();
			}
			//var translator = new Translator();
			//translator.Show();
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