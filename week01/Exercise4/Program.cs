using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("This is Exercise 4 of Week 1.");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<string> words = new List<string> { "apple", "banana", "cherry" };

        List<string> words2 = new List<string> { "apple", "banana", "cherry" };

        words.Add("date");
        words.Add("elderberry");
        words.Add("fig");

        Console.WriteLine(words.Count);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}