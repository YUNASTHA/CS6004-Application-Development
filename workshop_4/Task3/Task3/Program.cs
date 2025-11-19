using System;

class Program
{
    static void Main()
    {
        ParameterDemo demo = new ParameterDemo();

        int num = 5;
        demo.Increase(ref num);
        Console.WriteLine("After Increase: " + num);

        demo.GetFullName(out string fullname);
        Console.WriteLine("Full Name: " + fullname);

        int sum = demo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine("SumAll: " + sum);
    }
}