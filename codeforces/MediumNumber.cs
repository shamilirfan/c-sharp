using System;

class MediumNumber
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i++)
        {
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = input2.OrderBy(x => x).ToArray();

            Console.WriteLine(a[1]);
        }

    }
}