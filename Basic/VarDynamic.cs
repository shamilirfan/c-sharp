using System;

class VarDynamic
{
    public static void Main(string[] args)
    {
        var a = "shiwly";
        // a = 10; // not allowed
        var b = 34;
        // b = "hello"; // not allowed

        dynamic c = "rupa";
        c = 10; // allowed
        dynamic d = 20;
        d = "hi"; // allowed

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);

    }
}