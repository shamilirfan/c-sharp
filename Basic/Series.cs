using System;

class Series
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the first number: ");
        int input1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the last number: ");
        int input2 = Convert.ToInt32(Console.ReadLine());

        for (int count = input1; count <= input2; count++)
        {
            Console.WriteLine($"{count} : Bangladesh");
        }

    }
}