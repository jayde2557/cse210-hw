using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }


    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter output = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }


        }
    }



    public void SearchEntries(string keyword)
    {
        Console.WriteLine($"\nSearching for \"{keyword}\"...\n");

        foreach (Entry entry in _entries)
        {
            if (entry._promptText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry._entryText.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
            }
            else
            {
                Console.WriteLine($"No results for {keyword}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }

}
