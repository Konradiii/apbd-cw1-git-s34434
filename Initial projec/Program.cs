Console.WriteLine("Hello, World!");

Console.WriteLine("Podaj liczbę: ");
string input = Console.ReadLine();
double liczba = double.Parse(input);

double wynik = StatisticsHelper.kwadrat(liczba);

Console.WriteLine($"Wynik kwadratu podanej liczby : {wynik}");







