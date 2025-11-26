using System;

public abstract class ElectronicDevice
{
    // Private fields
    private string brand;
    private double price;

    // Public properties for encapsulation
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Abstract method
    public abstract void ShowInfo();



    // Constructor to initialize fields
    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }
}
