

public abstract class Activity
{
   
    private DateTime date;
    protected int duration;

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    protected int Duration
    {
        get { return duration; }
    }
    

    
    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} ({duration} min):";
    }
}

