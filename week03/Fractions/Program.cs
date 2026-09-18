using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
         // Test Constructor 1 (default 1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test Constructor 2 (5 -> 5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test Constructor 3 (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Test Constructor 3 (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test Getters and Setters
        Console.WriteLine("\n--- Testing Getters and Setters ---");
        f1.SetTop(6);
        f1.SetBottom(7);
        Console.WriteLine($"Updated Top: {f1.GetTop()}");
        Console.WriteLine($"Updated Bottom: {f1.GetBottom()}");
        Console.WriteLine($"Updated Fraction String: {f1.GetFractionString()}");
    }
}