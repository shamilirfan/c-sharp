using System;

class StonesOnTheTable
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        string? b = Console.ReadLine();
        int result = 0;

        for (int i = 1; i < b.Length; i += 1)
        {
            if (b[i - 1] == b[i])
            {
                result++;
            }
        }

        Console.WriteLine(result);

    }
}