using System;

class DivisibilityProblem
{
    public static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] y = Console.ReadLine().Split();
            int a = int.Parse(y[0]);
            int b = int.Parse(y[1]);

            if (a % b == 0)
            {
                Console.WriteLine($"{0}");
            }
            else
            {
                Console.WriteLine($"{a + (b - a % b) - a}");
            }
        }

    }
}