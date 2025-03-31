using System;

class Method
{
    public static void Add(int num1, int num2)
    // if method does not return anythig, void will be written before the method name. Void means "empty".
    {
        int result = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {result}");
    }
    public static void Sub(int num1, int num2)
    {
        int result = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {result}");
    }
    public static int Mult(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int Div(int num1, int num2)
    {
        return num1 / num2;
    }
    public static void Main(string[] args)
    {
        Add(10, 5);
        Add(10, 10);

        Sub(10, 5);

        int result1 = Mult(10, 5);
        Console.WriteLine($"{result1}");

        int result2 = Div(10, 5);
        Console.WriteLine($"{result2}");

    }
}


