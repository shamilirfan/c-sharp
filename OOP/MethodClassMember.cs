using System;
// 2
class PersonClass
{
    public string name;
    public int age;
    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class FruitClass
{
    public string name;
    public string color;
    public int price;
    public void SetFruitValue(string n, string c, int p)
    {
        name = n;
        color = c;
        price = p;
    }
    public void DisplayFruit()
    {
        Console.WriteLine($"Fruit: {name}, Color: {color}, Price: {price}");
    }
}
class MethodClassMember
{
    public static void Main(string[] args)
    {
        PersonClass p1 = new PersonClass();
        p1.name = "Alex";
        p1.age = 33;
        p1.DisplayPerson();

        PersonClass p2 = new PersonClass();
        p2.name = "Bob";
        p2.age = 20;
        p2.DisplayPerson();

        FruitClass apple = new FruitClass();
        apple.SetFruitValue("Apple", "Green", 320);
        apple.DisplayFruit();

    }
}