// constAndMulti.cs

using System;

class Test5
{
    public static void Main(string[] args)
    {
        string name1 = "Minar";
        // variable value changing
        name1 = "Fardin";

        const string name2 = "Topu";
        // here changing is not allowed because of const
        // name2 = "Ratul";

        Console.WriteLine(name1);
        Console.WriteLine(name2);

        // value declare
        int num1;
        int num2;
        int num3;
        int num4;
        // value assign
        num1 = num2 = num3 = num4 = 10;

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        Console.WriteLine(num4);

    }
}