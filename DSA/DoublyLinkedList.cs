public class Node
{
    public int? Value;
    public Node? Next;
    public Node? Previous;
    public Node(int value) // constractor
    {
        this.Value = value;
        this.Next = null;
        this.Previous = null;
    }
}
public? class DoublyLinkedList
{
    public Node? Head;
    public Node? Tail;
    public int? Length;
    public DoublyLinkedList()
    {
        this.Head = null;
        this.Tail = null;
        this.Length = 0;
    }

    // push method
    public void Push(int value)
    {
        Node newNode = new Node(value);

        if (this.Length == 0)
        {
            this.Head = newNode;
            this.Tail = newNode;
        }
        else
        {
            this.Tail!.Next = newNode;
            newNode.Previous = this.Tail;
            this.Tail = newNode;
        }

        this.Length += 1;
    }

    // adding print function/method to show the every element
    public void PrintInfo()
    {
        for (int i = 0; i < this.Length; i += 1)
        {
            Console.WriteLine($"{this.Head!.Value}");
            this.Head = this.Head.Next;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        DoublyLinkedList list = new DoublyLinkedList();
        list.Push(1);
        list.Push(2);
        list.Push(3);
        list.Push(4);

        list.PrintInfo();
    }
}