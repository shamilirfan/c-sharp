using System;

class Tram
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int[] b = new int[a * 2];

        for (int i = 0; i < a; i++)
        {
            string? c = Console.ReadLine();

            string[] d = c.Split();
            int firstNumber = int.Parse(d[0]);
            int secondNumber = int.Parse(d[1]);

            b[i * 2] = firstNumber;
            b[i * 2 + 1] = secondNumber;
        }

        // Sum
        int sum = 0;

        for (int i = 3; i < b.Length; i += 1)
        {
            sum += b[i];
        }

        // 
        List<int> e = new List<int>();
        int x = 0;
        int y = 0;

        for (int i = 1; i < b.Length - 1; i += 2)
        {
            if (x == 0 && !(sum <= b[i]))
            {
                int f = b[i] - b[i + 1] + b[i + 2];
                e.Add(f);
                y += f;
            }
            else if (sum <= b[i])
            {
                e.Add(b[i]);
            }
            else
            {
                int g = y - b[i + 1] + b[i + 2];
                e.Add(g);
                y = g;
            }
            x++;
        }

        // Result
        Console.Write($"{e.Max()}");

    }
}