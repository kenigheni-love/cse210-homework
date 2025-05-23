using System;

class Program
{
    static void Main(string[] args)
    {
        // Test 1 - using the default (no-parameter) constructor for 1/1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test 5 - using the one-parameter constructor for 5/1
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test 3/4 - using two-parameter constructor
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Test 1/3 - using two-parameter constructor 
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


        Console.WriteLine("\n--- Testing Getters and Setters ---");

        // Test getters and setters
        Fraction f5 = new Fraction();
        Console.WriteLine($"Original: {f5.GetFractionString()}");


        // Use setters to change values
        f5.SetTop(6);
        f5.SetBottom(7);

        // use getters to retrieve and display new values
        Console.WriteLine($"New top: {f5.GetTop()}");
        Console.WriteLine($"New bottom: {f5.GetBottom()}");
        Console.WriteLine($"New fraction: {f5.GetFractionString()}");
        Console.WriteLine($"New decimal: {f5.GetDecimalValue()}");
    }

    
}