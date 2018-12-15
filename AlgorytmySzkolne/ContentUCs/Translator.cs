using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Net;
using System.IO;
using System.Configuration;
using System.Threading.Tasks;
using System.Threading;

namespace AlgorytmySzkolne.ContentUCs
{
	public partial class Translator : Form
	{
		//założenie - angielski jest zrobiony ręcznie, wszystkie pozostałe języki są tworzone na podstawie angielskiego
		//przy pierwszym wyborze języka - tworzy się nowy plik resx
		//przy każdym kolejnym - dane ładują się z tego pliku

		public static string CurrentLanguage { get; set; }//niepotrzebne
		public static string TargetLang { get; set; }//?
		public static string LanguagePair { get; set; }//postaci l1|l2 np. en|fr - angielski zawsze będzie pierwszy
		private static bool IsRunning = false;

		public static Dictionary<string, string> CodeNamePairs = new Dictionary<string, string>();

		private static string StringTranslator(string input)//input - tekst, languagePair - języki np. en|fr
		{
			//działa dla języków bazujących na alfabecie łacińskim, ale BEZ znaków typu ae
			//czyli odpada chiński, koreański, japoński, arabski itd.
			//niektóre znaki diakrytyczne też się nie zgadzają, np. à

			var url = string.Format(@"http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, LanguagePair);
			string result;

			using (var web = new WebClient())
			{
				result = web.DownloadString(url);
			}

			result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
			result = result.Substring(result.IndexOf(">") + 1);
			result = result.Substring(0, result.IndexOf("</span>"));

			//usuwanie pozostałości

			result = result.Replace("&#39;", "'");
			result = result.Replace("&#8217;", "'");

			//prymitywna metoda xd

			if (TargetLang == "French" || TargetLang == "Italian" || TargetLang == "Romanian" || TargetLang == "Esperanto" || TargetLang == "Spanish")
			{
				result = result.Replace("č", "e");
				result = result.Replace("Č", "E");
				result = result.Replace("ŕ", "a");
				result = result.Replace("Ŕ", "A");
			}

			return result.Trim();
		}

		private static Dictionary<string, string> OptimizedStringTranslator(Dictionary<string, string> input)
		{
			var output = new Dictionary<string, string>();

			using (var web = new WebClient())
			{
				foreach (KeyValuePair<string, string> pair in input)
				{
					var url = string.Format(@"http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", pair.Value, LanguagePair);
					var w = web.DownloadString(url);

					//w = w.Substring(w.IndexOf("<span title=\"") + "<span title=\"".Length);
					//w = w.Substring(w.IndexOf(">") + 1);
					//w = w.Substring(0, w.IndexOf("</span>"));
					w = w.Substring(w.IndexOf(@"<span title="" class="">") + @"<span title="" class="">".Length);
					w = w.Substring(w.IndexOf(">") + 1);
					w = w.Substring(0, w.IndexOf(@"</span>"));
					w = w.Replace("&#39;", "'");
					w = w.Replace("&#8217;", "'");
					if (TargetLang == "French" || TargetLang == "Italian" || TargetLang == "Romanian" || TargetLang == "Esperanto" || TargetLang == "Spanish")
					{
						w = w.Replace("č", "e");
						w = w.Replace("Č", "E");
						w = w.Replace("ŕ", "a");
						w = w.Replace("Ŕ", "A");
					}

					output.Add(pair.Key, w.Trim());
				}
			}

			return output;
		}

		private static Dictionary<string, string> TranslateStrings(Dictionary<string, string> DictionaryEN)
		{
			var output = new Dictionary<string, string>();

			foreach (KeyValuePair<string, string> pair in DictionaryEN)
			{
				var key = pair.Key;//klucz-nazwa bez zmian
				var value = StringTranslator(pair.Value);
				output.Add(key, value);
			}

			return output;
		}

		private static void WriteFile(Dictionary<string, string> dictionary, string directory)
		{
			using (var writer = new ResXResourceWriter(directory))
			{
				foreach (KeyValuePair<string, string> pair in dictionary)
				{
					writer.AddResource(pair.Key, pair.Value);
				}
				writer.Generate();
			}
		}

		public static async Task Translate()//działa asynchronicznie
		{
			string CurrentCode = "en";
			string TargetCode = CodeNamePairs.FirstOrDefault(x => x.Value == TargetLang).Key;
			LanguagePair = CurrentCode + "|" + TargetCode;
			var directory = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()) + $"\\Languages\\{TargetCode}.resx";
			var exists = File.Exists(directory);

			if (exists)
			{
				MessageBox.Show("This language file already exists. Changing language. The app will relaunch shortly.");

				var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				var settings = config.AppSettings.Settings;
				settings["language"].Value = TargetCode;
				config.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
				Application.Restart();//
			}
			else
			{
				if (IsRunning)
				{
					MessageBox.Show("There's already a translation going on in the background!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("This language file doesn't exist yet. Translating it might take a moment. Please ensure you have a " +
						"working Internet connection, then press OK. You can keep working in the background, the app will ask to reboot once " +
						"the translation is ready.", "Translate", MessageBoxButtons.OK);

					try//daje poprawnie "en", chociaż nie wyświetla się to w App.config
					{
						var AllStringsEN = new Dictionary<string, string>();
						var directoryEN = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()) + $"\\Languages\\{CurrentCode}.resx";//zawsze en

						using (var reader = new ResXResourceReader(directoryEN))//zczytujemy angielskie
						{
							var id = reader.GetEnumerator();
							while (id.MoveNext())
							{
								AllStringsEN.Add(id.Key.ToString(), id.Value.ToString());
							}
						}

						//async test
						var task = Task.Run(() => OptimizedStringTranslator(AllStringsEN));
						IsRunning = true;

						//tutaj mamy gotowy angielski dictionary
						/*var OutputDictionary = OptimizedStringTranslator(AllStringsEN);*///tutaj otrzymujemy gotowy, przetłumaczony ten tego
						await task;
						//WriteFile(OutputDictionary, directory);
						WriteFile(task.Result, directory);
						var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
						var settings = config.AppSettings.Settings;
						settings["language"].Value = TargetCode;
						config.Save(ConfigurationSaveMode.Modified);
						ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
						Application.Restart();
					}
					catch (ConfigurationErrorsException)
					{
						MessageBox.Show("Error in changing language.");
					}
				}
			}
		}

