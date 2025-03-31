using System;
using System.Runtime.CompilerServices;

class Assignment
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter three digit");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"sum = {a + b + c}");

        int d = a + b + c;
        Console.WriteLine($"average = {d / (double)3}");

        // or
        int number1, number2, number3;

        Console.Write("Enter number1 = ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number2= ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number3 = ");
        number3 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2 + number3;
        double average = 3;

        Console.WriteLine($"sum = {sum}");
        Console.WriteLine($"average = {sum / average}");


    }
}