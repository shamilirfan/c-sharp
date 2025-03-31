using System;

class Marathon
{
    public static void Main(string[] args)
    {
        int intput1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < intput1; i += 1)
        {
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input2[0];
            int b = input2[1];
            int c = input2[2];
            int d = input2[3];
            int result = 0;

            if (a < b && a < c && a < d)
                result += 3;
            else if (a < b && a < c || a < b && a < d || a < c && a < d)
                result += 2;
            else if (a < b || a < c || a < d)
                result += 1;

            Console.WriteLine($"{result}");
        }

    }
}