using System;

class BinarySearch
{
    public static void Main(string[] args)
    {
        int[] input1 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int[] input2 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        Array.Sort(input2);

        for (int i = 0; i < input1[1]; i++)
        {
            int input3 = int.Parse(Console.ReadLine()!);

            int low = 0,
                high = input2.Length - 1,
                result = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (input2[mid] == input3)
                {
                    result = input2[mid];
                    break;
                }
                else if (input2[mid] < input3)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            var output = result == -1 ? "not found" : "found";

            Console.WriteLine(output);
        }
    }
}
