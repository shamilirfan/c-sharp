using System;

class LogicalOpe
{
    public static void Main(string[] args)
    {
        // Logical operators = &&, ||, !
        
        Console.WriteLine(5 > 4 && 5 > 3 && 5 > 2);
        Console.WriteLine(5 > 4 && 5 < 3 && 5 > 2);
        Console.WriteLine(5 > 4 || 5 > 3 || 5 > 2);
        Console.WriteLine(5 < 4 || 5 < 3 || 5 > 2);
        Console.WriteLine(5 < 4 || 5 < 3 || 5 < 2);
        Console.WriteLine(!(true));
        Console.WriteLine(!(false));

    }
}