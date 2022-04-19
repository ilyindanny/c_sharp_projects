// hello Vika!

Console.WriteLine("type your name: ");

string name = Console.ReadLine() ?? "0";

if (name.ToLower() == "victoria")
{
	Console.WriteLine($"Hello dear Vika!");
}
else
{
	Console.WriteLine($"Hi {name}");
}
