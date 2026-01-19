using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine($"Default: {f1.GetFractionString()} -> {f1.GetDecimalValue()}");

        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Single Parameter: {f2.GetFractionString()} -> {f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine($"Two Parameters: {f3.GetFractionString()} -> {f3.GetDecimalValue()}");

        Fraction f4 = new Fraction(3, 4);
        Console.WriteLine($"Original: {f4.GetFractionString()}");

        f4.Numerator = 1;
        f4.Denominator = 3;
        Console.WriteLine($"Changed: {f4.GetFractionString()} -> {f4.GetDecimalValue()}");

        Console.WriteLine($"Numerator: {f4.Numerator}, Denominator: {f4.Denominator}");
    }
}