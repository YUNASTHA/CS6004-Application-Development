using System;

class Program
{
    static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (int num in numbers)
        {
            if (condition(num))
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 5, 10, 12, 15, 20, 3, 8, 25 };

        // Print Only Even Numbers
        Console.WriteLine("Even Numbers:");
        ProcessNumbers(numbers, n => n % 2 == 0);

        // Print Only Numbers Greater Than 10
        Console.WriteLine("Numbers Greater Than 10:");
        ProcessNumbers(numbers, n => n > 10);
    }
}
