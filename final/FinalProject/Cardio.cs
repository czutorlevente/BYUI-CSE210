using System;

class Cardio : Exercise
{
    private int _duration;

    public Cardio(int duration, string name, string description, int count) : base(name, description, "CA", count)
    {
        _duration = duration;
    }

    public Cardio(string name, string description) : base(name, description, "CA", 0)
    {
        _duration = 10;
    }

    public override string StringToSave()
    {
        return $"CA:{base._name}*{base._description}*{_duration}*{base._count}";
    }

    public override string GetCurrentLevel()
    {
        return $"Current level: {base._name} for {_duration} minutes";
    }

    public override void ChangeLevel()
    {
        Console.WriteLine("How long (in minutes) do you want to do this cardio exercise next time? ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _duration = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nNew level: {base._name} for {_duration} minutes");

    }
}