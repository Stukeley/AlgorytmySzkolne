using System.Resources;
using System.Reflection;
using System.Configuration;
using System.IO;
using System;
using System.Windows.Forms;

namespace AlgorytmySzkolne
{
	internal static class Nazwy
	{
		//private static string CurrentLaneguage = ConfigurationManager.AppSettings["language"].ToString();//current language code

		//private static ResourceManager Manager = new ResourceManager("AlgorytmySzkolne.Languages." + CurrentLaneguage,
		//	Assembly.GetExecutingAssembly());

		//Algorytmy - strona główna

		public static string strGlowna = "Strona główna";
		public static string strInfo = "Informacje";
		public static string strKlasyczne = "Algorytmy klasyczne";
		public static string strZachlanne = "Algorytmy zachłanne";
		public static string strSystemy = "Systemy liczbowe";
		public static string strONP = "ONP";
		public static string strProjekty = "Projekty";
		public static string strAproksymacja = "Aproksymacja PI";

		//Algorytmy - klasyczne

		public static string strEuklides = "Algorytm Euklidesa";
		public static string strSilnia = "Silnia";
		public static string strPierwsza = "Liczba pierwsza";
		public static string strSumaDzielnikow = "Suma dzielników";
		public static string strCzynnikiPierwsze = "Czynniki pierwsze";
		public static string strSumaPrzedzialu = "Suma z przedziału";
		public static string strSumaCyfr = "Suma cyfr";
		public static string strRNG = "Generator Liczb Losowych";

		//Algorytmy - zachłanne

		public static string strUstaw = "Ustaw funkcję";
		public static string strZerowe = "Miejsce zerowe funkcji";
		public static string strPierwiastek = "Pierwiastek kwadratowy";
		public static string strPierwiastek2 = "Pierwiastek kwadratowy z liczby";
		public static string strCalka = "Całka";
		public static string strCalka2 = "Pole pod wykresem";

		//Algorytmy - ONP

		public static string oWartosc = "Wartość wyrażenia w ONP";
		public static string oNaONP = "Na ONP";
		public static string oZONP = "Z ONP";

		//Typy funkcji

		public static string fWielomian = "Wielomian";
		public static string fWymierna = "Funkcja wymierna";
		public static string fPierwiastek = "Pierwiastek";//literówka
		public static string fSin = "Sinus";
		public static string fCos = "Cosinus";
		public static string fTg = "Tangens";
		public static string fCtg = "Cotangens";
		public static string fLosuj = "Losuj";
		public static string fAlternatywa = "Alternatywna metoda";

		//Typy argumentu

		public static string aX = "x";
		public static string aPI = "PI";

		//Labele dotyczące wyniku algorytmów

		public static string aWynik = "Wynik";
		public static string aLiczba = "Liczba";
		public static string aDzielnik = "Największy wspólny dzielnik";
		public static string aWielokrotność = "Najmniejsza wielokrotność";
		public static string aPierwsza = "Liczba pierwsza?";
		public static string aCzynniki = "Rozkład na czynniki";
		public static string aPrzedział = "Suma liczb całkowitych z tego przedziału";

		//Tytuły

		public static string tAlgorytmySzkolne = "Algorytmy Szkolne";
		public static string tAproksymacja = "Aproksymacja";
		public static string tSierpiński = "Trójkąt Sierpińskiego";
		public static string tWykres = "Szkic wykresu funkcji";
		public static string tHetmani = "Hetmani";
		public static string tSkoczek = "Skoczek";

		//Podaj + zapytania

		public static string strCzyChceszWyjść = "Czy chcesz wyjść z aplikacji?";
		public static string strWyjście = "Wyjście";
		public static string strPodajArgument = "Podaj argument";
		public static string strPodajEpsilon = "Podaj dokładność";
		public static string strPodajIloscOdcinkow = "Podaj ilość odcinków";
		public static string strPodajLiczbę = "Podaj liczbę";
		public static string strPodajLiczbę1 = "Podaj pierwszą liczbę";
		public static string strPodajLiczbę2 = "Podaj drugą liczbę";
		public static string strPrzedział1 = "Podaj początek przedziału";
		public static string strPrzedział2 = "Podaj koniec przedziału";
		public static string strGranica1 = "Podaj dolną granicę";
		public static string strGranica2 = "Podaj górną granicę";

		public static string strRestart = "Restart";

