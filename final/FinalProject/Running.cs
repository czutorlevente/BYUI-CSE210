using System;

class Running : Exercise
{
    private string _speed;
    private int _duration;

    public Running(string speed, int duration, string name, string description, int count) : base(name, description, "R", count)
    {
        _speed = speed;
        _duration = duration;
    }

    public Running(string name, string description) : base(name, description, "R", 0)
    {
        _speed = "10 m/h";
        _duration = 10;
    }

    public override string StringToSave()
    {
        return $"R:{base._name}*{base._description}*{_speed}*{_duration}*{base._count}";
    }

    public override string GetCurrentLevel()
    {
        return $"Current level: {_duration} at {_speed}";
    }

    public override void ChangeLevel()
    {
        Console.WriteLine("What is the new speed? ");
        _speed = Console.ReadLine();
        Console.WriteLine("What is the new duration in minutes? ");
        _duration = int.Parse(Console.ReadLine());
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nThe new level: {_duration} at {_speed}");

    }
}