using System;
// 4
class ReferenceType
{
    string name;
    int age;
    public ReferenceType(string n, int a)
    {
        name = n;
        age = a;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class ValueTypeVsReferenceType
{
    public static void Main(string[] args)
    {
        // this is value type
        int a = 30;
        int b = a;
        b = 20;

        Console.WriteLine($"a = {a}, b = {b}");

        // this is Reference Type
        ReferenceType p1 = new ReferenceType("John", 43);
        p1.DisplayInfo();

        ReferenceType p2 = new ReferenceType("Alex", 30);
        p2.DisplayInfo();

        ReferenceType p3 = p1;
        p3.DisplayInfo();

    }
}