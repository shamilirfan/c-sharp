using System;

class Buy_a_Shovel
{
    public static void Main(string[] args)
    {
        int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int i = 1;

        while (true)
        {
            int a = input[0] * i,
                b = input[1];
            string c = a.ToString(),
                d = b.ToString();

            if (c[^1] == d[^1] || c[^1] == '0')
            {
                Console.WriteLine(i);
                break;
            }

            i++;
        }
    }
}
