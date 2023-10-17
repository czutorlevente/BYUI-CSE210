using System;

class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public CheckListGoal(string name, string description, int points, int target, int bonus, int _done) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = _done;
    }

    public override int RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;
        int _toReturn = base._points;
        if (_amountCompleted == _target)
        {
            _toReturn = _toReturn + _bonus;
        }
        return base._points;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailString()
    {
        if (IsComplete() == true)
        {
            return $"[x] {_shortName}: {_description} --- Currently completed: {_amountCompleted}/{_target}";
        }

        else
        {
            return $"[ ] {_shortName}: {_description} --- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{base._shortName},{base._description},{base._points},{_bonus},{_amountCompleted},{_target}";
    }
}