using System;

class SelectMany
{
    public static void Main(string[] args)
    {
        List<List<int>> nestedList = new List<List<int>>
        {
            new List<int> { 1, 2 },
            new List<int> { 3, 4 },
            new List<int> { 5, 6 },
            new List<int> { 7, 8, 9, 10 },
        };

        var flattedList = nestedList.SelectMany(a => a);

        foreach (var item in flattedList)
        {
            Console.Write($"{item} ");
        }
    }
}
