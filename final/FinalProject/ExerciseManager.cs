using System;
using System.Diagnostics;

class ExerciseManager
{
    private List<Exercise> _exercises = new List<Exercise>();

    public void Play()
    {
        bool _stop = false;
        while (!_stop)
        {
            Console.WriteLine("Options:\n1 - ADD NEW EXERCISE\n2 - LOAD EXERCISES\n3 - SAVE EXERCISES\n4 - SHOW CURRENT EXERCISES\n5 - RECORD COMPLETION OF EXERCISE\n \nType the number of choice (or push any other button to finish): ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                CreateNew();
            }

            else if (response == "2")
            {
                LoadExercises();
            }

            else if (response == "3")
            {
                SaveExercises();
            }

            else if (response == "4")
            {
                ShowAll();
            }

            else if (response == "5")
            {
                Console.WriteLine("Exercises:\n");
                ShowNames();
                Console.Write("Which one did you complete? Type number: ");
                int completed = int.Parse(Console.ReadLine());
                _exercises[completed].RecordExercise();
                

            }

            else
            {
               Console.WriteLine("Thank you for your time!");
               _stop = true;
            }

        }
    }

    public void ShowAll()
    {
        Console.WriteLine("You have the following exercises:");
        foreach (Exercise _exe in _exercises)
        {
            Console.WriteLine(_exe.GetReport());
        }

    }

    public void ShowNames()
    {
        int number = 0;
        foreach (Exercise exe in _exercises)
        {
            Console.WriteLine($"{number} - {exe.GetName()}");
            number = number + 1;
        }
    }

    public void CreateNew()
    {
        Console.WriteLine("What type of exercise do you want to create?\n1 - Weight lifting\n2 - Body weight\n3 - Running\n4 - Swimming\n5 - Other type of cardio\n \nType the number here: ");
        string response = Console.ReadLine();
        Console.Write("What is the name of this exercise? ");
        string name = Console.ReadLine();
        Console.Write("Describe the exercise with a few words: ");
        string descr = Console.ReadLine();

        if (response == "1")
        {
            WeightLifting exercise = new WeightLifting(name, descr);
            Console.WriteLine("\nThe default setting for this exercise is this:");
            Console.WriteLine(exercise.GetCurrentLevel());
            Console.Write("Type '1' if you want to make a change to it: ");
            string change = Console.ReadLine();

            if (change == "1")
            {
                exercise.ChangeLevel();
            }

            else
            {
                Console.WriteLine("Default exercise accepted.");
            }

            _exercises.Add(exercise);
        }

        else if (response == "2")
        {
            BodyWeight exercise = new BodyWeight(name, descr);
            Console.WriteLine("\nThe default setting for this exercise is this:");
            Console.WriteLine(exercise.GetCurrentLevel());
            Console.Write("Type '1' if you want to make a change to it: ");
            string change = Console.ReadLine();

            if (change == "1")
            {
                exercise.ChangeLevel();
            }

            else
            {
                Console.WriteLine("Default exercise accepted.");
            }
            _exercises.Add(exercise);
        }

        else if (response == "3")
        {
            Running exercise = new Running(name, descr);
            Console.WriteLine("\nThe default setting for this exercise is this:");
            Console.WriteLine(exercise.GetCurrentLevel());
            Console.Write("Type '1' if you want to make a change to it: ");
            string change = Console.ReadLine();

            if (change == "1")
            {
                exercise.ChangeLevel();
            }

            else
            {
                Console.WriteLine("Default exercise accepted.");
            }
            _exercises.Add(exercise);
        }

        else if (response == "4")
        {
            Swimming exercise = new Swimming(name, descr);
            Console.WriteLine("\nThe default setting for this exercise is this:");
            Console.WriteLine(exercise.GetCurrentLevel());
            Console.Write("Type '1' if you want to make a change to it: ");
            string change = Console.ReadLine();

            if (change == "1")
            {
                exercise.ChangeLevel();
            }

            else
            {
                Console.WriteLine("Default exercise accepted.");
            }
            _exercises.Add(exercise);
        }

        else
        {
            Cardio exercise = new Cardio(name, descr);
            Console.WriteLine("\nThe default setting for this exercise is this:");
            Console.WriteLine(exercise.GetCurrentLevel());
            Console.Write("Type '1' if you want to make a change to it: ");
            string change = Console.ReadLine();

            if (change == "1")
            {
                exercise.ChangeLevel();
            }

            else
            {
                Console.WriteLine("Default exercise accepted.");
            }
            _exercises.Add(exercise);
        }
    }

    public void SaveExercises()
    {
        Console.Write("What is the file name? ");
        string _filename = Console.ReadLine();
        using (StreamWriter _file = new StreamWriter(_filename))
        {
            foreach (Exercise _e in _exercises)
            {
                _file.WriteLine(_e.StringToSave());
            }
        }
    }

    public void LoadExercises()
    {
        Console.Write("What is the file name? ");
        string _filename = Console.ReadLine();
        string[] _lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in _lines)
        {
            string[] _part_1 = line.Split(":");
            string type = _part_1[0];
            string _part_2 = _part_1[1];
            string[] _parameters = _part_2.Split("*");

            if (type == "CA")
            {
                int duration = int.Parse(_parameters[2]);
                int count = int.Parse(_parameters[3]);
                Cardio cardio = new Cardio(duration, _parameters[0], _parameters[1], count);
                _exercises.Add(cardio);
            }

            else if (type == "BW")
            {
                int series = int.Parse(_parameters[2]);
                int reps = int.Parse(_parameters[3]);
                int count = int.Parse(_parameters[4]);
                BodyWeight exercise = new BodyWeight(series, reps, _parameters[0], _parameters[1], count);
                _exercises.Add(exercise);
            }

            else if (type == "R")
            {
                int duration = int.Parse(_parameters[3]);
                int count = int.Parse(_parameters[4]);
                Running exercise = new Running(_parameters[2], duration, _parameters[0], _parameters[1], count);
                _exercises.Add(exercise);
            }

            else if (type == "S")
            {
                int laps = int.Parse(_parameters[2]);
                int count = int.Parse(_parameters[3]);
                Swimming exercise = new Swimming(laps, _parameters[0], _parameters[1], count);
                _exercises.Add(exercise);
            }

            else if (type == "W")
            {
                int series = int.Parse(_parameters[2]);
                int reps = int.Parse(_parameters[3]);
                int weight = int.Parse(_parameters[4]);
                int count = int.Parse(_parameters[6]);
                WeightLifting exercise = new WeightLifting(_parameters[0], _parameters[1], weight, series, reps, _parameters[5], count);
                _exercises.Add(exercise);
            }
        }
    }
}