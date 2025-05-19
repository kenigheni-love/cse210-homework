using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    // Constructor that takes promptText and entryText
    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptText;
        _entryText = entryText;
    }

    // Constructor with explicit date
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    
    // Display the entry details
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    // Get the entry as a csv string for saving the file{
    public string GetAsCSV()
    {
        // Using ~/~ as a seperator to avoid issues with commas in text
        return $"{_date}~/~{_promptText}~/~{_entryText}";
    }

    // Create an Entry object from CSV data
    public static Entry CreateFromCSV(string csvData)
    {
        string[] parts = csvData.Split("~/~");

        if (parts.Length >= 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }

        // Return an invalid entry if the format is wrong
        return new Entry("Invalid Date", "Invalid Prompt", "Invalid Entry");
    }
    
        
}