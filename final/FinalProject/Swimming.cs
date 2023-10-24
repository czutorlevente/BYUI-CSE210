using System;

class Swimming : Exercise
{
    private int _laps;

    public Swimming(int laps, string name, string description, int points) : base(name, description, points)
    {
        _laps = laps;
    }

    public Swimming(string name, string description, int points) : base(name, description, points)
    {
        _laps = 10;
    }

    public override string StringToSave()
    {
        return $"BW:{base._name},{base._descripton},{base._points},{_laps}";
    }

    public override string GetCurrentLevel()
    {
        return $"Current level: {_laps} laps of {base._name}";
    }
    public override void ChangeLevel()
    {
        Console.WriteLine("How many laps do you want to do in the future? ");
        _laps = int.Parse(Console.ReadLine());
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nNew level: {_laps} laps of {base._name}");

    }
}