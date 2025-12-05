using System;

class Program
{
    static void Main()
    {
        // PART 1: Calculate Delegate

        Calculate calc;

        calc = DiscountCalculator.Add;
        Console.WriteLine("Addition: " + calc(20, 10));

        calc = DiscountCalculator.Subtract;
        Console.WriteLine("Subtraction: " + calc(20, 10));

        // PART 2: Discount Strategies

        double originalPrice = 1000;
        Console.WriteLine("\nOriginal Price: " + originalPrice);

        Console.WriteLine("Festival Discount Price: " +
            DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.FestivalDiscount));

        Console.WriteLine("Seasonal Discount Price: " +
            DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.SeasonalDiscount));

        Console.WriteLine("No Discount Price: " +
            DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.NoDiscount));

        // 2.3 Lambda Expression (30% OFF)

        double lambdaPrice = DiscountCalculator.CalculateFinalPrice(1000, price => price * 0.70);
        Console.WriteLine("\nLambda 30% Discount Price: " + lambdaPrice);
    }
}
