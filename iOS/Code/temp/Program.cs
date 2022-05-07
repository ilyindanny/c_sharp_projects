//

using System;
using static System.Console;
using System.Linq;
class Program
{
	static void Main()
	{
		// метод StringFormat позволяет применить форматирование и вернуть строку:

		int A = 1, B = 2, C = A + B;
		string str = String.Format("{0} + {2} = {1}", A, C, B);
		WriteLine(str);
	}
}

