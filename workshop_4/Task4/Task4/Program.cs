using System;

class Program
{
    static void Main()
    {
        Player p1 = new Player();

        Player p2 = new Player("Christianio Ronaldo", 15, 200);

        Console.WriteLine("\nPlayer 2 Details:");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);
    }
}