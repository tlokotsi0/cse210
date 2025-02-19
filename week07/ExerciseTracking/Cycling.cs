using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(int minutes, double speed) : base(minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double result = _speed * GetMinute() / 60;
        return result;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double result = 60 / _speed;
        return result;
    }
}