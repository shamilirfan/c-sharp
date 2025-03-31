public class Node
{
    public int? Value;
    public Node? Next;

    public Node(int value) // constractor
    {
        this.Value = value;
        this.Next = null;
    }
}
public? class SinglyLinkedList
{
    public Node? Head;
    public Node? Tail;
    public int Length;

    public SinglyLinkedList() // constractor
    {
        this.Head = null;
        this.Tail = null;
        this.Length = 0;
    }

    public bool IsEmpty() => this.Length == 0;

    public void Push(int value)
    {
        var newNode = new Node(value);

        if (IsEmpty())
        {
            this.Head = newNode;
            this.Tail = newNode;
        }
        else
        {
            this.Tail!.Next = newNode;
            this.Tail = newNode;
        }

        this.Length += 1;
    }

   // adding print function/method to show the every element
    public void PrintList()
    {
        for (int i = 0; i < this.Length; i += 1)
        {
            Console.Write($"{this.Head!.Value} ");
            this.Head = this.Head.Next;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var list = new SinglyLinkedList();

        list.Push(1);
        list.Push(2);
        list.Push(3);
        list.Push(4);

        list.PrintList();
        // Console.WriteLine(list.Head.Next.Next.Next.Value);
    }
}