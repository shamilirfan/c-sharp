using System;

class LoveStory
{
    static void Main()
    {
        string s = "codeforces";
        int input1 = int.Parse(Console.ReadLine()),
            differences = 0;

        for (int i = 0; i < input1; i++)
        {
            string input2 = Console.ReadLine();

            for (int j = 0; j < input2.Length; j++)
                if (s[j] != input2[j])
                    differences++;

            Console.WriteLine(differences);
            differences = 0;
        }
    }
}
