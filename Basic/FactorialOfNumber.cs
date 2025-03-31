using System;

class FactorialOfNumber
{
    public static void Main(string[] args)
    {
        // Rules of factorial number :- Ex:- factorial of 5 = 5 * 4 * 3 * 2 * 1 = 120

        int result = 1;

        for (int count = 1; count <= 5; count = count + 1)
        {
            result = result * count;
        }

        Console.WriteLine($"Factorial = {result}");

    }
}