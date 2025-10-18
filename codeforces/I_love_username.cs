using System;

class AntonAndLetters
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());
        int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int best = input2[0],
            worst = input2[0],
            count = 0;

        for (int i = 1; i < input2.Length; i++)
        {
            if (best < input2[i])
            {
                count++;
                best = input2[i];
            }
            else if (worst > input2[i])
            {
                count++;
                worst = input2[i];
            }
        }

        Console.WriteLine(count);
    }
}
