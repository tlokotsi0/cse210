using System;

public class Running : Activity
{
    private double _distance;

    public Running(int minutes, double distance) : base(minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double result = _distance / GetMinute() * 60;
        return result;
    }

    public override double GetPace()
    {
        double result = GetMinute() / _distance;
        return result;
    }
}