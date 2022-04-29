// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
От Roman Bachinsky всем 09:59 PM
с подсказками
тяжеловато
От Олег Канакаев всем 09:59 PM
int F1 = int.Parse(Console.ReadLine());
int F2 = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

GetFibonacci(F1, F2, N);

void GetFibonacci(int F1, int F2, int N)
{
	if (N >= 1)
		Console.Write(F1 + " ");
	if (N >= 2)
		Console.Write(F2 + " ");
	for (int i = 0; i < N - 2; i++)
	{
		F2 += F1;
		F1 = F2 - F1;
		Console.Write(F2 + " ");
	}
}
