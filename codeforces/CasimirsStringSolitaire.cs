using System;

class CasimirsStringSolitaire
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < a; i++)
        {
            string? b = Console.ReadLine();
            int countA = b.Count(x => "A".Contains(x));
            int countB = b.Count(x => "B".Contains(x));
            int countC = b.Count(x => "C".Contains(x));

            if (countA + countC == countB)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}