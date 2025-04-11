using System.Collections;

class Stack
{
    public static void Main(string[] args)
    {
        // Stack ( Non-Generic Collection )
        /* Stack means pile of objects. 
           Stack Non Generic Collection in C#
           LIFO - Last In, First Out
        */

        Stack<dynamic> stack1 = new Stack<dynamic>();
        /* Push inserts an item at the top of elements in the stack */
        stack1.Push("Hello!");
        stack1.Push(1);
        stack1.Push(2);
        stack1.Push(3);
        stack1.Push(56.84);
        stack1.Push(null);
        stack1.Push('A');
        stack1.Push(true);

        foreach (object item in stack1)
        {
            Console.WriteLine($"{item}");
        }



    }
}