using System;

class SumOfNumbers
{
    public static void Main(string[] args)
    {
        int sum = 0;

        for (int count = 1; count <= 5; count = count + 1)
        {
            sum = sum + count;
        }

        Console.WriteLine($"sum = {sum}");

    }
}