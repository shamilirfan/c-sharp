using System;

class NextRound
{
    public static void Main(string[] args)
    {
        string[] intput1 = Console.ReadLine().Split(' ');
        int b = int.Parse(intput1[0]);
        int c = int.Parse(intput1[1]);

        string[] intput2 = Console.ReadLine().Split(' ');
        int[] x = new int[b];

        for (int d = 0; d < intput2.Length; d += 1)
        {
            x[d] = int.Parse(intput2[d]);
        }

        int result = 0;
        int j = x[c - 1];

        foreach (int y in x)
        {
            if (y >= j && y > 0)
            {
                result++;
            }
            else
            {
                break;
            }
        }

        Console.Write($"{result} ");
        
    }
}