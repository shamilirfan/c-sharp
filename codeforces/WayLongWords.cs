using System;

class WayLongWords
{
    public static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());

        for (int count = 0; count < input1; count++)
        {
            string input2 = Console.ReadLine();

            if (input2.Length <= 10)
            {
                Console.WriteLine(input2);
            }
            else
            {
                char[] stringArray = input2.ToCharArray();
                Array.Reverse(stringArray);
                string reversedStr = new string(stringArray);

                Console.WriteLine($"{input2[0]}{input2.Length - 2}{reversedStr[0]}");
            }
        }
    }
}