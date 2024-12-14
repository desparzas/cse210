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
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")}"+
        $"{this.GetType().Name} ({_minutes} min)- "+
        $"Distance {GetDistance():F1} miles, "+
        $"Speed {GetSpeed():F1} mph, "+
        $"Pace: {GetPace():F1} min per mile";
    }
    public DateTime getDate()
    {
        return _date;
    }
    public void setDate(DateTime date)
    {
        _date = date;
    }
    public int getMinutes()
    {
        return _minutes;
    }
    public void setMinutes(int minutes)
    {
        _minutes = minutes;
    }
}
