using System;

class WordCapitalization
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        char v = s[0];
        string r = Convert.ToString(v);

        Console.WriteLine(r.ToUpper() + s.Remove(0, 1));
    }
}
