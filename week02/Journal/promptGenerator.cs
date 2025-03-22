using System;                   // Für grundlegende Funktionen, z.B. Random.
using System.Collections.Generic; // Für die Verwendung von List<T>.

/// <summary>
/// Die Klasse PromptGenerator stellt eine Sammlung von Eingabeaufforderungen (Prompts) bereit.
/// Der Zweck ist es, den Benutzer beim Schreiben von Journaleinträgen anzuregen, indem er zufällig eine Frage auswählt.
/// </summary>
public class PromptGenerator
{
    // Liste von vordefinierten Prompts. Diese Fragen regen zur Reflexion an und helfen dabei, den Eintrag zu strukturieren.
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What could I have done better?",
        "where did I see the hand of the Lord in my day?",
        "What can i learn from today?",
        "What was the hardest part of my day?",
    };

    /// <summary>
    /// Gibt einen zufälligen Prompt aus der Liste zurück.
    /// Dabei wird eine neue Instanz von Random erstellt, um einen zufälligen Index basierend auf der Anzahl der verfügbaren Prompts zu ermitteln.
    /// Hinweis: Die Instanziierung von Random innerhalb dieser Methode könnte bei sehr häufiger Nutzung zu gleichen Ergebnissen führen,
    /// da der Zufallszahlengenerator auf dem Systemzeitgeber basiert. In einer produktiven Umgebung könnte es sinnvoll sein, Random als statische Instanz zu verwenden.
    /// </summary>
    /// <returns>Ein zufällig ausgewählter Prompt als String.</returns>
    public string GetRandomPrompt()
    {
        Random random = new Random(); // Erstellt einen neuen Zufallszahlengenerator.
        int index = random.Next(_prompts.Count); // Bestimmt einen zufälligen Index zwischen 0 (inklusive) und der Anzahl der Prompts (exklusive).
        return _prompts[index]; // Gibt den Prompt am zufällig bestimmten Index zurück.
    }
}
