public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) 
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        
        return _points;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName}: {_description} --- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public override string ToSaveString()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    // getters and setters

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
}