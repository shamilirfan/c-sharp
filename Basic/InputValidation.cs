using System;

class InputValidation
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("enter a number from 1 to 10 or or write quite to exit: ");
            string input = Console.ReadLine() ?? ""; // to handle null
            input = input.ToLower().Trim(); // trim to remove space

            if (input == "quit")
            {
                Console.WriteLine("Good bye!!!");
                break;
            }

            if (!(int.TryParse(input, out int number)))
            {
                Console.WriteLine("enter a valid number");
                continue;
            }

            if (!(number >= 1 && number <= 10))
            {
                Console.WriteLine("out of range!");
                continue;
            }

            int square = number * number;
            Console.WriteLine($"{number} = {square}");
            
        }
    }
}