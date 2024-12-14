public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return _isComplete ? $"[X] {_shortName}: {_description}" : base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    public override string ToSaveString()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
    }

    // getters and setters

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}