public class Laptop : ElectronicDevice
{
    // Constructor
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    // Extra method
    public void TurnOnBattery()
    {
        Console.WriteLine("Laptop battery is now ON.");
    }

    // Overriding abstract method
    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
    }
}
