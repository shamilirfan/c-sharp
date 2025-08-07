using System;

class StringTask
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine().ToLower();

        for (int i = 0; i < a.Length; i++)
        {
            char c = a[i];
            string d = Convert.ToString(c);

            if (d == "a" || d == "e" || d == "i" || d == "o" || d == "u" || d == "y")
            {
                continue;
            }
            else
            {
                Console.Write("." + d);
            }
        }
    }
}