		public static string strInfo1 = "Aplikacja będąca kompilacją większości algorytmów które pisaliśmy na lekcjach informatyki w klasie " +
				"2.liceum w roku szkolnym 2017 / 2018. Obsługuje kilka podstawowych skrótów klawiszowych.";

		public static string strInfo2_1 = "ESC: wyjście z aplikacji";
		public static string strInfo2_2 = "1 - 8: wybór danego algorytmu(tylko na ekranie wyboru algorytmów)";
		public static string strInfo2_3 = "TAB: następna kontrolka";

		//Informacje, pomoc przy wprowadzaniu danych

		public static string iOstrzeżenie = "Ostrzeżenie";
		public static string iNiepewne = "Uwaga! Chuj wie czy to działa. Czy na pewno chcesz spróbować?";
		public static string iTypFunkcji = "Typ funkcji: ";
		public static string iFunkcja = "Funkcja: ";

		public static string iNWD = "Podaj 2 liczby by uzyskać ich NWW i NWD.";

		public static string iSilnia = "Podaj liczbę aby uzyskać jej silnię (silnia może mieć maksymalnie ~600 milionów cyfr, ale " +
						"próba taka może skończyć się bardzo, bardzo źle!)";

		public static string iPierwsza = "Podaj liczbę aby sprawdzić, czy jest ona pierwsza.";

		public static string iSumaDzielników = "Podaj liczbę aby uzyskać sumę jej dzielników naturalnych.";

		public static string iCzynnikiPierwsze = "Podaj liczbę aby uzyskać jej rozkład na czynniki pierwsze (w kolejności niemalejącej)";

		public static string iSumaPrzedziału = "Podaj początek i koniec przedziału aby uzyskać liczbę będącą sumą wszystkich liczb całkowitych " +
						"z tego przedziału (przedział jest obustronnie domknięty)";

		public static string iSumaCyfr = "Podaj liczbę aby uzyskać sumę wszystkich jej cyfr.";

		public static string iRNG = "Podaj 2 liczby by uzyskać losową liczbę całkowitą z tego przedziału (obustronnie domkniętego)";

		public static string iZerowe = "Podaj początek i koniec przedziału by znaleźć miejsce zerowe. Pamiętaj, że jest to " +
						"możliwe tylko gdy wartość funkcji na początku i końcu przedziału mają różne znaki. " +
						"Pamiętaj również o podaniu wzoru funkcji przed uruchomieniem algorytmu. Jeżeli " +
						"nie podano wzoru, istnieje możliwość jego wylosowania.";

		public static string iCałka = "Podaj dokładność(ilość odcinków) oraz początek i koniec przedziału by otrzymać " +
						"pole pod wykresem podanej funkcji. Pamiętaj o podaniu wzoru funkcji przed uruchomieniem " +
						"algorytmu. Jeżeli nie podano wzoru, istnieje możliwość jego wylosowania." +
						"Domyślna wartość: 10000 lub więcej.";

		public static string iPierwiastek = "Podaj dokładność obliczeń oraz liczbę aby otrzymać jej pierwiastek kwadratowy. " +
						"Domyślna wartość: 0,0001 lub mniej. Dozwolone jest zarówno podawanie z kropką, jak i " +
						"z przecinkiem.";

		public static string iONPWartość = "Podaj wyrażenie w ONP aby uzyskać jego wartość.\n" +
					"Przykład: 2 3 + 4 *\n" +
					"Wynik: 20";

		public static string iONPZ = "Podaj wyrażenie w ONP aby uzyskać jego odpowiednik w notacji normalnej.\n" +
					"Przykład: 2 3 + 4 *\n" +
					"Wynik: (2+3)*4";

		public static string iONPNa = "Podaj wyrażenie w notacji normalnej aby uzyskać jego odpowiednik w ONP.\n" +
					"Przykład: (2+3)*4\n" +
					"Wynik: 2 3 + 4 *";

		public static string iFWielomian = "Wybierz stopień wielomianu, a nastepnie podaj wszystkie współczynniki oddzielone spacjami. Podaj współczynniki nawet gdy " +
					"wynoszą one zero.";//>

		public static string iFWymierna = "Wybierz stopień licznika i mianownika, a nastepnie podaj wszystkie współczynniki oddzielone spacjami w nawiasach (rownież oddzielonych spacjami) poprzedzonych " +
					"literami L i M.";

		public static string iFPierwiastek = "Wybierz stopień funkcji pod pierwiastkiem oraz stopień pierwiastka. Następnie podaj stopień pierwiastka poprzedzony " +
					"literą S, po czym podaj oddzielone spacjami wszystkie współczynniki, nawet gdy wynoszą 0.";

