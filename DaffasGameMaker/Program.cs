const double taxPrice = 0.12;
const int devSalaryPerWeek = 160;
const int pricePerMapOfGame = 60;

// String With ${} Known as String Interpolation.

Console.WriteLine("Welcome to Daffa's Game Development Services!");
Console.Write("What Type of Game do u Want? ");
string typeGame = Console.ReadLine();
Console.WriteLine($"You Want a {typeGame} Type of Game!");
Console.Write("What The Name of The Game do You Want? ");
string nameOfGame = Console.ReadLine();
Console.Write("How Many People do You Need For Development? ");
int devPeople = Convert.ToInt32(Console.ReadLine());
Console.Write("How Many Map do You Need? ");
int countOfMap = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("#################################################");
Console.WriteLine($"Detail Request: ");
Console.WriteLine($"Type of Game: {typeGame}");
Console.WriteLine($"Name of Game: {nameOfGame}");
Console.WriteLine($"Total Developer: {devPeople}");
Console.WriteLine($"Total Map of Making: {countOfMap}");
Console.WriteLine("#################################################");
Console.WriteLine("Estimated Cost Per Week: ");
double estimateDeveloperCost = devSalaryPerWeek * devPeople;
double estimatedMapCost = pricePerMapOfGame * countOfMap;
double estimatedTaxCost = (estimateDeveloperCost + estimatedMapCost) * taxPrice;
double totalCost = estimateDeveloperCost + estimatedMapCost + estimatedTaxCost;
Console.WriteLine($"Developer Cost: ${estimateDeveloperCost}");
Console.WriteLine($"Map Cost: ${estimatedMapCost}");
Console.WriteLine($"Tax Cost: ${estimatedTaxCost}");
Console.WriteLine("#################################################");
Console.WriteLine($"TOTAL COST: ${totalCost}");