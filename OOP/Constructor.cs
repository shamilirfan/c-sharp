using System;
// 3
class PersonClass2
{
    string name;
    int age;
    // default constructor
    public PersonClass2()
    {
        name = "not a value";
        age = 0;
    }
    // parameter ways constructor
    public PersonClass2(string n, int a)
    {
        name = n;
        age = a;
    }
    // constructor overloading. It is means everything is same but parameter is diffrent.
    public PersonClass2(string n)
    {
        name = n;
    }
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class Constructor
{
    public static void Main(string[] args)
    {
        PersonClass2 person1 = new PersonClass2("Alex", 33);
        person1.DisplayPersonInfo();

        PersonClass2 person2 = new PersonClass2("Bob");
        person2.DisplayPersonInfo();

        PersonClass2 person3 = new PersonClass2();
        person3.DisplayPersonInfo();

    }
}