		public static string iFLosuj = "Podaj stopień funkcji(musi być to liczba całkowita dodatnia). Następnie program sam wylosuje wszystkie współczynniki " +
					"i funkcja będzie gotowa do użycia.";

		public static string iFTrygonometrycznaX = "Podaj stopień argumentu, a następnie wszystkie współczynniki oddzielone spacjami. Podaj współczynniki nawet gdy " +
					"wynoszą one zero.";

		public static string iFTrygonometrycznaPI = "Funkcja przesunięta o podaną ilość PI. Może zawierać ułamki, ale tylko w postaci dziesiętnej. " +
					"Podaj tylko jedną liczbę.";

		public static string iPodajWspółczynniki = "Podaj kolejne współczynniki nawet jeżeli wynoszą one 0. Mogą być to liczby z przecinkiem.";

		//Zawartość pól tekstowych żeby fajnie wyglądały itp.

		public static string pArgument = "Podaj argument...";
		public static string pOblicz = "Oblicz!";
		public static string pWykonaj = "Wykonaj!";

		//Błędy

		public static string eBłąd = "Błąd";
		public static string eBłądStopnia = "Błąd stopnia";//
		public static string eSukces = "Sukces";
		public static string eWylosowano = "Wylosowano wzór funkcji pomyślnie.";
		public static string eUstawiono = "Ustawiono funkcję pomyślnie.";
		public static string eNieZnaleziono = "Nie znaleziono";

		public static string emsgBłądArgumentu = "Błąd argumentu/ów!";
		public static string emsgNiePodanoFunkcji = "Nie podano wzoru funkcji!";
		public static string emsgBłądFunkcji = "Nie podano funkcji! Czy chcesz wylosować wzór?";
		public static string emsgFormatWejścia = "Nieprawidłowy format wejścia.";
		public static string emsgPodstawaSystemu = "Maksymalna podstawa systemu liczbowego to 36 !";
		public static string emsgException = "Coś poszło nie tak.";
		public static string emsgAproksymacjaPunkty = "Podano niewłaściwą ilość punktów! Zostanie przydzielona wartość domyślna.";
		public static string emsgSierpinskiPoziomy = "Nie podano poprawnej liczby! Zostanie ustawiona wartość domyślna.";
		public static string emsgIlośćOdcinków = "Błąd w ilości odcinków.";
		public static string emsgNieprawidłowyStopień = "Nieprawidłowy stopień funkcji";//
		public static string emsgStopieńLosowejFunkcji = "Nieporawnie podano stopień losowej funkcji. Pamiętaj, że dozwolone są tylko liczby całkowite dodatnie.";//
		public static string emsgNiepoprawnyWspółczynnikFunkcji = "Współczynniki funkcji muszą być liczbami!";//
		public static string emsgTranslacjaNieDziała = "Z powodu zmiany w polityce i architekturze Google Translate, nie ma już możliwości tłumaczenia na dowolny język. Jedynymi dostępnymi językami są polski i angielski. Czy chesz dokonać zmiany?";

		//Hetman

		public static string hIlośćH = "Ilość hetmanów";
		public static string hIlośćS = "Ilość skoczków";
		public static string hFailH = "Nie udało ci się postawić ośmiu hetmanów.";
		public static string hFailS = "Nie udało ci się postawić skoczka na każdym polu.";
		public static string hNieMożnaH = "Nie można tu postawić hetmana!";
		public static string hNieMożnaS = "Nie można tu przesunąć skoczka!";
		public static string hGratulacjeH = "Gratulacje, udało Ci się postawić ośmiu hetmanów!";
		public static string hGratulacjeS = "Gratulacje, udało ci się postawić skoczka na każdym miejscu dokładnie jeden raz!";
		public static string hRestart = "Czy chcesz zacząć od nowa?";

		//Wartości początkowe przycisków i innych kontrolek

		public static string bKlasyczne = "Klasyczne";
		public static string bZachlanne = "Zachłanne";
		public static string bSystemy = "Zamiana systemów liczbowych";
		public static string bONP = "ONP";
		public static string bProjekty = "Projekty";
		public static string bSPOJ = "SPOJ";

		public static string bNWD = "NWD i NWW";
		public static string bSilnia = "Silnia";
		public static string bLiczbaPierwsza = "Liczba pierwsza";
		public static string bSumaDzielników = "Suma dzielników";
		public static string bRozkład = "Rozkład na czynniki";
		public static string bSumaPrzedziału = "Suma z przedziału";
		public static string bSumaCyfr = "Suma cyfr";
		public static string bRNG = "Generator Liczb Losowych";

