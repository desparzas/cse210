public abstract class Activity
{
    private DateTime _date;
    private int _minutes;
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
    protected DateTime GetDate()
    {
        return _date;
    }
    protected void SetDate(DateTime date)
    {
        _date = date;
    }
    protected int GetMinutes()
    {
        return _minutes;
    }
    protected void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }
}