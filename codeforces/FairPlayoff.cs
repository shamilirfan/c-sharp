using System;

class FairPlayoff
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i += 1)
        {
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a = { input2[0], input2[1] };
            int[] b = { input2[2], input2[3] };

            if (a.Max() > b.Min() && b.Max() > a.Min())
                Console.WriteLine($"YES");
            else
                Console.WriteLine($"NO");

        }
    }
}