		public Translator()
		{
			InitializeComponent();
			CodeNamePairs.Clear();
		}

		private void Translator_Load(object sender, EventArgs e)
		{
			var LanguageBoxCollection = new List<string>();

			using (var reader = new StreamReader(@"Resources\langnames.txt"))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string[] split = line.Split(' ');
					string code = split[0];
					string name = split[1];
					CodeNamePairs.Add(code, name);
					LanguageBoxCollection.Add(name);
				}
			}

			string languageCode = ConfigurationManager.AppSettings["language"].ToString();
			CurrentLanguage = CodeNamePairs.First(x => x.Key == languageCode).Value;

			LanguagesBox.DataSource = LanguageBoxCollection;
		}

		private async void RunButton_Click(object sender, EventArgs e)
		{
			TargetLang = LanguagesBox.GetItemText(LanguagesBox.SelectedItem);

			if (!string.IsNullOrEmpty(TargetLang))
			{
				await Translate();//debug for now
			}
			else
			{
				MessageBox.Show("No language selected!");
			}
		}

		private void RevertLanguageButton_Click(object sender, EventArgs e)
		{
			if (IsRunning)
			{
				MessageBox.Show("There's already a translation going on in the background!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				var result = MessageBox.Show("This will revert the current language to Polish. Are you sure?", "Revert language",
					MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (result == DialogResult.Yes)
				{
					var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
					var settings = config.AppSettings.Settings;
					settings["language"].Value = "pl";
					config.Save(ConfigurationSaveMode.Modified);
					ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
					Application.Restart();
				}
			}
		}
	}
}