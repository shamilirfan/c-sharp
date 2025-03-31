using System;

class Practice
{
    public static void Main(string[] args)
    {
        Console.Write("enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("welcome " + name + '!');

        Console.Write("enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("you are " + age + " years old.");

        Console.Write("enter your gpa: ");
        double gpa = Convert.ToDouble(Console.ReadLine());
        Console.Write("your gpa is " + gpa);

        Console.WriteLine("are you registered? ");
        bool isReg = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Registration is " + isReg);


    }
}