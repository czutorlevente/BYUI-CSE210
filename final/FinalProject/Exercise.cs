using System;

abstract class Exercise
{
    protected string _name;
    protected string _description;
    private string _type;
    private int _wasEasyOrHard;
    protected int _count;


    public Exercise(string name, string description, string type, int count)
    {
        _name = name;
        _description = description;
        _wasEasyOrHard = 3;
        _type = type;
        _count = count;
    }

    public void RecordExercise()
    {
        Console.Clear();
        Console.Write("How was this exercise?\n1 - Easy. We need to make it harder.\n2 - Hard. We need to make it easier.\n3 - Exactly right. No need to change.\nType your answer (1, 2, or 3): ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        _wasEasyOrHard = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        if (_wasEasyOrHard == 1 || _wasEasyOrHard == 2)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{GetCurrentLevel()}\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            ChangeLevel();
        }
        _count = _count + 1;
    }

    public string GetReport()
    {
        if (_count == 0)
        {
            return $"{_name}: {_description} --- {GetCurrentLevel()}\nNot yet completed\n";
        }

        else if (_count == 1)
        {
            return $"{_name}: {_description} --- {GetCurrentLevel()}\nCompleted once\n";
        }
        else
        {
            return $"{_name}: {_description} --- {GetCurrentLevel()}\nCompleted {_count} times\n";
        }
    }

    public string GetName()
    {
        return _name;
    }

    public abstract void ChangeLevel();
    public abstract string GetCurrentLevel();
    public abstract string StringToSave();


}