using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SortArray
{
    public static void Main(string[] args)
    {
        int[] numbers1 = new int[5] { 5, 1, 3, 2, 4 };
        int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };


        // sort
        Array.Sort(numbers1);
        foreach (int number1 in numbers1)
        {
            Console.Write($"{number1} ");
        }
        Console.WriteLine();


        // reverse
        Array.Reverse(numbers2);
        foreach (int number2 in numbers2)
        {
            Console.Write($"{number2} ");
        }



    }
}