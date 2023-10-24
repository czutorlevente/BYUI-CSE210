using System;

abstract class Exercise
{
    protected string _name;
    protected string _descripton;
    protected int _points;
    private int _wasEasyOrHard;

    public Exercise(string name, string description, int points)
    {
        _name = name;
        _descripton = description;
        _points = points;
        _wasEasyOrHard = 3;
    }

    public int RecordExercise()
    {
        Console.WriteLine("How was this exercise?\n1 - Easy. We need to make it harder.\n2 - Hard. We need to make it easier.\n3 - Exactly right. No need to change.\nType your answer (1, 2, or 3) ");
        _wasEasyOrHard = int.Parse(Console.ReadLine());
        if (_wasEasyOrHard == 1 || _wasEasyOrHard == 2)
        {
            Console.WriteLine(GetCurrentLevel());
            ChangeLevel();
        }


        return _points;
    }

    public abstract void ChangeLevel();
    public abstract string GetCurrentLevel();
    public abstract string StringToSave();


}