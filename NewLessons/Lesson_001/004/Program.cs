//


Console.WriteLine("input name");
string username = Console.ReadLine() ?? "0";

if (username.ToLower() == "Victoria")
{
	Console.WriteLine("Ura");

}
else
{
	Console.Write("Hi, ");
	Console.Write(username);
}