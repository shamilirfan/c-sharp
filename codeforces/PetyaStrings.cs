using System;

class PetyaStrings
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine().ToUpper();
        string b = Console.ReadLine().ToUpper();

        for (int i = 0; i < a.Length; i++)
        {
            int x = a[i];
            int y = b[i];

            if (a == b)
            {
                Console.WriteLine(0);
                break;
            }
            else if (x < y)
            {
                Console.WriteLine(-1);
                break;
            }
            else if (y < x)
            {
                Console.WriteLine(1);
                break;
            }
        }
    }
}