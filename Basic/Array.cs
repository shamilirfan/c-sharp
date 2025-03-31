using System;

class Array
{
    // Array is Collection of variable.
    public static void Main(string[] args)
    {
        // array declare and assign
        string[] names = { "Alex", "Sathi", "Rupa", "Bob", "Topu" };
        int[] numbers = { 1, 2, 3, 4, 5 };
        char[] charecter = { 'a', 'b', 'c', 'd', 'e' };
        bool[] boolean = { true, false };

        Console.WriteLine(names[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(charecter[2]);
        Console.WriteLine(boolean[0]);

        // array and size declare
        string[] fruit = new string[5];
        Console.WriteLine(fruit.Length);

        // array value assign
        fruit[0] = "Apple";
        fruit[1] = "Mango";
        fruit[2] = "Banana";
        fruit[3] = "Watermelon";
        fruit[4] = "Grap";

        Console.WriteLine(fruit[1]);


        // array and size declare and value assign
        string[] flower = new string[5] { "Tulip", "Marigold", "Sunflower", "Daffodil", "Jasmine" };

        Console.WriteLine(flower[3]);


        // array declare
        string[] cars;
        // array size declare and value assign
        cars = new string[5] { "Tesla", "Volvo", "BMW", "Ford", "Mazda" };

        Console.WriteLine(cars[0]);


        // 
        string[] vagetable = new string[5] { "Green Peas", "Capsicum", "Garlic", "Mushroom", "Onion" };

        // array value change
        vagetable[0] = "Potato";

        Console.WriteLine(vagetable[0]);



    }
}