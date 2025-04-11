using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Activity> activities = new List<Activity>();

       
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 5.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 4), 45, (int)20.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 5), 60, 30));

       
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}