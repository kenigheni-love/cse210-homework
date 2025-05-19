using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

    string grade  = "";

    if (percent >= 90)
    {
        grade = "A";
    } else if (percent >= 80)
    {
        grade = "B";
    } else if (percent >= 70)
    {
        grade = "C";
    } else if (percent >= 60)
    {
        grade = "D";
    } else
    {
        grade = "F";
    }

    Console.WriteLine($"Your grade is: {grade}");
    
    if (percent >= 70)
    {
        Console.WriteLine("Congratulations! You passed!");
    }
    else 
    {
        Console.WriteLine("Sorry, you didn't make it. Goodluck on your next try.");
    }

    }

    
}