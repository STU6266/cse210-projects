using System;

public class Entry
{
    public string _date;
    public string _title;
    public string _promptText;
    public string _entryText;
    public string _mood;
    public string _tags;
    public string _location;

    public void Display()
    {
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Entry: " + _entryText);
        Console.WriteLine("Mood: " + _mood);
        Console.WriteLine("Tags: " + _tags);
        Console.WriteLine("Location: " + _location);
    }
}
