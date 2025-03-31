using System;

class BoringApartments
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        List<string> a = new List<string>
        {
            "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
            "2", "2", "2", "2", "2", "2", "2", "2", "2", "2",
            "3", "3", "3", "3", "3", "3", "3", "3", "3", "3",
            "4", "4", "4", "4", "4", "4", "4", "4", "4", "4",
            "5", "5", "5", "5", "5", "5", "5", "5", "5", "5",
            "6", "6", "6", "6", "6", "6", "6", "6", "6", "6",
            "7", "7", "7", "7", "7", "7", "7", "7", "7", "7",
            "8", "8", "8", "8", "8", "8", "8", "8", "8", "8",
            "9", "9", "9", "9", "9", "9", "9", "9", "9", "9",
        };

        //
        for (int y = 0; y < x; y++)
        {
            string? input = Console.ReadLine();
            char[] b = input.ToCharArray();
            int sum = 0;

            //
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[0].ToString())
                    break;
                else
                    sum++;
            }

            //
            if (input.Length == 1)
                sum += 1;
            else if (input.Length == 2)
                sum += 3;
            else if (input.Length == 3)
                sum += 6;
            else if (input.Length == 4)
                sum += 10;

            Console.WriteLine($"{sum}");
        }
    }
}