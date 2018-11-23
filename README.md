# AlgorytmySzkolne
[Polish] Dodatkowy projekt na informatykę - kompilacja wszystkich programów napisanych na lekcjach informatyki w drugiej klasie (rok 2017/2018)

Oryginalnie napisany między czerwcem a sierpniem 2018, program nie jest jeszcze skończony - oto lista brakujących funkcji:
1. Angielska wersja językowa + autotranslate na wszystkie języki obsługiwane przez tłumacza Google
2. Pomoc przy podawaniu danych we wszystkich algorytmach, a zwłaszcza w ONP oraz algorytmach "zachłannych" (które wymagają podania funkcji)
3. Udoskonalony ekran podawania wzoru funkcji
4. Przebudowa algorytmu rysującego Trójkąt Sierpińskiego w taki sposób, by był on asynchroniczny.
5. Ulepszenie wyglądu aplikacji, który póki co, pod względem designu, jest poniżej przeciętnego.

# Znane błędy:
1. Niepoprawny focus kontrolki przy przechodzeniu pomiędzy algorytmami, lub podczas naciśnięcia przycisku TAB.
2. Czasami podczas wchodzenia w pole tekstowe nie można przez krótką chwilę pisać, takie jakby opóźnienie.
3. Niepoprawny wynik, czasami wręcz crash, dla wyjątkowo wielkich wzorów funkcji przy algorytmie Miejsce Zerowe.
4. Skoczek może poruszać się na dowolne, nieoznaczone pole, zamiast tylko tych oznaczonych cyfrą 0 => naprawione do wersji 0.7.2.
5. Niepoprawne skalowanie aplikacji podczas zmiany rozmiaru => zostanie naprawione do wersji 1.0, póki co wyłączona jest możliwość zmiany rozmiaru okna.

# CHANGELOG WERSJA 0.9.0
1. Dodano autotranslate! Obecnie obsługuje około 20 języków (w tym w pełni wspierany angielski), jednak wciąż zawiera kilka błędów, m.in. związanych z niepoprawnym wyświetlaniem niektórych znaków diakrytycznych.
2. Lekka modyfikacja: Sierpiński, Aproksymacja, Skoczek, Hetmani.
3. Nowy projekt - szkic wykresu funkcji (być może zostanie w przyszłości nieco rozbudowany)
4. Udoskonalono pomoc przy podawaniu danych do algorytmów.
5. Naprawa kilku błędów (i jednoczesne stworzenie takiej samej ilości nowych).

# UŻYWANIE AUTOTRANSLATE:
Wystarczy kliknąć ikonę Translatora w prawym górnym rogu aplikacji, a następnie wybrać z listy rozwijalnej język. Naciśnięcie przycisku Translate stworzy nowy plik z przetłumaczonymi zasobami - trwa około 30-40 sekund i wymaga stałego połączenia z Internetem. Jeżeli przetłumaczony plik już istnieje, to nie jest wymagane ponowne jego tłumaczenie, a jedynie załadowanie zasobów z tego pliku. Przycisk Revert zmienia aktywny język na polski.
