using System;

public class Program
{
    static public void Main ()
    {



Console.WriteLine("Enter n:"); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter m:"); 
int m = Convert.ToInt32(Console.ReadLine()); 
int [,]arr=new int [n, m]; 
int []sum=new int [m]; 
Random ran = new Random(); 
 
for (int i=0; i<n; i++) 
{ 
    for(int j=0; j<m; j++) 
    { 
        arr[i, j] = ran.Next(0, 10); 
 
        Console.Write(arr[i, j] + "\t"); 
    } 
    Console.WriteLine(); 
} 
 

int k = 0;
for (int i=0; i<m; i++) 
{ 
    for(int j=0; j<n; j++) 
    { 
        sum[k] += arr[j, i];
        k++;
        Console.Write((sum[i] / n)  + " "); 
    } 
} 

    }
}
