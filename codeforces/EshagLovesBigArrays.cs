using System;

class EshagLovesBigArrays
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i++)
        {
            int input2 = Convert.ToInt32(Console.ReadLine());
            int[] input3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = int.MaxValue;
            int count = 0;

            foreach (int item in input3)
            {
                if (item < a)
                    a = item;
            }

            foreach (int item in input3)
            {
                if (item > a)
                    count += 1;
            }
            Console.WriteLine(count++);
        }
    }
}