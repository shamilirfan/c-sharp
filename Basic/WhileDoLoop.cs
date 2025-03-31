using System;

class WhileDoLoop
{
    public static void Main(string[] args)
    {
        int a = 1;

        while (a <= 5)
        {
            Console.WriteLine(a);
            a++;
        }

        //
        int b = 1;

        do
        {
            Console.WriteLine(b);
            b++;
        } while (b <= 5);
        
    }
}