using System;

// 27
class AnonymousTypeArray
{
    public static void Main(string[] args)
    {
        var studentsArray = new[]
        {
            new
            {
                roll = 1,
                name = "Topu",
                address = "Dhaka"
            },
            new
            {
                roll = 2,
                name = "Rupa",
                address = "Comilla"
            },
            new
            {
                roll = 3,
                name = "Shagor",
                address = "Dhaka"
            },
            new
            {
                roll = 4,
                name = "Anika",
                address = "Gazipur"
            }
        };

        foreach (var studentArray in studentsArray)
        {
            Console.WriteLine(
                $"Roll: {studentArray.roll}, Name: {studentArray.name}, Address: {studentArray.address}"
            );
        }
    }
}
