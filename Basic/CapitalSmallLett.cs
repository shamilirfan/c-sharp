using System;

class CapitalSmallLett
{
    public static void Main(string[] args)
    {

        Console.WriteLine("enter any letter: ");

        char letter = Convert.ToChar(Console.ReadLine());

        if (letter >= 'A' && letter <= 'Z')
        {
            Console.WriteLine($"{letter} is capital letter");
        }
        else
        {
            Console.WriteLine($"{letter} is small letter");
        }

    }
}