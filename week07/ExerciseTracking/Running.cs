


public class Running : Activity
{
    private double distance;
    private double speed;
    private double pace;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
        this.speed = GetSpeed();
        this.pace = GetPace();
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (base.Duration / 60.0);
    }

    public override double GetPace()
    {
        return (base.Duration / distance);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running {GetDistance():0.00} km, Speed: {GetSpeed():0.0} km/h, Pace: {GetPace():0.00} min/km";
    }
}