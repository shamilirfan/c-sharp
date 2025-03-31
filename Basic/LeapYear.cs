using System;

class LeapYear
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a year: ");

        int a;
        a = Convert.ToInt32(Console.ReadLine());

        if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
        {
            Console.WriteLine($"{a} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{a} is not a leap year.");
        }

    }
}