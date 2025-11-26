public class Smartphone : ElectronicDevice
{
    // Constructor
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }

    
    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera is now enabled.");
    }

    // Overriding abstract method
    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone Brand: {Brand}, Price: {Price}");
    }
}
