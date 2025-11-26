class Program
{
    static void Main(string[] args)
    {
        // Car object
        Car car = new Car();
        car.Brand = "Vulvo";
        car.Speed = 120;
        car.Seats = 5;

        // Motorcycle object
        Motorcycle moto = new Motorcycle();
        moto.Brand = "Yamaha";
        moto.Speed = 80;
        moto.HasCarrier = true;

        // Demonstrating reusability of base class methods
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        moto.Start();
        moto.DisplayInfo();
        moto.Stop();
    }
}
