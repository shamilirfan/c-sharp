using System;

class YoungPhysicist
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        List<int> one = new List<int>();
        List<int> two = new List<int>();
        List<int> three = new List<int>();

        for (int i = 0; i < a; i += 1)
        {
            int[] c = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int j = 0; j < 1; j += 1)
            {
                one.Add(c[j]);
                two.Add(c[j + 1]);
                three.Add(c[j + 2]);
            }
        }

        // one
        int sum1 = 0;

        foreach (int item in one)
        {
            sum1 += item;
        }

        // two
        int sum2 = 0;

        foreach (int item in two)
        {
            sum1 += item;
        }

        // three
        int sum3 = 0;

        foreach (int item in three)
        {
            sum3 += item;
        }

        // result
        if (sum1 == 0 && sum2 == 0 && sum3 == 0)
        {
            Console.WriteLine($"YES");
        }
        else
        {
            Console.WriteLine($"NO");
        }


    }
}