public class Printer
{
    // 1. Printing string message
    public void Print(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    // 2. Printing integer number
    public void Print(int number)
    {
        Console.WriteLine("Number: " + number);
    }

    // 3. Printing string message multiple times
    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    }
}
