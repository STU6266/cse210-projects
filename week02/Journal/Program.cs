using System; // Importiert grundlegende Funktionen, z.B. für die Konsolenein- und -ausgabe.

/// <summary>
/// Die Hauptklasse des Programms, welche die Benutzerinteraktion steuert.
/// Sie stellt ein einfaches Menü bereit, mit dem der Benutzer Journaleinträge erstellen, anzeigen, speichern und laden kann.
/// </summary>
class Program
{
    /// <summary>
    /// Der Einstiegspunkt der Anwendung.
    /// Eine Endlosschleife (bis der Benutzer "Quit" wählt) zeigt ein Menü und reagiert auf Benutzereingaben.
    /// </summary>
    /// <param name="args">Kommandozeilenargumente (in diesem Fall nicht genutzt).</param>
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // Erzeugt ein neues Journal, in dem alle Einträge gespeichert werden.
        bool run = true; // Steuert die Ausführung der Hauptschleife.
        while (run)
        {
            // Anzeige des Menüs für den Benutzer.
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load Entries");
            Console.WriteLine("4. Save Entries");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine(); // Liest die Benutzereingabe.

            // Auswahl anhand der Eingabe.
            switch (input)
            {
               case "1":
                    // Erzeugen eines neuen Eintrags.
                    // Setzt das Datum des Eintrags auf das aktuelle Datum im Format "yyyy-MM-dd".
                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    // Generiert einen zufälligen Prompt, der den Benutzer zum Schreiben anregen soll.
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine("Prompt: " + promptText);

                    // Fordert den Benutzer auf, weitere Details des Eintrags einzugeben.
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Mood: ");
                    string mood = Console.ReadLine();

                    Console.Write("Enter Tags (comma separated): ");
                    string tags = Console.ReadLine();

                    Console.Write("Enter Location: ");
                    string location = Console.ReadLine();

                    Console.Write("Write your entry: ");
                    string entryText = Console.ReadLine();

                    // Erstellt einen neuen Entry und weist alle eingegebenen Werte zu.
                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _title = title,
                        _promptText = promptText,
                        _entryText = entryText,
                        _mood = mood,
                        _tags = tags,
                        _location = location
                    };
                    journal.AddEntry(newEntry); // Fügt den neuen Eintrag dem Journal hinzu.
                    break;
                case "2":
                    // Zeigt alle im Journal gespeicherten Einträge an.
                    journal.DisplayAll();
                    break;
                case "3":
                    // Lädt Einträge aus einer Datei.
                    Console.Write("Enter the file name to load: ");
                    string fileToLoad = Console.ReadLine();
                    journal.LoadFromFile(fileToLoad);
                    break;
                case "4":
                    // Speichert die aktuellen Einträge in eine Datei.
                    Console.Write("Enter the file name to save: ");
                    string fileToSave = Console.ReadLine();
                    journal.SaveToFile(fileToSave);
                    break;
                case "5":
                    // Beendet die Schleife und somit das Programm.
                    run = false;
                    break;
                default:
                    // Informiert den Benutzer über ungültige Eingaben.
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
