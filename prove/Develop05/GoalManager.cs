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
            Console.WriteLine($"{i}. {_goals[i].GetName()}");
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
            Console.Write("\nHow many times does this goal need to be accomplished for bonus? ");
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

    public void SaveGoals()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal g1 in _goals)
            {
                outputFile.WriteLine($"{g1.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string _goalType = parts[0];
            string _details = parts[1];

            string[] parts_2 = _details.Split(",");

            if (_goalType == "SimpleGoal")
            {
                SimpleGoal newGoal = new SimpleGoal(parts_2[0], parts_2[1], int.Parse(parts_2[2]));
                _goals.Add(newGoal);

            }

            else if (_goalType == "EternalGoal")
            {
                EternalGoal newGoal = new EternalGoal(parts_2[0], parts_2[1], int.Parse(parts_2[2]));
                _goals.Add(newGoal);

            }

            else if (_goalType == "CheckListGoal")
            {
                CheckListGoal newGoal = new CheckListGoal(parts_2[0], parts_2[1], int.Parse(parts_2[2]), int.Parse(parts_2[5]), int.Parse(parts_2[3]), int.Parse(parts_2[4]));
                _goals.Add(newGoal);
            }
        }


    }

    public void Start()
    {
        bool _stop = false;

        while (!_stop)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine($"Menu options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\n");
            Console.Write("Select a choice from the menu: ");
            string _choice = Console.ReadLine();

            if (_choice == "1")
            {
                CreateGoal();
            }

            else if (_choice == "2")
            {
                Console.WriteLine($"The goals are:");
                ListGoalDetails();
            }

            else if (_choice == "3")
            {
                SaveGoals();
            }

            else if (_choice == "4")
            {
               LoadGoals(); 
            }

            else if (_choice == "5")
            {
                RecordEvent();
            }

            else
            {
                Console.WriteLine($"\nThank you for your time!");
                _stop = true;
            }
        }
    }
}