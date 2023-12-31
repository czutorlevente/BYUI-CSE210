using System;

class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public void SetComplete()
    {
        _isComplete = true;
    }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return base._points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base._shortName},{base._description},{base._points}";
    }
}