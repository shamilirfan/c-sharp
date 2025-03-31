using System;

class I_WannaBetheGuy
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        List<int> b = new List<int>();
        List<int> c = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> d = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> e = new List<int>();

        // b
        for (int i = 1; i <= a; i++)
        {
            b.Add(i);
        }

        // c
        for (int i = 1; i < c.Count; i++)
        {
            e.Add(c[i]);
        }

        // d
        for (int i = 1; i < d.Count; i++)
        {
            e.Add(d[i]);
        }

        // e
        int[] f = new int[e.Count];
        var g = f.OrderBy(a => a).Distinct();

        for (int i = 0; i < e.Count; i++)
        {
            f[i] = e[i];
        }

        // result
        if (b.Count() == g.Count())
        {
            Console.Write($"I become the guy.");
        }
        else
        {
            Console.Write($"Oh, my keyboard!");
        }

    }
}