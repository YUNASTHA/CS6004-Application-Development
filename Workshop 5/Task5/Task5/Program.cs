using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating ElectronicsStore object
        ElectronicsStore store = new ElectronicsStore();

        // Creating Laptop and Smartphone objects
        Laptop laptop = new Laptop("Acer Aspire 5", 80000);
        Smartphone phone = new Smartphone("Iphone 15 pro max", 150000);

        // Adding devices to the store
        store.AddDevice(laptop);
        store.AddDevice(phone);

        // Displaying all device details
        store.ShowAllDeviceDetails();
    }
}
