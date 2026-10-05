// Variables: types are explicit, or inferred with 'var'
string name = "David";
int age = 24;
double height = 5.11;
bool isLearning = true;
var city = "Cedar Park";   // compiler infers string; it's still strictly typed

// String interpolation (like TS template literals, but with $"...")
Console.WriteLine($"{name} is {age} and lives in {city}.");

// Reading input
Console.Write("What's your favorite number? ");
string? input = Console.ReadLine();   // '?' means it could be null
int favorite = int.Parse(input ?? "0");

// Conditionals look just like TS
if (favorite > 100)
{
    Console.WriteLine("Big number energy.");
}
else
{
    Console.WriteLine($"Double it: {favorite * 2}");
}

// Loops
for (int i = 1; i <= favorite; i++)
{
    Console.WriteLine($"Rep {i}");
}

Console.WriteLine("What's the total bill? ");
decimal total;
string? boi = Console.ReadLine();
total = decimal.TryParse(boi, out total);
decimal tip = total * 0.15;
decimal tot = tip + total;

Console.WriteLine($"Total is: {tot}");
