public class EternalGoal : Goal
{
    private int _eventCount = 0;

    public EternalGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        _eventCount++;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description})";
    }

    public override string GetDetailsString()
    {
        return GetStringRepresentation();
    }

    public override string Serialize()
    {
        return $"EternalGoal|{ShortName}|{Description}|{Points}|{_eventCount}";
    }
}
