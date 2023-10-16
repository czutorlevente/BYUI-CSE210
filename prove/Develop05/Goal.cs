using System;

abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString()
    {
        if (IsComplete() == true)
        {
            return $"[x] {_shortName}: {_description}";
        }

        else
        {
            return $"[ ] {_shortName}: {_description}";
        }
    }
    public abstract string GetStringRepresentation();

}