using System;

class Cardio : Exercise
{
    private int _duration;

    public Cardio(int duration, string name, string description) : base(name, description, "CA")
    {
        _duration = duration;
    }

    public Cardio(string name, string description) : base(name, description, "CA")
    {
        _duration = 10;
    }

    public override string StringToSave()
    {
        return $"CA:{base._name}*{base._descripton}*{_duration}";
    }

    public override string GetCurrentLevel()
    {
        return $"Current level: {base._name} for {_duration} minutes";
    }

    public override void ChangeLevel()
    {
        Console.WriteLine("How long (in minutes) do you want to do this cardio exercise next time? ");
        _duration = int.Parse(Console.ReadLine());
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nNew level: {base._name} for {_duration} minutes");

    }
}