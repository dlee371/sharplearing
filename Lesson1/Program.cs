string name = "David";
int age = 24;
double height = 5.11;
bool isLearning = true;
var city = "Cedar Park";

Console.WriteLine($"{name} is {age} and lives in {city}");

Console.Write("What's your favorite number? ");
string? input = Console.ReadLine();
int favorite = int.parse(input ?? "0");

