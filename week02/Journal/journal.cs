using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add a new entry to the journal.
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all journal entries.
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is currently empty.");
            return;
        }

        Console.WriteLine("\nYOUR JOURNAL ENTRIES");
        Console.WriteLine("====================");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save journal entries using JSON.
    public void SaveToFile(string filename)
    {
        string json = JsonSerializer.Serialize(
            _entries,
            new JsonSerializerOptions { WriteIndented = true }
        );

        File.WriteAllText(filename, json);

        Console.WriteLine("Journal saved successfully!");
    }

    // Load journal entries from a JSON file.
    public void LoadFromFile(string filename)
    {
        string json = File.ReadAllText(filename);

        List<Entry> loadedEntries =
            JsonSerializer.Deserialize<List<Entry>>(json);

        if (loadedEntries == null)
        {
            throw new InvalidDataException(
                "The journal file does not contain valid entries."
            );
        }

        // Replace the current journal with loaded entries.
        _entries = loadedEntries;

        Console.WriteLine("Journal loaded successfully!");
    }
}