using System;

class Assignment9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your marks: ");

        int a = Convert.ToInt32(Console.ReadLine());

        if (a > 100 || a < 1)
        {
            Console.Write("Invalid");
        }
        else if (a >= 80)
        {
            Console.Write("your grade is A+");
        }
        else if (a >= 70)
        {
            Console.Write("your grade is A");
        }
        else if (a >= 60)
        {
            Console.Write("your grade is A-");
        }
        else if (a >= 50)
        {
            Console.Write("your grade is B");
        }
        else if (a >= 40)
        {
            Console.Write("your grade is C");
        }
        else if (a >= 33)
        {
            Console.Write("your grade is D");
        }
        else
        {
            Console.Write("your are Failed!");
        }

    }
}