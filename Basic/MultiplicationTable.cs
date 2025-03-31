using System;

class MultiplicationTable
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number1} x {i} = {number1 * i}");
        }

        //
        Console.Write("Enter starting number: ");
        int startingNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter ending number: ");
        int endingNumber = Convert.ToInt32(Console.ReadLine());

        for (int a = startingNumber; a <= endingNumber; a++)
        {
            for (int b = 1; b <= 10; b++)
            {
                Console.WriteLine($"{a} x {b} = {a * b}");
            }

            Console.WriteLine();
        }

    }
}