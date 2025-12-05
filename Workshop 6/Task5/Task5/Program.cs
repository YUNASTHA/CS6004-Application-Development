using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // AGGREGATION OPERATORS (Cashier Sales)
        List<CashierSales> salesList = new List<CashierSales>
        {
            new CashierSales("Yuna", 15000),
            new CashierSales("Sarina", 12000),
            new CashierSales("Bristi", 9000),
            new CashierSales("Safala", 18000)
        };

        int totalCashiers = salesList.Count();
        double totalSales = salesList.Sum(s => s.Sales);
        double highestSales = salesList.Max(s => s.Sales);
        double lowestSales = salesList.Min(s => s.Sales);
        double averageSales = salesList.Average(s => s.Sales);

        Console.WriteLine("AGGREGATION OPERATORS");
        Console.WriteLine("Total Cashiers: " + totalCashiers);
        Console.WriteLine("Total Sales of the Day: Rs." + totalSales);
        Console.WriteLine("Highest Sales: Rs." + highestSales);
        Console.WriteLine("Lowest Sales: Rs." + lowestSales);
        Console.WriteLine("Average Sales: Rs." + averageSales);

        // QUANTIFIER OPERATORS (Applicants)
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant("Sangam", 17),
            new Applicant("Aditee", 19),
            new Applicant("Deepika", 22),
            new Applicant("Silviya", 16)
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("\nQUANTIFIER OPERATORS");
        Console.WriteLine("Any applicant under 18? " + anyUnder18);
        Console.WriteLine("Are all applicants above 16? " + allAbove16);

        // ELEMENT OPERATORS (Music App)
        List<Music> songs = new List<Music>
        {
            new Music("Song A", 180),
            new Music("Song B", 250),
            new Music("Song C", 320),
            new Music("Song D", 400)
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(s => s.Duration > 240);
        var safeLongSong = songs.FirstOrDefault(s => s.Duration > 600);

        Console.WriteLine("\nELEMENT OPERATORS");
        Console.WriteLine("First Song: " + firstSong.Title);
        Console.WriteLine("Last Song: " + lastSong.Title);
        Console.WriteLine("First Song > 4 Minutes: " + firstAbove4Min.Title);

        if (safeLongSong != null)
            Console.WriteLine("First Song > 10 Minutes: " + safeLongSong.Title);
        else
            Console.WriteLine("First Song > 10 Minutes: No such song found safely.");
    }
}