using System;

class Minimize
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i = i + 1)
        {
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int c = input2[0];
            int a = input2[0];
            int b = input2[1];

            Console.WriteLine($"{c - a + (b - c)}");
        }

    }
}