using System;

class BasicCalculator
{
    public static void Main(string[] args)
    {
        int number1, number2;
        char operation;

        Console.Write("Enter an operation (+, -, *, /, %) : ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter number1 : ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number2 : ");
        number2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                break;
            case '-':
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                break;
            case '*':
                Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                break;
            case '/':
                if (number2 != 0)
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                else
                    Console.WriteLine($"we cannot devide");
                break;
            case '%':
                Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
                break;
            default:
                Console.WriteLine($"Invalid!");
                break;
        }

    }
}