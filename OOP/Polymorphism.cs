using System;
// 18
class Flower // base class(parent) 
{
    public virtual void FlowerColor()
    {
        Console.WriteLine($"Every flower has own color.");
    }
}
class Rose : Flower // derived class(child)
{
    public override void FlowerColor()
    {
        Console.WriteLine($"Rose is red.");
    }
}
class Jasmin : Flower // derived class(child)
{
    public override void FlowerColor()
    {
        Console.WriteLine($"Jasmine is white.");
    }
}
class Popy : Flower // derived class(child)
{
    public override void FlowerColor()
    {
        Console.WriteLine($"Popy is pink.");
    }
}
class Polymorphism
{
    public static void Main(string[] args)
    {
        Flower flower = new Flower();
        Flower rose = new Rose();
        Flower jasmin = new Jasmin();
        Flower popy = new Popy();

        flower.FlowerColor();
        rose.FlowerColor();
        jasmin.FlowerColor();
        popy.FlowerColor();
    }
}