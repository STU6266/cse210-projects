
using System.Threading;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration ;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);

        Console.WriteLine("How long, in seconds, would you like for your sesion?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"You have chosen a duration of {_duration} seconds.");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        
        Thread.Sleep(3000) ;
    }

    public void ShowSpinner(int seconds)
    {
       string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

    while (DateTime.Now < endTime)
    {
        Console.Write(spinner[i % spinner.Length]);
        Thread.Sleep(200);
        Console.Write("\b"); 
        i++;
    }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i );
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }  
    }
}
