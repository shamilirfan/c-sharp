using System;

class Assignment8
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a digit: ");
        int input1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter a digit: ");
        int input2 = Convert.ToInt32(Console.ReadLine());

        if (input1 > input2)
        {
            Console.WriteLine($"{input1} is greater than {input2}");
        }
        else if (input1 < input2)
        {
            Console.WriteLine($"{input1} is smaller than {input2}");
        }
        else if (input1 == input2)
        {
            Console.WriteLine($"{input1} is equal {input2}");
        }
        else
        {
            Console.WriteLine("Invalid!");
        }

    }
}