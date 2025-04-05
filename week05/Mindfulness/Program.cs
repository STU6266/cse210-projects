using System;

class Program
{
    static void Main(string[] args)
    {
    while (true)

    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Enter the number of your choice: ");
        int choice = int.Parse(Console.ReadLine());


        if (choice == 1)
        {
            
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Run();
        }
        else if (choice == 2)
        {

            ReflectingActivity reflectingActivity = new ReflectingActivity();
            reflectingActivity.Run();
        }
        else if (choice == 3)
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Run();
        }
        else if (choice == 4)
        {
            Console.WriteLine("Goodbye!");
           break;
        }
        else
        {
            Console.WriteLine("Invalid choice. Pleas try again.");
        }
    }   
 
    }
}