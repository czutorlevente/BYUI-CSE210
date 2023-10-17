using System;
using System.Diagnostics;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal_1 in _goals)
        {
            Console.WriteLine(goal_1.GetDetailString());
        }
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i]}");
        }
    }

    public void CreateGoal()
    {
        Console.Write("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich typle of goal would you like to create? ");
        string response = Console.ReadLine();
        Console.Write("\nWhat is the name of your goal? ");
        string newName = Console.ReadLine();
        Console.Write("\nWhat is a short description of it? ");
        string newDesc = Console.ReadLine();
        Console.Write("\nWhat is the amount of point associated with this goal? ");
        int newPoint = int.Parse(Console.ReadLine());

        if (response == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(newName, newDesc, newPoint);
            _goals.Add(newGoal);
        }

        else if (response == "2")
        {
            EternalGoal newGoal = new EternalGoal(newName, newDesc, newPoint);
            _goals.Add(newGoal);
        }

        else
        {
            Console.Write("\nHow many times does this goal need to be accomplished for bonus ?");
            int newTarget = int.Parse(Console.ReadLine());
            Console.Write($"\nWhat is the bonus for accomplishing it {newTarget} times? ");
            int newBonus = int.Parse(Console.ReadLine());
            CheckListGoal newGoal = new CheckListGoal(newName, newDesc, newPoint, newTarget, newBonus);
            _goals.Add(newGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you complete? ");
        int compl_1 = int.Parse(Console.ReadLine());
        int _score1 = _goals[compl_1].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {_score1} points!");
        _score = _score + _score1;
        Console.WriteLine($"You have {_score} points.");
    }
}