using System;
using System.Collections.Generic;
using System.IO;

public class Journal2
{
    public List<Entry2> _Entries;

    public Journal2()
    {
        _Entries = new List<Entry2>();
    }

    public void AddEntry(Entry2 newEntry)
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
            writer.WriteLine("Date,Prompt,Entry");
            foreach(var entry in _Entries)
            {
                
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved to " + file);
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _Entries = new List<Entry2>();
            using (StreamReader reader = new StreamReader(file))
            {
                
                string header = reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                   
                    string[] parts = line.Split(new char[] { ',' }, 3);
                    if (parts.Length == 3)
                    {
                        Entry2 entry = new Entry2
                        {
                            _date = parts[0],
                            _promptText = parts[1],
                            _entryText = parts[2]
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
