using System;

class Translation
{
    public static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        char[] a = input2.ToCharArray();
        Array.Reverse(a);
        string b = new string(a);

        if (input1 == b)
        {
            Console.WriteLine($"YES");
        }
        else
        {
            Console.WriteLine($"NO");
        }
    }
}