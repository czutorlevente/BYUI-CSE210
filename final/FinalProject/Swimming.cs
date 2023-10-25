using System;

class Swimming : Exercise
{
    private int _laps;

    public Swimming(int laps, string name, string description, int count) : base(name, description, "S", count)
    {
        _laps = laps;
    }

    public Swimming(string name, string description) : base(name, description, "S", 0)
    {
        _laps = 10;
    }

    public override string StringToSave()
    {
        return $"S:{base._name}*{base._description}*{_laps}*{base._count}";
    }

    public override string GetCurrentLevel()
    {
        return $"Current level: {_laps} laps of {base._name}";
    }
    public override void ChangeLevel()
    {
        Console.WriteLine("How many laps do you want to do in the future? ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _laps = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nNew level: {_laps} laps of {base._name}");

    }
}