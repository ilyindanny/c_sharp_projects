using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main()
    {


        /*
        Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
        [345, 897, 568, 234] -> 2
        */

        Exercise34();

        void Exercise34()
        {

            int[] array = GetArray(8);

            Write(String.Join(" ", array) + "\n");
            Write(FindClear(array) + "\n");

            int[] GetArray(int size)
            {
                int[] array = new int[size].Select(x => new Random().Next(100, 1000)).ToArray();
                return array;
            }


            int FindClear(int[] array)
            {
                int result = 0;
                foreach (int el in array)
                {
                    if (el % 2 == 0) result += 1;
                }
                return result;
            }

        }


        /*
        Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
        [3, 7, 23, 12] -> 19
        [-4, -6, 89, 6] -> 0
        */

        Exercise36();

        void Exercise36()
        {

            int[] array = new int[5].Select(x => new Random().Next(1, 10)).ToArray();

            Write(String.Join(" ", array) + "\n");
            Write(ArraySum(array) + "\n");

            int ArraySum(int[] array)
            {
                int result = 0;
                for (int i = 0; i < array.Length; i += 2) result += array[i];
                return result;
            }

        }


        /*
        Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
        [3 7 22 2 78] -> 76
        */


        Exercise38();

        void Exercise38()
        {

            int[] array = GetArray(8);

            Write(String.Join(" ", array) + "\n");
            Write(FindDiff(array));

            int[] GetArray(int size)
            {
                int[] array = new int[size];
                for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-9, 10);
                return array;
            }

            int FindDiff(int[] array)
            {
                int max = array[0];
                int min = array[0];

                foreach (int el in array)
                {
                    if (el > max) max = el;
                    if (el < min) min = el;
                }
                return max - min;
            }

        }


    }
}