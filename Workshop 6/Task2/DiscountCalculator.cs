using System;

// Delegate for Calculate (Add & Subtract)
public delegate int Calculate(int a, int b);

// Delegate for Discount Strategy
public delegate double DiscountStrategy(double price);

public class DiscountCalculator
{
    // Add & Subtract Methods 
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    //  Discount Methods 

    // 20% OFF
    public static double FestivalDiscount(double price)
    {
        return price * 0.80;
    }

    // 10% OFF
    public static double SeasonalDiscount(double price)
    {
        return price * 0.90;
    }

    // No Discount
    public static double NoDiscount(double price)
    {
        return price;
    }

    // 2.1 CalculateFinalPrice METHOD
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
    {
        return strategy(originalPrice);
    }
}
