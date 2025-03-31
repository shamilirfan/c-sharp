using System;

class UnaryOpe
{
    public static void Main(string[] args)
    {
        // Unary operator = ++, --

        int num = 10;

        Console.WriteLine(++num); // 11
        Console.WriteLine(num++); // 11
        Console.WriteLine(num--); // 12
        Console.WriteLine(--num); // 10

    }
}