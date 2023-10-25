using System;

class BodyWeight : Exercise
{
    private int _series;
    private int _repetition;

    public BodyWeight(int series, int reps, string name, string description, int count) : base(name, description, "BW", count)
    {
        _series = series;
        _repetition = reps;
    }

    public BodyWeight(string name, string description) : base(name, description, "BW", 0)
    {
        _series = 3;
        _repetition = 10;
    }

    public override string StringToSave()
    {
        return $"BW:{base._name}*{base._description}*{_series}*{_repetition}*{base._count}";
    }

    public override string GetCurrentLevel()
    {
        return $"{_series}x{_repetition}";
    }
    public override void ChangeLevel()
    {
        Console.WriteLine("What is the new number of series? ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _series = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("What is the new number of repetitions in each series? ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _repetition = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Blue;
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nThe new level: {_series}x{_repetition}");
    }
}