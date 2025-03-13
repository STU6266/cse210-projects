using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool run = true;
        while (run)
        {
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load Entries");
            Console.WriteLine("4. Save Entries");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                   
                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                   
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine("Prompt: " + promptText);

                 
                    Console.Write(">");
                    string entryText = Console.ReadLine();

                   
                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _promptText = promptText,
                        _entryText = entryText
                    };
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                 
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the file name to load: ");
                    string fileToLoad = Console.ReadLine();
                    journal.LoadFromFile(fileToLoad);
                    break;
                case "4":
                    Console.Write("Enter the file name to save: ");
                    string fileToSave = Console.ReadLine();
                    journal.SaveToFile(fileToSave);
                    break;
                case "5":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
