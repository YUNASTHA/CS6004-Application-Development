public class Motorcycle : Vehicle
{
    public bool HasCarrier { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Has Carrier: {HasCarrier}");
    }
}
