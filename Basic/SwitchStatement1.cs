using System;

class SwitchStatement1
{
    public static void Main(string[] args)
    {
        int input1;
        Console.Write("enter a digit from 1 to 4: ");

        input1 = Convert.ToInt32(Console.ReadLine());

        switch (input1)
        {
            case 0:
                Console.Write("zero");
                break;
            case 1:
                Console.Write("one");
                break;
            case 2:
                Console.Write("two");
                break;
            case 3:
                Console.Write("three");
                break;
            case 4:
                Console.Write("four");
                break;
            default:
                Console.Write("invalid digit");
                break;
        }

        // multiple case
        Console.WriteLine("enter any letter: ");

        char input2 = Convert.ToChar(Console.ReadLine());
        input2 = char.ToLower(input2);

        switch (input2)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{input2} is vowel.");
                break;
            case 'y':
                Console.WriteLine($"{input2} is special/semi vowel.");
                break;
            default:
                if (Char.IsLetter(input2))
                {
                    Console.WriteLine($"{input2} is consonent.");
                }
                else
                {
                    Console.WriteLine($"{input2} is not a letter.");
                }
                break;
        }
        

    }
}