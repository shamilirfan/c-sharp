using System;

class ExceptionHandling2
{
    public static void Main(string[] args)
    {
        try
        {
            int num1 = ReadIntegerInput("num1");
            int num2 = ReadIntegerInput("num2");

            if (num2 > 100)
            {
                throw new ArgumentException("num2 can not be divide greater than 100");
            }

            int result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}\n");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
        finally
        {
            Console.WriteLine($"Goodbye!!!");
        }
    }

    static int ReadIntegerInput(string prompt)
    {
        while (true)
        {
            Console.Write($"Enter {prompt} = ");
            string input = Console.ReadLine() ?? "";
            // error throwing
            if (!int.TryParse(input, out int t) || string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input! please valid integer");
                continue;
            }
            return t;
        }
    }
}