using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _type = "ChecklistGoal";
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _type = "ChecklistGoal";
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonus;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
          return $"{_type}:{_shortName}: {_description} Completed {_amountCompleted} times your Goal is {_target}";
    }

    public override string GetStringRepresentation()
    {
          return $"{_type}:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}