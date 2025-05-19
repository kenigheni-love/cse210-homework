using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        bool quit = false;

        Console.WriteLine("Welcome to the Journal Program!");

        while (!quit)
        {
            // Display menu
            DisplayMenu();

            // Get user choice
            Console.WriteLine("What would you like to do?");
            string choice = Console.ReadLine();

            // Process user choice
            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal1);
                    break;
                case "2":
                    journal1.DisplayAll();
                    break;

                case "3":
                    journal1.SaveToFile("journal.text");
                    break;

                case "4":
                    journal1.LoadFromFile("journal.text");
                    break;

                case "5":
                    quit = true;
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
                    break;
            }

            // Add a blank line for readability 
            if (!quit)
            {
                Console.WriteLine();

            }
        }

    }
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the hournal from a file");
        Console.WriteLine("Load the journal from a file");
        Console.WriteLine("5. Quit");
    }

    static void WriteNewEntry(Journal journal)
    {
        Console.WriteLine("Enter a prompt for your journal entry");
        string prompt = Console.ReadLine();

        Console.WriteLine("Enter your journal entry:");
        string entryText = Console.ReadLine();
        
        Entry newEntry = new Entry(prompt, entryText);
        journal.AddEntry(newEntry);
        
        Console.WriteLine("Entry added successfully!");


    }
}
 