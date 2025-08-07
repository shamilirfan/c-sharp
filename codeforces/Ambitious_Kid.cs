using System;

class Ambitious_Kid
{
    public static void Main(string[] args)
    {
        // taking input from user
        int input1 = Convert.ToInt32(Console.ReadLine());
        string[] input2 = Console.ReadLine()!.Split(' ');
        int[] arr = new int[input1];

        for (int i = 0; i < input1; i++)
        {
            arr[i] = int.Parse(input2[i]);
        }

        //
        for (int i = 0; i < input1; i++)
        {
            if (arr[i] < 0)
                arr[i] = arr[i] * -1;
        }

        Console.WriteLine(arr.Min());
    }
}
