class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer();

        // Calling overloaded methods
        p.Print("Hi, It's me Yuna Shrestha");
        p.Print(0221);
        p.Print("Repeat this", 5);
    }
}