		public static string bUstawFunkcję = "Ustaw funkcję";
		public static string bPokażFunkcję = "Pokaż wzór funkcji";
		public static string bWybierzFunkcję = "Wybierz funkcję";
		public static string bMiejsceZerowe = "Miejsce zerowe funkcji";
		public static string bPierwiastekKwadratowy = "Pierwiastek kwadratowy";
		public static string bCałka = "Całka";

		public static string bAproksymacja = "Aproksymacja";
		public static string bSierpiński = "Trójkąt Sierpińskiego";
		public static string bHetmani = "Hetmani";
		public static string bSkoczek = "Skoczek";
		public static string bWykres = "Wykres funkcji";

		public static string bSystemZKtórego = "Z którego";
		public static string bSystemNaKtóry = "Na który";
		public static string bSystemPodaj = "Podaj liczbę w tym systemie";

		public static string bKopiuj = "Kopiuj";
		public static string bWybierzAlgorytm = "Wybierz algorytm";
		public static string bWybierzArgument = "Wybierz argument";//
		public static string bWybierzTypArgumentu = "Wybierz typ argumentu";//
		public static string bUstaw = "Ustaw";

		public static string bPrzykład = "Przykład";
		public static string bDokładność = "Dokładność";
		public static string bPokaż = "Pokaż";
		public static string bPoziomy = "Podaj ilość poziomów";
		public static string bPodajStopień = "Podaj stopień";//>
		public static string bPodajStopieńFunkcji = "Podaj stopień funkcji";
		public static string bPodajStopieńPierwiastka = "Podaj stopień pierwiastka";
		public static string bPodajStopieńLicznika = "Podaj stopień licznika";
		public static string bPodajStopieńMianownika = "Podaj stopień mianownika";

		//zrobić dictionary
		//załadować wszystko

		public static void RevertLanguage()//tylko debug - powraca do j. polskiego
		{
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var settings = config.AppSettings.Settings;
			settings["language"].Value = "pl";
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
		}

		public static void LoadStrings()
		{
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var settings = config.AppSettings.Settings;
			var TargetCode = settings["language"].Value;//to powinno dać jaki język aplikacji ma być
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);

