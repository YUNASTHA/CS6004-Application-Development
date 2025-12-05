using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Selecting / Projection
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var squaredNumbers = numbers.Select(n => n * n).ToList();

        Console.WriteLine("Squared Numbers:");
        foreach (var num in squaredNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n");

        // 2. Filtering (Where)

        List<Book> books = new List<Book>
        {
            new Book("Java Programming", 750),
            new Book("Data Science", 1500),
            new Book("Web Development", 1200),
            new Book("C# Basics", 900)
        };

        var premiumBooks = books.Where(b => b.Price > 1000).ToList();

        Console.WriteLine("Premium Books (Price > Rs.1000):");
        foreach (var book in premiumBooks)
        {
            Console.WriteLine(book.Name + " - Rs." + book.Price);
        }

        Console.WriteLine();

        // 3. Sorting (OrderBy)

        List<Student> students = new List<Student>
        {
            new Student("Ramesh"),
            new Student("Aayush"),
            new Student("Suman"),
            new Student("Bikash"),
            new Student("Nisha")
        };

        var sortedStudents = students.OrderBy(s => s.Name).ToList();

        Console.WriteLine("Students Sorted Alphabetically (AAA Scholarship):");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}