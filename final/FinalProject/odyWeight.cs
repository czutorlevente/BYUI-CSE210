using System;

class BodyWeight : Exercise
{
    private int _series;
    private int _repetition;

    public BodyWeight(int series, int reps, string name, string description, int points) : base(name, description, points)
    {
        _series = series;
        _repetition = reps;
    }

    public BodyWeight(string name, string description, int points) : base(name, description, points)
    {
        _series = 3;
        _repetition = 10;
    }

    public override string StringToSave()
    {
        return $"BW:{base._name},{base._descripton},{base._points},{_series},{_repetition}";
    }

    public override string GetCurrentLevel()
    {
        return $"Current level: {_series}x{_repetition}";
    }
    public override void ChangeLevel()
    {
        Console.WriteLine("What is the new number of series? ");
        _series = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the new number of repetitions in each series? ");
        _repetition = int.Parse(Console.ReadLine());
        Motivation mot = new Motivation();
        mot.ShowSpinner(5);
        Console.WriteLine($"\nThe new level: {_series}x{_repetition}");
    }
}