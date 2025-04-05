
public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
    "Breathing",
    "This activity wil help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
    0)
{
}


    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now <  endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);


            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
        }

        DisplayEndMessage();
    }


}


