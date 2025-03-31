using System;

class SwitchStatement2
{
    public static void Main(string[] args)
    {
        // switch shorthand 
        // => it is called lemda expression.

        Console.WriteLine("enter a digit from 1 to 4: ");
        int digit = Convert.ToInt32(Console.ReadLine());

        string message = digit switch
        {
            1 => "one",
            2 => "two",
            3 => "three",
            4 => "four",
            _ => "invalid"
        };

        Console.WriteLine($"{message}");

    }
}