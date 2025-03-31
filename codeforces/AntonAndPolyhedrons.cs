using System;

class AntonAndPolyhedrons
{
    public static void Main(string[] args)
    {
        int? a = Convert.ToInt32(Console.ReadLine());
        int x = 0;

        for (int i = 0; i < a; i += 1)
        {
            string? b = Console.ReadLine();

            if (b == "Tetrahedron")
                x += 4;
            else if (b == "Cube")
                x += 6;
            else if (b == "Octahedron")
                x += 8;
            else if (b == "Dodecahedron")
                x += 12;
            else if (b == "Icosahedron")
                x += 20;
        }

        Console.WriteLine($"{x}");


    }
}