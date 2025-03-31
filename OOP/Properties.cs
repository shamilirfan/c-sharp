using System;
// 7
class PersOn
{
    public string? name; // readable and writeable
    private int age; // not readable and writeable
    public int Age // readable and writeable by properties 
    {
        get
        {
            return age;
        }
        set
        {
            age = value; // value, it is keyword.
        }

        // or
        // it is short hand.
        // get; set; 
    }
}
class Properties
{
    public static void Main(string[] args)
    {
        PersOn p1 = new PersOn();
        p1.name = "Linda";
        p1.Age = 22;
        Console.WriteLine($"Name: {p1.name}, Age: {p1.Age}");
    }
}

