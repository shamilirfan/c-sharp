using System;

class AssignmentOpe
{
    public static void Main(string[] args)
    {
        // Assignment Operator = +=, -=, *=, /=, %=
        int num1 = 6;
        int num2 = 2;

        Console.WriteLine($"{num1} += {num2} = {num1 += num2}");
        Console.WriteLine($"{num1} -= {num2} = {num1 -= num2}");
        Console.WriteLine($"{num1} *= {num2} = {num1 *= num2}");
        Console.WriteLine($"{num1} /= {num2} = {num1 /= num2}");
        Console.WriteLine($"{num1} %= {num2} = {num1 %= num2}");

    }
}