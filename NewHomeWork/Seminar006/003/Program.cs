//
/*
**Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10
*/

using System;
using static System.Console;


int A = 18;

string result = "0";


while (A % 2 > 0)
{
	result = (A % 2).ToString() + result;
	A = A / 2;
}

Write(result);


// От Roman Bachinsky всем 09:02 PM
// int N = int.Parse(ReadLine());
// string s = string.Empty;
// while(N>0)
// {
//     s = N%2+s;
//     N = N/2;
// }


// WriteLine(s);



// using System;
// Console.WriteLine(DecToNum(10,16));



// string DecToNum(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber/otherSystem;
//         res=nums[decNumber-otherSystem*ost]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }

