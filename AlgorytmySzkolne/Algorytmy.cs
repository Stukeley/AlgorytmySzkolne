using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using AlgorytmySzkolne.ContentUCs;

namespace AlgorytmySzkolne
{
	public static class RunAlgorithms
	{
		private static Universal universal;

		public static void SetUniversal(Universal universal)
		{
			RunAlgorithms.universal = universal;
		}

		private static ONPUC onpuc;

		public static void SetONPUC(ONPUC onpuc)
		{
			RunAlgorithms.onpuc = onpuc;
		}

		public static void Run(string nazwaAlgorytmu, string argument1, string argument2)
		{
			string wynik1 = "", wynik2 = "";
			bool result1, result2;
			int pom1, pom2;
			double arg1, arg2;

			if (argument1 != "")
			{
				switch (nazwaAlgorytmu)
				{
					#region Klasyczne

					case Nazwy.strEuklides:
						result1 = int.TryParse(argument1, out pom1);
						result2 = int.TryParse(argument2, out pom2);
						if (result1 && result2)
						{
							wynik1 = AlgorytmyKlasyczne.NWD(pom1, pom2).ToString();
							wynik2 = ((pom1 * pom2) / int.Parse(wynik1)).ToString();
						}
						else
							throw new ArgumentException();
						break;

					case Nazwy.strSilnia:
						result1 = int.TryParse(argument1, out pom1);
						if (result1)
						{
							wynik1 = AlgorytmyKlasyczne.Silnia(pom1).ToString();
						}
						else
							throw new ArgumentException();
						break;

					case Nazwy.strPierwsza:
						result1 = int.TryParse(argument1, out pom1);
						if (result1)
						{
							result2 = AlgorytmyKlasyczne.Pierwsza(pom1);
							wynik1 = result2 ? "Tak" : "Nie";
						}
						else
							throw new ArgumentException();
						break;

					case Nazwy.strSumaDzielnikow:
						result1 = int.TryParse(argument1, out pom1);
						if (result1)
						{
							wynik1 = AlgorytmyKlasyczne.SumaDzielnikow(pom1).ToString();
						}
						else
							throw new ArgumentException();
						break;

					case Nazwy.strCzynnikiPierwsze:
						result1 = int.TryParse(argument1, out pom1);
						if (result1)
						{
							wynik1 = AlgorytmyKlasyczne.CzynnikiPierwsze(pom1);
						}
						else
							throw new ArgumentException();
						break;

					case Nazwy.strSumaPrzedzialu:
						result1 = int.TryParse(argument1, out pom1);
						result2 = int.TryParse(argument2, out pom2);
						if (result1 && result2)
						{
							if (pom1 > pom2)
							{
								int x = pom1;
								pom1 = pom2;
								pom2 = x;
							}
							wynik1 = AlgorytmyKlasyczne.SumaZPrzedzialu(pom1, pom2).ToString();
						}
						else
							throw new ArgumentException();
						break;

					case Nazwy.strSumaCyfr:
						result1 = int.TryParse(argument1, out pom1);
						if (result1)
						{
							wynik1 = AlgorytmyKlasyczne.SumaCyfr(pom1).ToString();
						}
						break;

					case Nazwy.strRNG:
						result1 = int.TryParse(argument1, out pom1);
						result2 = int.TryParse(argument2, out pom2);
						if (result1 && result2)
						{
							if (pom1 > pom2)
							{
								int x = pom1;
								pom1 = pom2;
								pom2 = x;
							}
							wynik1 = AlgorytmyKlasyczne.RNG(pom1, pom2).ToString();
						}
						else
							throw new ArgumentException();
						break;

					#endregion Klasyczne

					#region Zachłanne

					case Nazwy.strZerowe:
						result1 = double.TryParse(argument1, out arg1);
						result2 = double.TryParse(argument2, out arg2);
						if (result1 && result2)
						{
							wynik1 = AlgorytmyZachlanne.MiejsceZerowe(arg1, arg2).ToString();
							if (!AlgorytmyZachlanne.Znaleziono)
								wynik1 = Nazwy.strNieZnaleziono;
						}
						else
							throw new ArgumentException();

						break;

					case Nazwy.strPierwiastek:
						result1 = double.TryParse(argument1, out arg1);
						if (result1)
						{
							wynik1 = AlgorytmyZachlanne.Pierwiastek(arg1).ToString();
						}
						else
							throw new ArgumentException();

						break;

					case Nazwy.strCalka:
						result1 = double.TryParse(argument1, out arg1);
						result2 = double.TryParse(argument2, out arg2);
						if (result1 && result2)
						{
							wynik1 = AlgorytmyZachlanne.Całka(arg1, arg2).ToString();
						}
						else
							throw new ArgumentException();

						break;

						#endregion Zachłanne
				}
			}
			if (wynik2 != "")
				universal.SetResult(wynik1, wynik2);
			else
				universal.SetResult(wynik1);
		}

