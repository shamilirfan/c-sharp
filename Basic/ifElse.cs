using System;

class ElseIf
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a digit: ");
        
        int input = Convert.ToInt32(Console.ReadLine());

        if (input > 0)
        {
            Console.Write($"{input} is positive number.");
        }
        else if (input == 0)
        {
            Console.Write("zero");
        }
        else
        {
            Console.Write($"{input} is negative number.");
        }
    }
}