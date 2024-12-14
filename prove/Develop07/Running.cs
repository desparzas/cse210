public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / getMinutes()) * 60;
    }
    public override double GetPace()
    {
        return getMinutes() / _distance;
    }
}