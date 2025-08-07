using System;

class Bit
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        int X = 0;

        do
        {
            string input2 = Console.ReadLine();

            if (input2 == "++X" || input2 == "X++")
            {
                ++X;
            }
            else
            {
                X--;
            }
            count++;
        } while (count <= input1);

        Console.WriteLine(X);
    }
}
