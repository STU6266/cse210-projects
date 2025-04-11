public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }
    
    public override double GetDistance()
    {
        return laps * 50 / 1000.0;
        
    }
    
    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60.0;
    }
    
    public override double GetPace()
    {
        double distance = GetDistance();
        if(distance == 0) return 0;
        return Duration / distance;
    }
    
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming {GetDistance():0.00} km, Speed: {GetSpeed():0.0} km/h, Pace: {GetPace():0.00} min/km, Laps: {laps}";
    }
}
