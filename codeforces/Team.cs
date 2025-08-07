using System;

class Team
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        int result = 0;

        for (int i = 0; i < input1; i++)
        {
            string input2 = Console.ReadLine();

            if (input2 == "1 1 1" || input2 == "1 1 0" || input2 == "0 1 1" || input2 == "1 0 1")
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}
