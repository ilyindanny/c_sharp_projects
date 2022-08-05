using System;

public class Program
{
    static public void Main ()
    {
		
		
		int[,] s = new int[9, 9];
	
		for (int i = 1; i < 10; i++)
		{
			for (int j = i; j < 10; j++)
			{
				Console.Write((j * i) + " ");
				s[i-1, j-1] = i * j;
				s[j-1, i-1] = i * j;
			}
			Console.WriteLine();
		}
		
		for (int i = 0; i < s.GetLength(0); i++)
		{
			for (int j = 0; j < s.GetLength(1); j++)
			{
				Console.Write("{0,4}", s[i,j]);
			}
			Console.WriteLine();
		}
		
    }
}
