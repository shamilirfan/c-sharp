using System;

class Elephant
{
    public static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int a = input;
        int result = 0;

        for (int i = 0; i < a; i += 1)
        {
            if (input >= 5)
                input -= 5;
            else if (input == 4)
                input -= 4;
            else if (input == 3)
                input -= 3;
            else if (input == 2)
                input -= 2;
            else if (input == 1)
                input -= 1;
            else
                break;
            result++;
        }

        Console.WriteLine(result);
    }
}