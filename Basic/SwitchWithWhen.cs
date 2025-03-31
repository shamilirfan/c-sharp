using System;

class SwitchWithWhen
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number from 1 to 10: ");
        int input;
        input = Convert.ToInt32(Console.ReadLine());

        switch (input)
        {
            case int num when num < 1 || num > 10:
                Console.WriteLine($"{input} is out of range!");
                break;
            case int num when num % 2 == 0:
                Console.WriteLine($"{input} is even number");
                break;
            default:
                Console.WriteLine($"{input} is odd number");
                break;
        }

        // short hand
        Console.WriteLine("enter a number between 1 to 10: ");

        int input2 = Convert.ToInt32(Console.ReadLine());

        string result1 = input2 switch
        {
            int num when num >= 1 && num <= 10 => num % 2 == 0 ? "even number" : "odd number",
            _ => "out of Range!"
        };

        Console.WriteLine($"{input2} is {result1}");

    }
}