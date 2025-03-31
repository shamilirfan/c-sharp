using System;
// 6
class Person
{
    private string name;
    public string GetName() // readable
    {
        return name;
    }
    public void SetName(string n) // writeable
    {
        name = n;
    }
    private int age;
    public int GetAge() // readable
    {
        return age;
    }
    public void SetAge(int a) // writeable
    {
        age = a;
    }
    private string city;  // not readable and not writeable
}
class SetterAndGetter
{
    public static void Main(string[] args)
    {
        Person topu = new Person();
        topu.SetName("Topu");
        topu.SetAge(35);
        Console.WriteLine($"Name: {topu.GetName()}, Age: {topu.GetAge()}");

    }
}
