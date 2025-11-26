using System;

public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }


    // This method cannot be overridden (no 'virtual' keyword)
    public void SalaryInfo()
    {
        Console.WriteLine("This teacher earns a standard salary.");
    }
}
