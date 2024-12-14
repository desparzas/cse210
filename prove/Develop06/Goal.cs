public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string ToSaveString();

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }

    public abstract string GetStringRepresentation();

    // getters and setters
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public override string ToString()
    {
        return $"{_shortName}: {_description}";
    }
}
