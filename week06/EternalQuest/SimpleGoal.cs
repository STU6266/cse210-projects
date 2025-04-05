

public class SimpleGoal : Goal
{
    private bool _isCompliete;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isCompliete = false;
    }
    public override void RecordEvent()
    {
        _isCompliete = true;
    }
    public override bool IsComplete()
    {
        return _isCompliete;
    }
    public override string GStringRepresentation()
    {
        throw new NotImplementedException();
    }
    
}
