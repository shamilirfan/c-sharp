using System;

class Watermelon
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0 && a != 2)
            Console.WriteLine("YES");

        else
            Console.WriteLine("NO");
    }
}