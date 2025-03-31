using System;

class SakurakosExam
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input1; i++)
        {
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (input2[0] == 0 && input2[1] % 2 != 0 || input2[0] % 2 != 0)
                Console.WriteLine($"NO");
            else
                Console.WriteLine($"YES");
        }

    }
}