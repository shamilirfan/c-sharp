using System;

class Start_EndWithMethod
{
    public static void Main(string[] args)
    {
        var studentsArray = new[]
        {
            new { roll = 1, name = "Topu" },
            new { roll = 2, name = "Rupa" },
            new { roll = 3, name = "Shagor" },
            new { roll = 4, name = "Anika" },
        };

        var search1 = studentsArray.Where(a => a.name.StartsWith("T")).ToArray();
        var search2 = studentsArray.Where(a => a.name.EndsWith("r")).ToArray();

        foreach (var studentArray in search1)
        {
            Console.WriteLine($"Roll: {studentArray.roll}, Name: {studentArray.name}");
        }

        foreach (var studentArray in search2)
        {
            Console.WriteLine($"Roll: {studentArray.roll}, Name: {studentArray.name}");
        }
    }
}
