using System;

class Program
{
    static void Main(string[] args)
    {
        //  ENUM
        Console.Write("Enter a day: ");
        string inputDay = Console.ReadLine()?.Trim().ToLower();

        DayType dayType;

        if (inputDay == "friday" || inputDay == "saturday")
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine($"It is: {dayType}");
        Console.WriteLine();

       
        // First book object
        Book book1 = new Book("C# Computer", "Yuna Shrestha", 399.99);

        // Second object 
        Book book2 = book1 with { title = "Advanced C#", price = 699.99 };

        // Printing first object
        Console.WriteLine("First Book:");
        Console.WriteLine(book1);

        // Deconstructing second object
        var (title, author, price) = book2;

        Console.WriteLine("\nSecond Book (Deconstructed):");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}
