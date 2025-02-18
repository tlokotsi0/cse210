using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _type = "EternalGoal";
        _lastRecordedDate = DateTime.Now;
    }

    public override void RecordEvent()
    {
       
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} [Eternal]";
    }

    public override string GetStringRepresentation()
    {
         return $"{_type}:{_shortName},{_description},{_points}";
    }

}