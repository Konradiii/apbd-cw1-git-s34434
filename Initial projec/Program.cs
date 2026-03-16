Console.WriteLine("Hello, World!");

Console.WriteLine("Podaj liczbę: ");
string input = Console.ReadLine();
double liczba = double.Parse(input);

double wynik = StatisticsHelper.kwadrat(liczba);

Console.WriteLine($"Wynik kwadratu podanej liczby : {wynik}");


int[] liczby = { 1,2,6,23,53,1232} ;

double srednia = StatisticsHelper.CalculateAverage(liczby);
Console.WriteLine($"Srednia: {srednia}");



