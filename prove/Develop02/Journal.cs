using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {   string filename = file;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {file}");
    }
    public void LoadFromFile(string file)
    {   Console.WriteLine("Reading list from file...");
        string filename = file;
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
