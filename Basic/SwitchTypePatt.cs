using System;

class SwitchTypePatt
{
    public static void Main(string[] args)
    {
        // switch type pattern

        // in traditional system type checking
        object num = 10;

        switch (num)
        {
            case int:
                Console.WriteLine($"{num} is integer.");
                break;
            case double:
                Console.WriteLine($"{num} is double.");
                break;
            case string:
                Console.WriteLine($"{num} is string.");
                break;
            case char:
                Console.WriteLine($"{num} is char.");
                break;
            case bool:
                Console.WriteLine($"{num} is bool.");
                break;
            default:
                Console.WriteLine($"unknown type!");
                break;
        }

        // short hand
        object num2 = 10;

        string result = num2 switch
        {
            int => "integer",
            double => "double",
            string => "string",
            char => "char",
            bool => "bool",
            _ => "unknown type!"
        };

        Console.WriteLine($"{num2} is {result}");

    }
}