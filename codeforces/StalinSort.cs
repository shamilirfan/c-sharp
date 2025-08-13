using System;

class StalinSort
{
    public static void Main(string[] args)
    {
        int input_1 = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < input_1; i++)
        {
            int input_2 = int.Parse(Console.ReadLine()!);
            int[] input_3 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int x = 0;
            int[] arr = new int[input_2];

            for (int j = 0; j < input_2; j++)
            {
                for (int k = j + 1; k < input_2; k++)
                {
                    if (input_3[j] < input_3[k])
                        x++;
                }
                x = x + j;
                arr[j] = x;
                x = 0;
            }

            Console.WriteLine(arr.Min());
        }
    }
}
