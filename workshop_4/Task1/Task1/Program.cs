using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating the first object
        Student s1 = new Student();
        s1.name = "Yuna";
        s1.age = 20;
        s1.course = "BIT";

        // Creating the second object
        Student s2 = new Student();
        s2.name = "Sangam";
        s2.age = 22;
        s2.course = "BCA";

        // Display values of first object
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Course: " + s1.course);
        Console.WriteLine();

        // Displaying values of second object
        Console.WriteLine("Student 2 Details:");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Course: " + s2.course);
        Console.WriteLine();

        // Printing static field
        Console.WriteLine("College Name (Static Field): " + Student.collegeName);
    }
}
