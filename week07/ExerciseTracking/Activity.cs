using System;
using System.Runtime.CompilerServices;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(int minutes)
    {
        _date = DateTime.Now;
        _minutes = minutes;
    }

    public DateTime GetDateTime()
    {
        return _date;
    }

    public int GetMinute()
    {
        return _minutes;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance()} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}