		public static void Run(string nazwaAlgorytmu, string argument)//dla jednoargumentowych np. ONP
		{
			string wynik = "";
			try
			{
				switch (nazwaAlgorytmu)
				{
					#region ONP

					case Nazwy.oWartosc:
						wynik = ONP.WartoscWyrazeniaONP(argument);
						break;

					case Nazwy.oZONP:
						wynik = ONP.zONP(argument);
						break;

					case Nazwy.oNaONP:
						wynik = ONP.NaONP(argument);
						break;

						#endregion ONP
				}
			}
			catch (ArgumentException)
			{
				Glowna.ShowMessageBox("Argument");
			}
			catch (Exception)
			{
				Glowna.ShowMessageBox("Inny");
			}

			onpuc.SetResult(wynik);
		}

		public static void Run(ContentUCs.SystemyLiczbowe UC, string zKtorego, string naKtory, string liczba)//do systemow liczbowych
		{
			bool result1, result2;
			string wynik = "";
			result1 = uint.TryParse(zKtorego, out uint r);
			result2 = uint.TryParse(naKtory, out uint Target);

			if (result1 && result2)
			{
				if (r > 36 || Target > 36)
					throw new ArgumentOutOfRangeException();
				wynik = SystemyLiczbowe.Zamien(liczba, r, Target);
			}
			else
				throw new ArgumentException();

			UC.SetResult(wynik);
		}

		public static void LosujFunkcje()
		{
			Random random = new Random();
			int stopien = random.Next(1, 6);
			string fankszyn = "";

			for (int i = stopien; i >= 0; i--)
			{
				int o = random.Next(-10, 10);
				fankszyn += o.ToString() + ' ';
			}

			AlgorytmyZachlanne.Fankszyn = fankszyn;
			AlgorytmyZachlanne.Stopien = (ushort)stopien;

			AlgorytmyZachlanne.TypFankszynu = Nazwy.fWielomian;
		}

		public static void LosujFunkcje(ushort stopien)
		{
			var random = new Random();
			string fankszyn = "";

			for (int i = stopien; i >= 0; i--)
			{
				int o = random.Next(-10, 10);
				fankszyn = fankszyn + o.ToString() + ' ';
			}

			AlgorytmyZachlanne.Fankszyn = fankszyn;
			AlgorytmyZachlanne.Stopien = stopien;
			AlgorytmyZachlanne.TypFankszynu = Nazwy.fWielomian;
		}
	}

	internal static class AlgorytmyKlasyczne
	{
		public static int NWD(int a, int b)//Euklides
		{
			while (a != 0 && b != 0)
			{
				if (a > b) a = a % b;
				else b = b % a;
			}
			return a + b;
		}

		public static int NWW(int a, int b)
		{
			return ((a * b) / NWD(a, b));
		}

		public static BigInteger Silnia(int n)//na Bigintegerach
		{
			BigInteger wynik = new BigInteger();
			wynik = 1;

			while (n > 1)
			{
				wynik *= n;
				n--;
			}

			return wynik;
		}

