using System;

class Integer_Diversity
{
    public static void Main(string[] args)
    {
        int input1 = int.Parse(Console.ReadLine());

        for (int x = 0; x < input1; x++)
        {
            int input2 = int.Parse(Console.ReadLine());
            int[] input3 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
            int[] arr = new int[input3.Length];

            for (int i = 0; i < input3.Length; i++)
            {
                if (input3[i] < 0) arr[i] = Math.Abs(input3[i]);
                else arr[i] = input3[i];
            }

            // Sort the array
            Array.Sort(arr);
            List<int> result = new List<int>();

            // Loop and count frequencies
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    count++;
                else
                {
                    if (arr[i - 1] == 0 || count == 1) result.Add(1);
                    else result.Add(2);
                    count = 1;
                }
            }

            // Don't forget the last element
            if (arr[arr.Length - 1] == 0 || count == 1) result.Add(1);
            else result.Add(2);

            Console.WriteLine(result.Sum());
        }
    }
}