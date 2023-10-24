using System;

class WeightLifting : Exercise
{
    private int _weight;
    private int _series;
    private int _repetition;
    private string _unit;

    public WeightLifting(string name, string description, int points, int weight, int series, int reps, string unit) : base(name, description, points)
    {
        _weight = weight;
        _series = series;
        _repetition = reps;
        _unit = unit;
    }

    public WeightLifting(string name, string description, int points) : base(name, description, points)
    {
        _weight = 10;
        _series = 3;
        _repetition = 10;
        _unit = "kg";
    }

    public override string StringToSave()
    {
        return $"BW:{base._name},{base._descripton},{base._points},{_series},{_repetition},{_weight},{_unit}";
    }

    public override string GetCurrentLevel()
    {
        return $"Current level: {_series}x{_repetition}, {_weight} {_unit}";
    }

    public override void ChangeLevel()
    {
        Console.WriteLine("What is the new number of series? ");
        _series = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the new number of repetitions in each series? ");
        _repetition = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the new unit of weight? ");
        _unit = Console.ReadLine();
        Console.WriteLine($"What is the new weight amount in {_unit}? ");
        _weight = int.Parse(Console.ReadLine());
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nThe new level: {_series}x{_repetition}, {_weight} {_unit}");

    }
}