		public static bool Pierwsza(int n)
		{
			if (n < 3) return true;
			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0) return false;
			}
			return true;
		}

		public static int SumaDzielnikow(int liczba)
		{
			int s = 1, k = 2;
			while (k <= liczba / 2)
			{
				if (liczba % k == 0)
					s += k;
				k++;
			}
			return s;
		}

		public static string CzynnikiPierwsze(int n)
		{
			int k = 2;
			StringBuilder w = new StringBuilder();
			while (n != 1)
			{
				if (n % k == 0)
				{
					w.Append(k).Append(" ");
					n /= k;
				}
				else
					k++;
			}
			return w.ToString();
		}

		public static int SumaZPrzedzialu(int a, int b)//suma liczb całkowitych z przedziału <a,b>
		{
			int suma = 0;
			if (a > b)
			{
				int pom = a;
				a = b;
				b = pom;
			}

			for (int i = a; i <= b; i++)
				suma += i;
			return suma;
		}

		public static int SumaCyfr(int n)
		{
			int suma = 0;
			while (n != 0)
			{
				int o = n % 10;
				n /= 10;
				suma += o;
			}
			return suma;
		}

		public static int RNG(int minValue, int maxValue)
		{
			Random r = new Random();
			return r.Next(minValue, maxValue + 1);
		}
	}

	internal static class AlgorytmyZachlanne//miejsce zerowe funkcji, pierwiastek kwadratowy, całka
	{
		public static double Eps { get; set; }
		public static string Fankszyn { get; set; }
		public static string TypFankszynu { get; set; }
		public static string TypArgumentu { get; set; }
		public static ushort Stopien { get; set; }
		public static bool Znaleziono = true;
		public static uint IloscOdcinkow { get; set; }
		public static double IloscPI { get; set; }

		public static ushort stMian { get; set; }
		public static ushort stLicz { get; set; }
		public static ushort stF { get; set; }
		public static ushort stPierw { get; set; }

		public static double FunkcjaWielomian(double x)
		{
			bool czy;
			double wynik = 0;
			string pom1, pom2;
			int indexpom1, a, n;

			pom1 = Fankszyn;
			n = Stopien;

			while ((indexpom1 = pom1.IndexOf(' ')) > 0)
			{
				pom2 = pom1.Substring(0, indexpom1);
				czy = int.TryParse(pom2, out a);
				if (czy)
				{
					wynik += Math.Pow(x, n) * a;
					n--;
					pom1 = pom1.Remove(0, indexpom1 + 1);
				}
				else
				{
					throw new ArgumentException();
				}
			}

			czy = int.TryParse(pom1, out a);
			if (czy)
				wynik += a;

			return wynik;
		}

		private static double Funkcja(double x)
		{
			double wynik = 0;
			int indexpom;

			switch (TypFankszynu)
			{
				case Nazwy.fWielomian://póki co bez ułamków

					wynik = FunkcjaWielomian(x);

					break;

				case Nazwy.fWymierna:

					string przechwyc = Fankszyn;

					indexpom = Fankszyn.IndexOf("M");
					string pom = Fankszyn.Substring(0, indexpom - 1);
					pom = pom.Remove(0, 2);
					pom = pom.Remove(pom.Length - 2, 2);

					Fankszyn = pom;
					Stopien = stLicz;
					double wLicznika = FunkcjaWielomian(x);

					pom = przechwyc.Substring(indexpom, przechwyc.Length - indexpom);
					pom = pom.Remove(0, 2);
					pom = pom.Remove(pom.Length - 1, 1);

					Fankszyn = pom;
					Stopien = stMian;
					double wMianownika = FunkcjaWielomian(x);

					if (wMianownika == 0)
					{
						throw new ArgumentException();
					}
					wynik = wLicznika / wMianownika;

					Fankszyn = przechwyc;

					break;

				case Nazwy.fPieriwastek:

					Stopien = stF;
					wynik = FunkcjaWielomian(x);
					wynik = Math.Pow(wynik, (1.0 / stPierw));

					break;

				case Nazwy.fSin:
					if (TypArgumentu == Nazwy.aX)
					{
						wynik = Math.Sin(FunkcjaWielomian(x));
					}
					else
					{
						wynik = Math.Sin(x + IloscPI);
					}
					break;

				case Nazwy.fCos:
					if (TypArgumentu == Nazwy.aX)
					{
						wynik = Math.Cos(FunkcjaWielomian(x));
					}
					else
					{
						wynik = Math.Cos(x + IloscPI);
					}
					break;

				case Nazwy.fTg:
					if (TypArgumentu == Nazwy.aX)
					{
						wynik = Math.Tan(FunkcjaWielomian(x));
					}
					else
					{
						wynik = Math.Tan(x + IloscPI);
					}
					break;

				case Nazwy.fCtg:
					if (TypArgumentu == Nazwy.aX)
					{
						wynik = 1 / (Math.Tan(FunkcjaWielomian(x)));
					}
					else
					{
						wynik = 1 / (Math.Tan(x + IloscPI));
					}
					break;
			}

			return wynik;
		}

		public static double MiejsceZerowe(double a, double b)//działa
		{
			double Fa, Fb, Fx;
			Fa = Funkcja(a);
			Fb = Funkcja(b);
			Znaleziono = true;

			if (Math.Abs(Fa) < Eps) return a;
			if (Math.Abs(Fb) < Eps) return b;

			if ((Fa * Fb) > 0)//algorytm zadziała tylko kiedy wartości funkcji w a i b mają różne znaki
			{
				Znaleziono = false;
				return 0;
			}

			while (Math.Abs(a - b) > Eps)
			{
				Fa = Funkcja(a);
				Fb = Funkcja(b);
				double x = (a + b) / 2;
				Fx = Funkcja(x);

				if (Math.Abs(Fx) < Eps) return x;
				if (Fa * Fx < 0)
				{
					b = x;
				}
				else
				{
					a = x;
				}
			}
			return (a + b) / 2;
		}

		public static double Pierwiastek(double n)
		{
			double a = 1;
			double b = n;

			while (Math.Abs(a - b) > Eps)
			{
				a = (a + b) / 2.0;
				b = n / a;
			}

			return a;
		}

		public static double Całka(double a, double b)
		{
			double Pole = 0;

			if (a > b)
			{
				double pom = a;
				a = b;
				b = pom;
			}

			double bok = Math.Abs((b - a) / IloscOdcinkow);

			for (int i = 0; i < IloscOdcinkow; i++)
			{
				double PoleCzęściowe = Funkcja(a + (i * bok)) * bok;
				Pole += PoleCzęściowe;
			}

			return Pole;
		}
	}

	internal static class SystemyLiczbowe//z dowolnego na dowolny ? działa ?
	{
		private static readonly char[] Znaki =
			{
				'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
			};

		private static BigInteger Na10(string n, uint r)//n - liczba zapisana w systemie o podstawie r
		{
			var result = new BigInteger();

			if (n[0] >= 65)
				result = n[0] - 55;
			else result = n[0] - 48;

			for (int i = 1; i < n.Length; i++)
			{
				if (n[i] >= 65)
					result = result * r + n[i] - 55;
				else
					result = result * r + n[i] - 48;
			}//w tym momencie mamy system 10

			return result;
		}

		private static string NaTarget(BigInteger n, uint Target)//Target - podstawa systemu na który zamieniamy, n - BigInteger w systemie 10
		{
			var wynik = new StringBuilder();
			BigInteger o;

			while (n != 0)
			{
				o = n % Target;
				if (o > 35)
					throw new ArgumentException();
				else
				{
					wynik.Insert(0, Znaki[(int)o]);
				}
				n /= Target;
			}

			return wynik.ToString();
		}

		public static string Zamien(string n, uint r, uint Target)
		{
			BigInteger Liczba10 = Na10(n, r);
			if (Target == 10) return Liczba10.ToString();

			string NaWybrany = "";
			try
			{
				NaWybrany = NaTarget(Liczba10, Target);
			}
			catch (ArgumentException)
			{
				Glowna.ShowMessageBox("ZaDuzySystem");
			}
			return NaWybrany;
		}
	}

	internal static class ONP
	{
		private static string UsunSpacje(string w)//do zamiany
		{
			int x;
			while ((x = w.IndexOf(' ')) > 0)
			{
				w = w.Remove(x, 1);
			}
			return w;
		}

		public static string WartoscWyrazeniaONP(string r)//chyba działa
		{
			int i, j;
			float a, b, pom;
			float wynik = 0;
			string sub = "";
			var kontejner = new List<float>();

			for (i = 0; i < r.Length; i++)
			{
				if (r[i] >= 48 && r[i] <= 57)//znajdziemy cyfrę i bierzemy liczbę do spacji
				{
					sub = "" + r[i];
					for (j = i + 1; ; j++)
					{
						if (r[j] >= 48 && r[j] <= 57)
						{
							sub = sub + r[j];
						}
						else break;
					}

					bool czy = float.TryParse(sub, out pom);
					if (czy)
					{
						kontejner.Add(pom);
						i = j;
					}
					else
						throw new ArgumentException();
				}
				else if (r[i] == '+' || r[i] == '-' || r[i] == '*' || r[i] == '/')
				{
					if (kontejner.Count < 2)
					{
						throw new FormatException();
					}

					char znak = r[i];
					a = kontejner[kontejner.Count - 2];
					b = kontejner[kontejner.Count - 1];

					switch (znak)
					{
						case '+':
							wynik = a + b;
							break;

						case '-':
							wynik = a - b;
							break;

						case '*':
							wynik = a * b;
							break;

						case '/':
							if (b == 0)
							{
								throw new ArgumentException();
							}
							else wynik = a / b;
							break;
					}

					kontejner.RemoveRange(kontejner.Count - 2, 2);
					kontejner.Add(wynik);
				}
				else if (r[i] == ' ')
				{
					continue;
				}
				else
				{
					throw new FormatException();
				}
			}

			if (!kontejner.Any())
			{
				throw new FormatException();
			}
			return kontejner[0].ToString();
		}

		public static string NaONP(string w)//chyba działa
		{
			w = UsunSpacje(w);
			string wynik = "";
			char pom, pom2;
			int i, j;
			List<char> znaki = new List<char>();

			for (i = 0; i < w.Length; i++)
			{
				if (w[i] >= 48 && w[i] <= 57)
				{
					//wynik = wynik + w[i] + ' ';//
					for (j = i; j < w.Length; j++)
					{
						if (w[j] >= 48 && w[j] <= 57)
						{
							wynik = wynik + w[j];
						}
						else break;
					}
					wynik = wynik + ' ';
					i = j - 1;
				}
				else
				{
					pom = w[i];

					switch (pom)
					{
						case '+':
							while (znaki.Count > 0 && znaki[znaki.Count - 1] != '(')
							{
								pom2 = znaki[znaki.Count - 1];
								znaki.RemoveAt(znaki.Count - 1);
								wynik = wynik + pom2 + ' ';
							}
							znaki.Add(pom);
							break;

						case '-':
							while (znaki.Count > 0 && znaki[znaki.Count - 1] != '(')
							{
								pom2 = znaki[znaki.Count - 1];
								znaki.RemoveAt(znaki.Count - 1);
								wynik = wynik + pom2 + ' ';
							}
							znaki.Add(pom);
							break;

						case '*':
							if ((!znaki.Any()) || (znaki[znaki.Count - 1] == '+' || znaki[znaki.Count - 1] == '-'))
							{
								znaki.Add(pom);
							}
							else
							{
								while (znaki.Any() && znaki[znaki.Count - 1] != '(')
								{
									pom2 = znaki[znaki.Count - 1];
									znaki.RemoveAt(znaki.Count - 1);
									wynik = wynik + pom2 + ' ';
								}
								znaki.Add(pom);
							}
							break;

						case '/':
							if ((!znaki.Any()) || (znaki[znaki.Count - 1] == '+' || znaki[znaki.Count - 1] == '-'))
							{
								znaki.Add(pom);
							}
							else
							{
								while (znaki.Any() && znaki[znaki.Count - 1] != '(' && znaki[znaki.Count - 1] != '+' && znaki[znaki.Count - 1] != '-')
								{
									pom2 = znaki[znaki.Count - 1];
									znaki.RemoveAt(znaki.Count - 1);
									wynik = wynik + pom2 + ' ';
								}
								znaki.Add(pom);
							}
							break;

						case '(':
							znaki.Add(pom);
							break;

						case ')':
							while (znaki.Any() && znaki[znaki.Count - 1] != '(')
							{
								pom2 = znaki[znaki.Count - 1];
								wynik = wynik + pom2 + ' ';
								znaki.RemoveAt(znaki.Count - 1);
							}
							znaki.RemoveAt(znaki.Count - 1);
							break;

						default: continue;
					}
				}
			}
			while (znaki.Any())
			{
				if (znaki[znaki.Count - 1] == '(' || znaki[znaki.Count - 1] == ')')
				{
					throw new FormatException();
				}
				else
				{
					wynik = wynik + znaki[znaki.Count - 1] + ' ';
				}
				znaki.RemoveAt(znaki.Count - 1);
			}

			return wynik;
		}

		public static string zONP(string w)//chuj wie czy to działa; nie wstawia nawiasów żadnych
		{
			var wiktor = new List<string>();
			var znaki = new List<char>();
			string pom = "";
			int ktoryznak = 0, getindex = 0;
			int i, j;

			for (i = 0; i < w.Length; i++)
			{
				char c = w[i];
				if (c == '+' || c == '-' || c == '*' || c == '/')
				{
					znaki.Add(c);
				}
			}

			for (i = 0; i < w.Length; i++)
			{
				if (w[i] >= 48 && w[i] <= 57)
				{
					pom = "";
					for (j = i; j < w.Length; j++)
					{
						if (w[j] >= 48 && w[j] <= 57)
						{
							pom = pom + w[j];
						}
						else break;
					}
					i = j - 1;
					wiktor.Add(pom);
				}
				else if (w[i] == '+' || w[i] == '-' || w[i] == '*' || w[i] == '/')
				{
					ktoryznak++;
					if (wiktor.Count < 2)
					{
						throw new ArgumentException();
					}

					if (wiktor.Count > 1 && ktoryznak > 0)
					{
						if ((w[i - 2] >= 48 && w[i - 2] <= 57 && w[i - 1] >= 48 && w[i - 1] <= 57) && (w[i] == '*' || w[i] == '/'))
							;
						else if ((ktoryznak > 1) && (w[i] == '*' || w[i] == '/') && (znaki[ktoryznak - 1] == '+' || znaki[ktoryznak - 1] == '-') && (znaki[ktoryznak - 2] == '+' || znaki[ktoryznak - 2] == '-'))
						//else if ((ktoryznak > 1) && ((w[i] == '*' && ((znaki[ktoryznak - 1] == '+' || znaki[ktoryznak - 1] == '-' || znaki[ktoryznak - 1] == '/') && (znaki[ktoryznak - 2] == '+' || znaki[ktoryznak - 2] == '-' || znaki[ktoryznak - 2] == '/'))) || (w[i] == '/' && ((znaki[ktoryznak - 1] == '+' || znaki[ktoryznak - 1] == '-' || znaki[ktoryznak - 1] == '*') && (znaki[ktoryznak - 2] == '+' || znaki[ktoryznak - 2] == '-' || znaki[ktoryznak - 2] == '*')))))
						{
							wiktor[getindex] = '(' + wiktor[getindex] + ')';
							wiktor[getindex - 1] = '(' + wiktor[getindex - 1] + ')';
						}
						else if ((ktoryznak > 0) && (w[i] == '-') && (w[i - 1] == '+' || w[i - 1] == '-'))
							wiktor[getindex] = '(' + wiktor[getindex] + ')';
						else if ((ktoryznak > 0) && ((w[i] == '*' && znaki[ktoryznak - 1] == '/') || (w[i] == '/' && znaki[ktoryznak - 1] == '*')))
							wiktor[getindex] = '(' + wiktor[getindex] + ')';
						else if ((w[i] == '*' || w[i] == '/') && (znaki[ktoryznak - 1] == '+' || znaki[ktoryznak - 1] == '-'))//|| znaki[ktoryznak - 1] == '*' || znaki[ktoryznak - 1] == '/')
							wiktor[getindex] = '(' + wiktor[getindex] + ')';
						else if ((ktoryznak < znaki.Count - 1) && (w[i] == '*' || w[i] == '/') && (znaki[ktoryznak + 1] == '+' || znaki[ktoryznak + 1] == '-'))//przed niższym wyższy
							;
					}
					pom = wiktor[wiktor.Count - 2] + (char)w[i] + wiktor[wiktor.Count - 1];
					wiktor.RemoveAt(wiktor.Count - 1);
					wiktor.RemoveAt(wiktor.Count - 1);
					wiktor.Add(pom);
					getindex = wiktor.Count - 1;
				}
				else if (w[i] == ' ')
				{
					continue;
				}
				else
				{
					throw new ArgumentException();
				}
			}
			if (wiktor.Count == 0)
			{
				throw new ArgumentException();
			}
			else
			{
				return wiktor[0];
			}
		}
	}
}