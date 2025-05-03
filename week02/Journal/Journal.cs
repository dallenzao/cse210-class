using System;
using System.Collections.Generic;

public class Journal
{
    // Properties
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Methods
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in _entries) // Iterate through each entry in the journal
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filePath)
    {
        var lines = new List<string> { "Date,PromptText,EntryText" }; // This acts as the header in the CSV file.
        foreach (var entry in _entries)
        {
            lines.Add($"\"{entry._date:yyyy-MM-dd}\",\"{entry._promptText}\",\"{entry._entryText}\"");
        }
        System.IO.File.WriteAllLines(filePath, lines);
    }

    public void LoadFromFile(string filePath)
    {
        if (System.IO.File.Exists(filePath)) // Check if the file exists
        {
            var lines = System.IO.File.ReadAllLines(filePath);
            _entries = new List<Entry>();
            for (int i = 1; i < lines.Length; i++) // Skip the header
            {
                var parts = lines[i].Split(new[] { "\",\"" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    var date = DateTime.Parse(parts[0].Trim('"'));
                    var promptText = parts[1].Trim('"');
                    var entryText = parts[2].Trim('"');
                    _entries.Add(new Entry(date, promptText, entryText));
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
