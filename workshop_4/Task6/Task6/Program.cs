using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks: ");
        string inputMarks = Console.ReadLine();

        Console.Write("Enter total: ");
        string inputTotal = Console.ReadLine();

        int marks, total;

        // Using TryParse
        bool isMarksValid = int.TryParse(inputMarks, out marks);
        bool isTotalValid = int.TryParse(inputTotal, out total);

        if (!isMarksValid || !isTotalValid)
        {
            Console.WriteLine("Invalid input! Please enter integers only.");
            return;
        }

        // BREAKPOINT 1
        double percentage = marks / total * 100;

        // BREAKPOINT 2
        Console.WriteLine("Percentage = " + percentage);
    }
}
