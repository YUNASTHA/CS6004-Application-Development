using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating object of Calculator
        Calculator calc = new Calculator();

        // Calling PrintWelcome
        calc.PrintWelcome();

        // Calling Add method
        int sum = calc.Add(30, 20);
        Console.WriteLine("Addition: " + sum);

        // Calling Multiply with two parameters
        int product1 = calc.Multiply(5, 4);
        Console.WriteLine("Multiplication (two numbers): " + product1);

        // Calling Multiply using default value of num2
        int product2 = calc.Multiply(7);
        Console.WriteLine("Multiplication (using default num2=1): " + product2);
    }
}
