using System;

class RectangleArrangement
{
    public static void Main(string[] args)
    {
        int input_1 = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < input_1; i++)
        {
            int input_2 = int.Parse(Console.ReadLine()!);
            int[] arr1 = new int[input_2],
                arr2 = new int[input_2];

            for (int j = 0; j < input_2; j++)
            {
                int[] input_3 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                arr1[j] = input_3[0];
                arr2[j] = input_3[1];
            }

            Console.WriteLine((arr1.Max() + arr2.Max()) * 2);
        }
    }
}
