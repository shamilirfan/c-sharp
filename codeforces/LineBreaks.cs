using System;

class LineBreaks
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i++)
        {
            int[] input2 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] arr = new int[input2[0]];
            int temp = input2[1],
                sum = 0,
                count = 0;

            for (int j = 0; j < input2[0]; j++)
            {
                string? input3 = Console.ReadLine();
                arr[j] = input3!.Length;
            }

            foreach (var item in arr)
            {
                sum += item;
                count++;
                if (sum > temp)
                {
                    count -= 1;
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
