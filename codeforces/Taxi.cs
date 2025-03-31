using System;

class Taxi
{
    public static void Main(string[] args)
    {
        // Inputs
        int a = Convert.ToInt32(Console.ReadLine());
        int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // variables
        int one = 0;
        int extraOne = 0;
        int two = 0;
        int extraTwo = 0;
        int three = 0;
        int four = 0;

        // one
        foreach (int item in b)
        {
            if (item == 1)
            {
                one += 1;
            }
        }

        // two
        foreach (int item in b)
        {
            if (item == 2)
            {
                two += 1;
            }
        }

        // three
        foreach (int item in b)
        {
            if (item == 3 && one >= 1)
            {
                three += 1;
                one -= 1;
            }
            else if (item == 3 && one < 1)
            {
                three += 1;
            }
        }

        // four
        foreach (int item in b)
        {
            if (item == 4)
            {
                four += 1;
            }
        }

        // tow-calculation
        if (two % 2 == 0)
        {
            two /= 2;
        }
        else if (two % 2 != 0)
        {
            two -= 1;
            two /= 2;
            extraTwo += 1;
        }

        // extraTwo
        if (one > 1 && extraTwo == 1)
        {
            one -= 2;
        }
        else if (one == 1 && extraTwo == 1)
        {
            one -= 1;
        }

        // extraOne 
        for (int i = one; i > 0; i -= 1)
        {
            if (one >= 4)
            {
                one -= 4;
                extraOne += 1;
            }
            else if (one == 3)
            {
                one -= 3;
                extraOne += 1;
            }
            else if (one == 2)
            {
                one -= 2;
                extraOne += 1;
            }
            else if (one == 1)
            {
                one -= 1;
                extraOne += 1;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"{one + two + three + four + extraOne + extraTwo}");

    }
}