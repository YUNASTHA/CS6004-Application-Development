using System;

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle();

        rect.Length = 10;
        rect.Breadth = 5;

        Console.WriteLine(rect.ShowDetails());
        Console.WriteLine("Area: " + rect.GetArea());
        Console.WriteLine("Perimeter: " + rect.GetPerimeter());
    }
}
