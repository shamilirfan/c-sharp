using System;

class TrippiTroppi
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string? str = Console.ReadLine();
            string[] arr = str!.Split().ToArray();
            string result = "";
    
            foreach (string item in arr)
            {
                result += item[0];
            }
    
            Console.WriteLine(result);
        }
    }
}