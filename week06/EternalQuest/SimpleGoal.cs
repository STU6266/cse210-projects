public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    {
        _isCompleted = false;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description})";
    }

    public override string GetDetailsString()
    {
        return GetStringRepresentation();
    }

    public override string Serialize()
    {
        return $"SimpleGoal|{ShortName}|{Description}|{Points}|{_isCompleted}";
    }
}
