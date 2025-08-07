using System;

class InSearchofAnEasyProblem
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        string[] input2 = new string[input1];
        input2 = Console.ReadLine().Split(' ');
        int[] a = new int[input2.Length];

        for (int i = 0; i < input2.Length; i++)
        {
            a[i] = int.Parse(input2[i]);
        }

        for (int y = 0; y < a.Length; y++)
        {
            if (a.Sum() > 0)
            {
                Console.WriteLine($"HARD");
                break;
            }
            else
            {
                Console.WriteLine($"EASY");
                break;
            }
        }
    }
}
