using System;

class Foreach
{
    public static void Main(string[] args)
    {
        int[] numbers;
        numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, -8 };

        int sum = 0;

        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        Console.WriteLine($"{sum}");

        //
        foreach (int number in numbers)
        {
            if (number < 0)
            {
                Console.WriteLine($"{number}");
            }
        }


    }
}