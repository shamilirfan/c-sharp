using System;

class ArrivalOfTheGeneral
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        string[] b = Console.ReadLine().Split();
        List<int> c = new List<int>();

        for (int d = 0; d < a; d += 1)
        {
            c.Add(int.Parse(b[d]));
        }

        //
        int max = c.Max();
        int maxI = 0;

        for (int i = 0; i < a; i++)
        {
            if (c[i] == max)
            {
                maxI = i;
                break;
            }
        }

        //
        int min = c.Min();
        int minI = 0;
        int minCount = 0;

        for (int i = 0; i < a; i++)
        {
            if (c[i] == min)
            {
                minI = i;
            }
        }

        if (minI > maxI)
        {
            for (int i = minI; i < a - 1; i++)
            {
                minCount++;
            }
        }
        else
        {
            for (int i = minI + 1; i < a - 1; i++)
            {
                minCount++;
            }
        }

        Console.WriteLine(minCount + maxI);
    }
}
