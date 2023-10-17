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
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"Congratulations! You have earned {_score1} points!");
        ShowSpinner(3);
        Console.ResetColor();
        _score = _score + _score1;
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal g1 in _goals)
            {
                if (g1.IsComplete() == true)
                {
                    outputFile.WriteLine($"{g1.GetStringRepresentation()}:1");
                }
                else
                {
                    outputFile.WriteLine($"{g1.GetStringRepresentation()}:0");
                }
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        int index = 0;
        foreach (string line in lines)
        {
            if (index == 0)
            {
                _score = int.Parse(line);
            }
            else if (index > 0)
            {
                string[] parts = line.Split(":");

                string _goalType = parts[0];
                string _details = parts[1];
                string _isComplete = parts[2];

                string[] parts_2 = _details.Split(",");

                if (_goalType == "SimpleGoal")
                {
                    SimpleGoal newGoal = new SimpleGoal(parts_2[0], parts_2[1], int.Parse(parts_2[2]));
                    if (_isComplete == "1")
                    {
                        newGoal.SetComplete();
                    }
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
            index++;
        }


    }

    public void Start()
    {
        bool _stop = false;

        while (!_stop)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"\nYou have {_score} points.");
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Menu options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\n");
            Console.ResetColor();
            Console.Write("Select a choice from the menu: ");
            string _choice = Console.ReadLine();
            Console.ResetColor();

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

    List<string> spinlist = new List<string>{"|", "/", "-", "\\"};
    
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinlist[i];
            Console.Write(s);
            Thread.Sleep(170);
            Console.Write("\b \b");
            i++;

            if (i >= spinlist.Count)
            {
                i = 0;
            }
        }
    }
}