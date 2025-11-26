using System;
class Program
{
    static void Main(string[] args)
    {
        // Nepali teacher object
        NepaliTeacher nepali = new NepaliTeacher();
        nepali.Name = "Ram";
        Console.WriteLine("Name: " + nepali.Name);
        nepali.Teaching();
        nepali.SalaryInfo();

        Console.WriteLine();

        // English teacher object
        EnglishTeacher english = new EnglishTeacher();
        english.Name = "Sarah";
        Console.WriteLine("Name: " + english.Name);
        english.Teaching();  
        english.SalaryInfo();
    }
}
