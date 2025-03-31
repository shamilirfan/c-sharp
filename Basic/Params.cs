using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Params
{
    public static void Abc(params int[] numbers)
    {
        foreach (int a in numbers)
        {
            Console.Write($"{a} ");
        }
    }
    public static void Main(string[] args)
    {
        Abc(1, 2);
        Abc(3, 4, 5);
        Abc(6, 7, 8, 9, 10);

    }
}