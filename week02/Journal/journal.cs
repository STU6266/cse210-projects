using System;                   // Für grundlegende Funktionen wie Konsolenausgabe.
using System.Collections.Generic; // Für die Nutzung der List<T>-Klasse.
using System.IO;                // Für Dateioperationen (Lesen und Schreiben).

/// <summary>
/// Die Klasse Journal verwaltet eine Liste von Journal-Einträgen.
/// Sie bietet Methoden zum Hinzufügen, Anzeigen, Speichern und Laden von Einträgen.
/// </summary>
public class Journal
{
    public List<Entry> _Entries; // Liste, die alle Journaleinträge speichert.

    /// <summary>
    /// Konstruktor der Journal-Klasse.
    /// Initialisiert die Liste der Einträge.
    /// </summary>
    public Journal()
    {
        _Entries = new List<Entry>();
    }

    /// <summary>
    /// Fügt einen neuen Eintrag zur Liste hinzu.
    /// </summary>
    /// <param name="newEntry">Der hinzuzufügende Eintrag.</param>
    public void AddEntry(Entry newEntry)
    {
        _Entries.Add(newEntry);
    }
    
    /// <summary>
    /// Gibt alle gespeicherten Einträge in der Konsole aus.
    /// Jeder Eintrag wird einzeln angezeigt, gefolgt von einer Leerzeile.
    /// </summary>
    public void DisplayAll()
    {
        foreach (var entry in _Entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Speichert alle Einträge in eine Datei.
    /// Es wird eine CSV-Datei erstellt, wobei die erste Zeile die Header definiert.
    /// Die Verwendung von 'using' sorgt dafür, dass der StreamWriter nach Abschluss automatisch geschlossen wird.
    /// </summary>
    /// <param name="file">Der Dateiname, in den die Einträge gespeichert werden.</param>
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            // Schreibe die Kopfzeile (Header) mit den Feldnamen.
            writer.WriteLine("Date,Title,Prompt,Entry,Mood,Tags,Location");
            // Schreibe jeden Eintrag in einer neuen Zeile als CSV-Daten.
            foreach(var entry in _Entries)
            {
                writer.WriteLine($"{entry._date},{entry._title},{entry._promptText},{entry._entryText},{entry._mood},{entry._tags},{entry._location}");
            }
        }
        // Informiert den Benutzer über den erfolgreichen Speichervorgang.
        Console.WriteLine("Journal saved to " + file);
    }

    /// <summary>
    /// Lädt Einträge aus einer CSV-Datei.
    /// Überprüft zunächst, ob die Datei existiert. Falls ja, wird der Inhalt eingelesen.
    /// Die erste Zeile wird als Header übersprungen und jede weitere Zeile wird in die entsprechenden Felder zerlegt.
    /// </summary>
    /// <param name="file">Der Dateiname, aus dem die Einträge geladen werden sollen.</param>
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _Entries = new List<Entry>(); // Alte Einträge werden verworfen.
            using (StreamReader reader = new StreamReader(file))
            {
                // Lese die Kopfzeile (wird nicht weiter verwendet).
                string header = reader.ReadLine();
                string line;
                // Lies jede Zeile, bis das Dateiende erreicht ist.
                while ((line = reader.ReadLine()) != null)
                {
                    // Zerlegt die Zeile in 7 Teile anhand des Kommas.
                    string[] parts = line.Split(new char[] { ',' }, 7);
                    if (parts.Length == 7)
                    {
                        // Erstellt einen neuen Entry und weist die jeweiligen Teile zu.
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
            // Informiert den Benutzer, dass die Einträge erfolgreich geladen wurden.
            Console.WriteLine("Journal loaded from " + file);
        }
        else
        {
            // Meldung, falls die angegebene Datei nicht existiert.
            Console.WriteLine("File not found: " + file);
        }
    }
}
