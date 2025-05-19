using System;

class Program
{
    static void Main(string[] args)
    {
        // Call different functions to perform the program's tasks
        DisplayWelcomeMessage();

        // Get user's name and store it in a variable
        string userName = PromptUserName();


        // Get user's number and store it in a variable
        int userNumber = PromptUserNumber();

        // Calculate the square of the user's number
        int squaredNumber = SquareNumber(userNumber);

        // Display the final result to the user
        DisplayResult(userName, squaredNumber);

    }
    // Display a welcome message to the user
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");

    }
    // Ask for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Ask for and return user's favourite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favoorite number: ");
        // Convert the string into and integer
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    // Calculate the square of the givern number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    // Display the final result to the user
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
     
}