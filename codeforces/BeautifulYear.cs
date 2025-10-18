using System;

class BeautifulYear
{
    public static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine()!);
        year++;
        string a = year.ToString();

        if (a.Distinct().Count() != a.Length)
        {
            while (true)
            {
                int b = year++;

                if (b.ToString().Distinct().Count() == b.ToString().Length)
                {
                    Console.WriteLine(b);
                    break;
                }
            }
        }
        else
            Console.WriteLine(year);
    }
}
