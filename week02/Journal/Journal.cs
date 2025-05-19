using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    // Constructor to initiatelize the entries List
    public Journal()
    {
        _entries = new List<Entry>();

    }

    // Add an entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all entries in the journal 
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty. Try adding some entries first!");
            return;
        }

        {
            Console.WriteLine("\n==== Journal Entries ====");

            foreach (Entry entry in _entries)
            {
                entry.Display();
            }

        }

    }

    // Save the journal to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.GetAsCSV());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    // Load the journal from a file
    public void LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                // Clear existing entries
                _entries.Clear();

                // Read all lines from the file
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Entry entry = Entry.CreateFromCSV(line);
                    _entries.Add(entry);
                }

                Console.WriteLine($"Loaded {_entries.Count} entries.");
            }
            else
            {
                Console.WriteLine($"File {filename} not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

}