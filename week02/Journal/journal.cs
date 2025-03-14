using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _Entries;

    public Journal()
    {
        _Entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _Entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (var entry in _Entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            
            writer.WriteLine("Date,Title,Prompt,Entry,Mood,Tags,Location");
            foreach(var entry in _Entries)
            {
                writer.WriteLine($"{entry._date},{entry._title},{entry._promptText},{entry._entryText},{entry._mood},{entry._tags},{entry._location}");
            }
        }
        Console.WriteLine("Journal saved to " + file);
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _Entries = new List<Entry>();
            using (StreamReader reader = new StreamReader(file))
            {
                
                string header = reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new char[] { ',' }, 7);
                    if (parts.Length == 7)
                    {
                        Entry entry = new Entry
                        {
                            _date = parts[0],
                            _title = parts[1],
                            _promptText = parts[2],
                            _entryText = parts[3],
                            _mood = parts[4],
                            _tags = parts[5],
                            _location = parts[6]
                        };
                        _Entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal loaded from " + file);
        }
        else
        {
            Console.WriteLine("File not found: " + file);
        }
    }
}
