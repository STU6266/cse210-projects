using System; // Importiert grundlegende Klassen aus dem System-Namespace, z.B. für die Konsolenausgabe.

/// <summary>
/// Die Klasse Entry repräsentiert einen einzelnen Journaleintrag.
/// Jeder Eintrag enthält Informationen wie Datum, Titel, Prompt-Text, den eigentlichen Eintragstext, Stimmung, Tags und Standort.
/// </summary>
public class Entry
{
    // Die folgenden Felder speichern die Daten eines Journal-Eintrags.
    public string _date;        // Datum des Eintrags, typischerweise im Format "yyyy-MM-dd".
    public string _title;       // Überschrift oder Titel des Eintrags.
    public string _promptText;  // Der Prompt oder die Frage, die den Eintrag angeregt hat.
    public string _entryText;   // Der eigentliche Inhalt des Journaleintrags.
    public string _mood;        // Beschreibt die Stimmung beim Erstellen des Eintrags.
    public string _tags;        // Schlagwörter, die dem Eintrag zugeordnet sind (z.B. "persönlich, wichtig").
    public string _location;    // Der Standort, an dem der Eintrag geschrieben wurde.

    /// <summary>
    /// Die Methode Display gibt alle Informationen des Eintrags in der Konsole aus.
    /// Jede Zeile wird mit einer Beschreibung versehen, um die Daten klar zu kennzeichnen.
    /// </summary>
    public void Display()
    {
        // Ausgabe der einzelnen Felder. Die einfache Stringverkettung wird genutzt, um eine klare Formatierung zu erreichen.
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Entry: " + _entryText);
        Console.WriteLine("Mood: " + _mood);
        Console.WriteLine("Tags: " + _tags);
        Console.WriteLine("Location: " + _location);
    }
}
