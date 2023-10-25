using System;

class WeightLifting : Exercise
{
    private int _weight;
    private int _series;
    private int _repetition;
    private string _unit;

    public WeightLifting(string name, string description, int weight, int series, int reps, string unit, int count) : base(name, description, "W", count)
    {
        _weight = weight;
        _series = series;
        _repetition = reps;
        _unit = unit;
    }

    public WeightLifting(string name, string description) : base(name, description, "W", 0)
    {
        _weight = 10;
        _series = 3;
        _repetition = 10;
        _unit = "kg";
    }

    public override string StringToSave()
    {
        return $"W:{base._name}*{base._description}*{_series}*{_repetition}*{_weight}*{_unit}*{base._count}";
    }

    public override string GetCurrentLevel()
    {
        return $"{_series}x{_repetition}, {_weight} {_unit}";
    }

    public override void ChangeLevel()
    {
        Console.WriteLine("What is the new number of series? ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _series = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("What is the new number of repetitions in each series? ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _repetition = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("What is the new unit of weight? ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _unit = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"What is the new weight amount in {_unit}? ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _weight = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nThe new level: {_series}x{_repetition}, {_weight} {_unit}");

    }
}