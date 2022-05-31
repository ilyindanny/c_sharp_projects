// The program on C#



using System;

class ReadConsole
{
  static void Main()
  {



// a dog and two friends:



  	double Fs = 5;
	double Sc = 4;
	double Dg = 17;
	double T;
	double S = 1000;
	
	int count = 0;
	int Counter = 2;
	
	
	while (S > 10)
	{
		if (Counter == 2)
		{
			T = S / (Dg + Sc);
			Counter = 1;
		}
		else
		{
			T = S / (Dg + Fs);
			Counter = 2;
		}
		
		S = S - (Sc + Fs) * T;
		count++;
	}
	
	Console.WriteLine(count);
  }
}