using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("This is Exercise 3 of Week 1.");

        string response = "yes";

        while (response.ToLower() == "yes")
        {
            Console.Write("Do you want to continue? (yes/no): ");
            response = Console.ReadLine();
        }

        string response2;

        do
        {
            Console.Write("Do you want to continue? (yes/no): ");
            response2 = Console.ReadLine();
        } while (response.ToLower() == "yes");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        string[] colors = { "Red", "Green", "Blue", "Yellow", "Purple"};
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine($"Random number between 1 and 100: {number}");
    }
}