public class Calculator
{
    // Creating the void method
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Creating the add method
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Multiply method with optional parameter
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
