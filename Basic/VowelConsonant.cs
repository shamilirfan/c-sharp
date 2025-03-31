using System;

class VowelConsonant
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter any letter: ");

        char letter;
        letter = Convert.ToChar(Console.ReadLine());

        letter = char.ToLower(letter);

        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Console.WriteLine($"{letter} is vowel.");
        }
        else if (letter == 'y')
        {
            Console.WriteLine($"{letter} is special/semi vowel.");
        }
        else
        {
            Console.WriteLine($"{letter} is consonent.");
        }

    }
}