			var directory = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()) + $"\\Languages\\{TargetCode}.resx";
			if (!File.Exists(directory))
			{
				MessageBox.Show("Something went wrong and the language file doesn't exist! Resetting to default. Please try changing " +
					"the language again.");

				TargetCode = "pl";//
				settings["language"].Value = TargetCode;
				config.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
			}
			else
			{
				//var manager = new ResourceManager("AlgorytmySzkolne.Languages." + TargetCode, Assembly.GetExecutingAssembly());

				using (var manager = new ResXResourceSet(directory))
				{
					//nie wiem jak z performance

					strGlowna = manager.GetString("strGlowna");
					strInfo = manager.GetString("strInfo");
					strKlasyczne = manager.GetString("strKlasyczne");
					strZachlanne = manager.GetString("strZachlanne");
					strSystemy = manager.GetString("strSystemy");
					strONP = manager.GetString("strONP");
					strProjekty = manager.GetString("strProjekty");
					strAproksymacja = manager.GetString("strAproksymacja");
					strEuklides = manager.GetString("strEuklides");
					strSilnia = manager.GetString("strSilnia");
					strPierwsza = manager.GetString("strPierwsza");
					strSumaDzielnikow = manager.GetString("strSumaDzielnikow");
					strCzynnikiPierwsze = manager.GetString("strCzynnikiPierwsze");
					strSumaPrzedzialu = manager.GetString("strSumaPrzedzialu");
					strSumaCyfr = manager.GetString("strSumaCyfr");
					strRNG = manager.GetString("strRNG");
					strUstaw = manager.GetString("strUstaw");
					strZerowe = manager.GetString("strZerowe");
					strPierwiastek = manager.GetString("strPierwiastek");
					strPierwiastek2 = manager.GetString("strPierwiastek2");
					strCalka = manager.GetString("strCalka");
					strCalka2 = manager.GetString("strCalka2");

					oWartosc = manager.GetString("oWartosc");
					oNaONP = manager.GetString("oNaONP");
					oZONP = manager.GetString("oZONP");

					fWielomian = manager.GetString("fWielomian");
					fWymierna = manager.GetString("fWymierna");
					fPierwiastek = manager.GetString("fPierwiastek");
					fSin = manager.GetString("fSin");
					fCos = manager.GetString("fCos");
					fTg = manager.GetString("fTg");
					fCtg = manager.GetString("fCtg");
					fLosuj = manager.GetString("fLosuj");
					fAlternatywa = manager.GetString("fAlternatywa");

					aX = manager.GetString("aX");
					aPI = manager.GetString("aPI");
					aWynik = manager.GetString("aWynik");
					aLiczba = manager.GetString("aLiczba");
					aDzielnik = manager.GetString("aDzielnik");
					aWielokrotność = manager.GetString("aWielokrotność");
					aPierwsza = manager.GetString("aPierwsza");
					aCzynniki = manager.GetString("aCzynniki");
					aPrzedział = manager.GetString("aPrzedział");

					tAlgorytmySzkolne = manager.GetString("tAlgorytmySzkolne");
					tAproksymacja = manager.GetString("tAproksymacja");
					tSierpiński = manager.GetString("tSierpiński");
					tHetmani = manager.GetString("tHetmani");
					tSkoczek = manager.GetString("tSkoczek");
					tWykres = manager.GetString("tWykres");

					strCzyChceszWyjść = manager.GetString("strCzyChceszWyjść");
					strWyjście = manager.GetString("strWyjście");
					strPodajArgument = manager.GetString("strPodajArgument");
					strPodajEpsilon = manager.GetString("strPodajEpsilon");
					strPodajIloscOdcinkow = manager.GetString("strPodajIloscOdcinkow");
					strPodajLiczbę = manager.GetString("strPodajLiczbę");
					strPodajLiczbę1 = manager.GetString("strPodajLiczbę1");
					strPodajLiczbę2 = manager.GetString("strPodajLiczbę2");
					strPrzedział1 = manager.GetString("strPrzedział1");
					strPrzedział2 = manager.GetString("strPrzedział2");
					strGranica1 = manager.GetString("strGranica1");
					strGranica2 = manager.GetString("strGranica2");
					strRestart = manager.GetString("strRestart");
					strInfo1 = manager.GetString("strInfo1");
					strInfo2_1 = manager.GetString("strInfo2_1");
					strInfo2_2 = manager.GetString("strInfo2_2");
					strInfo2_3 = manager.GetString("strInfo2_3");

					iOstrzeżenie = manager.GetString("iOstrzeżenie");
					iNiepewne = manager.GetString("iNiepewne");
					iTypFunkcji = manager.GetString("iTypFunkcji");
					iFunkcja = manager.GetString("iFunkcja");
					iNWD = manager.GetString("iNWD");
					iSilnia = manager.GetString("iSilnia");
					iPierwsza = manager.GetString("iPierwsza");
					iSumaDzielników = manager.GetString("iSumaDzielników");
					iCzynnikiPierwsze = manager.GetString("iCzynnikiPierwsze");
					iSumaPrzedziału = manager.GetString("iSumaPrzedziału");
					iSumaCyfr = manager.GetString("iSumaCyfr");
					iRNG = manager.GetString("iRNG");
					iZerowe = manager.GetString("iZerowe");
					iCałka = manager.GetString("iCałka");
					iPierwiastek = manager.GetString("iPierwiastek");
					iONPWartość = manager.GetString("iONPWartość");
					iONPZ = manager.GetString("iONPZ");
					iONPNa = manager.GetString("iONPNa");
					iFWielomian = manager.GetString("iFWielomian");
					iFWymierna = manager.GetString("iFWymierna");
					iFPierwiastek = manager.GetString("iFPierwiastek");
					iFLosuj = manager.GetString("iFLosuj");
					iFTrygonometrycznaX = manager.GetString("iFTrygonometrycznaX");
					iFTrygonometrycznaPI = manager.GetString("iFTrygonometrycznaPI");
					iPodajWspółczynniki = manager.GetString("iPodajWspółczynniki");

					pArgument = manager.GetString("pArgument");
					pOblicz = manager.GetString("pOblicz");
					pWykonaj = manager.GetString("pWykonaj");

					eBłąd = manager.GetString("eBłąd");
					eBłądStopnia = manager.GetString("eBłądStopnia");
					eSukces = manager.GetString("eSukces");
					eWylosowano = manager.GetString("eWylosowano");
					eUstawiono = manager.GetString("eUstawiono");
					eNieZnaleziono = manager.GetString("eNieZnaleziono");

					emsgBłądArgumentu = manager.GetString("emsgBłądArgumentu");
					emsgNiePodanoFunkcji = manager.GetString("emsgNiePodanoFunkcji");
					emsgBłądFunkcji = manager.GetString("emsgBłądFunkcji");
					emsgFormatWejścia = manager.GetString("emsgFormatWejścia");
					emsgPodstawaSystemu = manager.GetString("emsgPodstawaSystemu");
					emsgException = manager.GetString("emsgException");
					emsgAproksymacjaPunkty = manager.GetString("emsgAproksymacjaPunkty");
					emsgSierpinskiPoziomy = manager.GetString("emsgSierpinskiPoziomy");
					emsgIlośćOdcinków = manager.GetString("emsgIlośćOdcinków");
					emsgNieprawidłowyStopień = manager.GetString("emsgNieprawidłowyStopień");
					emsgStopieńLosowejFunkcji = manager.GetString("emsgStopieńLosowejFunkcji");
					emsgNiepoprawnyWspółczynnikFunkcji = manager.GetString("emsgNiepoprawnyWspółczynnikFunkcji");
					emsgTranslacjaNieDziała = manager.GetString("emsgTranslacjaNieDziała");

					hIlośćH = manager.GetString("hIlośćH");
					hIlośćS = manager.GetString("hIlośćS");
					hFailH = manager.GetString("hFailH");
					hFailS = manager.GetString("hFailS");
					hNieMożnaH = manager.GetString("hNieMożnaH");
					hNieMożnaS = manager.GetString("hNieMożnaS");
					hGratulacjeH = manager.GetString("hGratulacjeH");
					hGratulacjeS = manager.GetString("hGratulacjeS");
					hRestart = manager.GetString("hRestart");

					bKlasyczne = manager.GetString("bKlasyczne");
					bZachlanne = manager.GetString("bZachlanne");
					bSystemy = manager.GetString("bSystemy");
					bONP = manager.GetString("bONP");
					bProjekty = manager.GetString("bProjekty");
					bSPOJ = manager.GetString("bSPOJ");
					bNWD = manager.GetString("bNWD");
					bSilnia = manager.GetString("bSilnia");
					bLiczbaPierwsza = manager.GetString("bLiczbaPierwsza");
					bSumaDzielników = manager.GetString("bSumaDzielników");
					bRozkład = manager.GetString("bRozkład");
					bSumaPrzedziału = manager.GetString("bSumaPrzedziału");
					bSumaCyfr = manager.GetString("bSumaCyfr");
					bRNG = manager.GetString("bRNG");
					bUstawFunkcję = manager.GetString("bUstawFunkcję");
					bPokażFunkcję = manager.GetString("bPokażFunkcję");
					bPodajStopień = manager.GetString("bPodajStopień");
					bPodajStopieńFunkcji = manager.GetString("bPodajStopieńFunkcji");
					bPodajStopieńPierwiastka = manager.GetString("bPodajStopieńPierwiastka");
					bPodajStopieńLicznika = manager.GetString("bPodajStopieńLicznika");
					bPodajStopieńMianownika = manager.GetString("bPodajStopieńMianownika");
					bWybierzFunkcję = manager.GetString("bWybierzFunkcję");
					bMiejsceZerowe = manager.GetString("bMiejsceZerowe");
					bPierwiastekKwadratowy = manager.GetString("bPierwiastekKwadratowy");
					bCałka = manager.GetString("bCałka");
					bAproksymacja = manager.GetString("bAproksymacja");
					bSierpiński = manager.GetString("bSierpiński");
					bHetmani = manager.GetString("bHetmani");
					bSkoczek = manager.GetString("bSkoczek");
					bWykres = manager.GetString("bWykres");
					bSystemZKtórego = manager.GetString("bSystemZKtórego");
					bSystemNaKtóry = manager.GetString("bSystemNaKtóry");
					bSystemPodaj = manager.GetString("bSystemPodaj");
					bWybierzArgument = manager.GetString("bWybierzArgument");
					bWybierzTypArgumentu = manager.GetString("bWybierzTypArgumentu");
					bKopiuj = manager.GetString("bKopiuj");
					bUstaw = manager.GetString("bUstaw");
					bPrzykład = manager.GetString("bPrzykład");
					bWybierzAlgorytm = manager.GetString("bWybierzAlgorytm");
					bDokładność = manager.GetString("bDokładność");
					bPokaż = manager.GetString("bPokaż");
					bPoziomy = manager.GetString("bPoziomy");
				}
			}
		}
	}
}