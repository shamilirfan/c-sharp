using System;

class OddDivisor
{
    public static void Main(string[] args)
    {
        using System.Numerics;

        int a = int.Parse(Console.ReadLine());

        for (int i = 0; i < a; i += 1)
        {
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = b & (b - 1);
            if (c != 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

    }
}