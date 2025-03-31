using System;

class Games
{
    public static void Main(string[] args)
    {
        // step-1
        int a = Convert.ToInt32(Console.ReadLine());
        List<string> b = new List<string>();

        for (int i = 0; i < a; i += 1)
        {
            string? c = Console.ReadLine();
            b.Add(c);
        }

        // step-2
        List<string> d = new List<string>();
        List<string> e = new List<string>();

        for (int i = 0; i < a; i += 1)
        {
            string[] t = b[i].Split();
            for (int j = 0; j < t.Length; j += 2)
            {
                d.Add(t[j]);
            }
            for (int j = 1; j < t.Length; j += 2)
            {
                e.Add(t[j]);
            }
        }

        // step-3
        int result = 0;

        for (int i = 0; i < d.Count; i++)
        {
            for (int j = 0; j < d.Count; j++)
            {
                if (d[i] == e[j])
                    result++;
            }
        }

        Console.Write($"{result}");


    }
}