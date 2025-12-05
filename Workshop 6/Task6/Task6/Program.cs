using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
      
        // List of Tour Bookings

        List<TourBooking> bookings = new List<TourBooking>
        {
            new TourBooking("Junu", "Switzerland", 35000, 4, true),
            new TourBooking("Yuna", "Maldives", 25000, 6, true),
            new TourBooking("Sangam", "Mustang", 19000, 5, false),
            new TourBooking("Aditee", "India", 20000, 7, true),
            new TourBooking("Deepika", "Kathmandu", 12000, 4, false),
            new TourBooking("Sakshi", "Bali", 45000, 5, true)
        };



        var summaryReport = bookings
       
            .Where(b => b.Price > 10000 && b.DurationInDay > 4)

            
            .Select(b => new TourSummary
            {
                CustomerName = b.CustomerName,
                Destination = b.Destination,
                Category = b.IsInternational ? "International" : "Domestic",
                Price = b.Price
            })

            
            .OrderBy(s => s.Category == "International")

           
            .ThenBy(s => s.Price)
            .ToList();

       
        // Displaying Output in clean format


        Console.WriteLine("===== TOUR SUMMARY REPORT =====\n");

        foreach (var item in summaryReport)
        {
            Console.WriteLine($"Customer Name : {item.CustomerName}");
            Console.WriteLine($"Destination   : {item.Destination}");
            Console.WriteLine($"Category      : {item.Category}");
            Console.WriteLine($"Price         : Rs. {item.Price}");
            Console.WriteLine("--------------------------------");
        }
    }
}
