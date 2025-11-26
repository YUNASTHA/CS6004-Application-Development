using System;
using System.Collections.Generic;

public class ElectronicsStore
{
    // Listing to store ElectronicDevice objects
    private List<ElectronicDevice> devices;

    // Constructor
    public ElectronicsStore()
    {
        devices = new List<ElectronicDevice>();
    }

    // Method to add a device
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine("Device added to the store.");
    }

    // Method to remove a device
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
        {
            Console.WriteLine("Device removed from the store.");
        }
        else
        {
            Console.WriteLine("Device not found in the store.");
        }
    }

    // Method to show all device details
    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n--- Device List ---");

        foreach (var device in devices)
        {
            device.ShowInfo(); // Polymorphism: calls overridden method

            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}

