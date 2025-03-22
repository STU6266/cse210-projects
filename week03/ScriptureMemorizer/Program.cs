using System;

class Program
{
    static void Main(string[] args)
    {
      
        Console.WriteLine("Please select the scripture you would like to learn:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. 1 Nephi 3:7");
        Console.WriteLine("3. Moses 1:39");

        Console.WriteLine("4. D&C 121:7-8");
        Console.Write("Enter the number of your choice: ");

        string choice = Console.ReadLine();
        
        Scripture scripture = null;
        
        switch (choice.Trim())
        {
            case "1":
                {
                    
                    Reference reference = new Reference("John", 3, 16);
                    string text = "For God so loved the world, that he gave his only begoten Son, that whosoever believet in him should not perish but have everlasting life.";
                   
                    scripture = new Scripture(reference, text);
                    break;
                }
            case "2":
                {
                    
                    Reference reference = new Reference("1 Nephi", 3, 7);
                    string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath comanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
                    scripture = new Scripture(reference, text);
                    break;
                }
            case "3":
                {
                    
                    Reference reference = new Reference("Moses", 1, 39);
                    string text = "For behold, this is my work and my glory—to bring to pass the immortality and eternal live of man.";
                    scripture = new Scripture(reference, text);
                    break;
                }
            case "4":
                {
                   
                    Reference reference = new Reference("D&C", 121, 7, 8);
                    string text = "7. My son, peace be unto thy soul; thine adversity and thine afflictions shall be a s mall moment; " +
                                  "8. And then, if thou endure it well, god shall exalt thee on high; thou shalt triumph over all thy foes.";
                    scripture = new Scripture(reference, text);
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid choice. Defaulting to John 3:16.");
                    Reference reference = new Reference("John", 3, 16);
                    string text = "For God so loved the world, that he gave his only begotten son, that whosoever believeth in him should not perish but have everlasting life.";
                    scripture = new Scripture(reference, text);
                    break;
                }
        }
        
       
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. The program will now exit.");

                break;

            }
            
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }
            
           
            scripture.HideRandomWord(3);
        }
    }
}
