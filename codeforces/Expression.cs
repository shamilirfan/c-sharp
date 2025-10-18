using System;

class Expression
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int d = a + b * c;
        int e = a * (b + c);
        int f = a * b * c;
        int g = (a + b) * c;
        int i = a + b + c;
        int[] h = new int[5];

        h[0] = d;
        h[1] = e;
        h[2] = f;
        h[3] = g;
        h[4] = i;

        Console.WriteLine(h.Max());
    }
}
