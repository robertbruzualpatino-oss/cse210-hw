using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Alice", "Math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Bob", "Math", "5.1", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Charlie", "English", "The Great Gatsby");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}