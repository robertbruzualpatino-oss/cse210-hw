using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("This is Exercise 2 of Week 1.");

        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        int y = 2;

        if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }
        else if (x < y)
        {
            Console.WriteLine("x is less than y");
        }
        else
        {
            Console.WriteLine("x is equal to y");
        }
    }
}