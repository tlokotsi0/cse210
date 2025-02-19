using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int minute, int laps) : base(minute)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double result = _laps * 50 / 1000 * 0.62;
        return result;
    }

    public override double GetSpeed()
    {
        double result = GetDistance() / GetMinute() * 60;
        return result;
    }

    public override double GetPace()
    {
        double result = GetMinute() / GetDistance();
        return result;
    }
}