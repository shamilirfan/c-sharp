using System;

class SoldierAndBananas
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        var i0 = int.Parse(data[0]);
        var i1 = int.Parse(data[1]);
        var i2 = int.Parse(data[2]);

        int result = i2;
        int sum = 0;

        for (int i = 0; i < i2; i++)
        {
            sum += i0 * result--;
        }

        if (sum > i1)
        {
            Console.WriteLine(sum - i1);
        }
        else
        {
            Console.WriteLine(result);
        }

    }
}