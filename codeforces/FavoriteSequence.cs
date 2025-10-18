using System;

class FavoriteSequence
{
    public static void Main(string[] args)
    {
        // step-1
        int input1 = Convert.ToInt32(Console.ReadLine());

        // step-2
        for (int i = 0; i < input1; i += 1)
        {
            // step-3
            int input2 = Convert.ToInt32(Console.ReadLine());
            int[] input3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr = new int[input2 + 1];
            int a = input2 - 1,
                b = 0,
                c = 1,
                d = 0;

            // step-4
            if (input2 % 2 == 0)
                d = input2 / 2;
            else
                d = input2 / 2 + 1;

            // step-5
            for (int j = 0; j < d; j += 1)
            {
                arr[b] = input3[j];
                arr[c] = input3[a];
                a--;
                b += 2;
                c += 2;
            }

            // step-6
            for (int m = 0; m < input2; m++)
            {
                Console.Write($"{arr[m]} ");
            }

            Console.WriteLine();
        }
    }
}
