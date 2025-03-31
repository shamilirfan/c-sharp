using System;

class HitTheLottery
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        while (a > 0)
        {
            if (a >= 100)
            {
                a -= 100;
                result++;
            }
            else if (a >= 20)
            {
                a -= 20;
                result++;
            }
            else if (a >= 10)
            {
                a -= 10;
                result++;
            }
            else if (a >= 5)
            {
                a -= 5;
                result++;
            }
            else if (a >= 1)
            {
                a -= 1;
                result++;
            }
        }

        Console.WriteLine(result);

    }
}