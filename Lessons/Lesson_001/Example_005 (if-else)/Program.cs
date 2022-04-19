// if-else
Console.WriteLine("input username ");
string username = Console.ReadLine() ?? "0";
if (username == "Mari")
{

	Console.WriteLine("Hooray, it's Mari!");
}
else
{
	Console.Write("Hello, ");
	Console.Write(username);
	Console.Write("!");
};