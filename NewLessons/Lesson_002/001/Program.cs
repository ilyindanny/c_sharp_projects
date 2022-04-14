// methods


using System;
using static System.Console;


int A = 2;
int B = 47;
int C = 6;
int D = 48;
int E = 941;
int F = 3;
int G = 50;
int H = 7;
int I = 9;


int Max(int A, int B, int C)
{
	int result = A;
	if (B > result) result = B;
	if (C > result) result = C;
	return result;
}

/*
int max1 = Max(A, B, C);
int max2 = Max(D, E, F);
int max3 = Max(G, H, I);

int max = Max(max1, max2, max3);

WriteLine(max);
*/

int max = Max(
	Max(A, B, C),
	Max(D, E, F),
	Max(G, H, I));

WriteLine(max);
