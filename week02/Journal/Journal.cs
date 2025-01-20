// This class manages a journal where you can add, display, save, and load entries.  
// Entries include a date, a prompt (question), and a response.  
// It uses a list to store entries and saves or loads them from a file.  

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>(); 

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString()); 
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date + "|" + entry._prompt + "|" + entry._response);
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {

        //In this part of the code I make sure that it returns a message if the file does not exist.
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        // This clears the "_entries" list to ensure no previous data remains before loading new entries from the file.
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        // Each line is split into parts using the "|" character as a separator.
        // The first part is set as the date and the second and third parts as the prompt and response.
        // The Entry object is added to the `entries` list.

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2]);
                entry._date = parts[0];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}

