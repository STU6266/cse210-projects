public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int duration, int speed) : base(date, duration)
    {
        this.speed = speed;
    }
    
    public override double GetDistance()
    {
        return speed * (Duration / 60.0);
    }
    
    public override double GetSpeed()
    {
        return speed;
    }
    
    public override double GetPace()
    {
        double distance = GetDistance();
        if(distance == 0) return 0;
        return Duration / distance;
    }
    
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling {GetDistance():0.00} km, Speed: {GetSpeed():0.0} km/h, Pace: {GetPace():0.00} min/km";
    }
}
