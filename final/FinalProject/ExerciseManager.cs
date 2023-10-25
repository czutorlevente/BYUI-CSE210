using System;
using System.Diagnostics;

class ExerciseManager
{
    private List<Exercise> _exercises = new List<Exercise>();

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
            _exercises.Add(exercise);
        }

        else if (response == "2")
        {
            BodyWeight exercise = new BodyWeight(name, descr);
            _exercises.Add(exercise);
        }

        else if (response == "3")
        {
            Running exercise = new Running(name, descr);
            _exercises.Add(exercise);
        }

        else if (response == "4")
        {
            Swimming exercise = new Swimming(name, descr);
            _exercises.Add(exercise);
        }

        else
        {
            Cardio exercise = new Cardio(name, descr);
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
                Cardio cardio = new Cardio(duration, _parameters[0], _parameters[1]);
                _exercises.Add(cardio);
            }

            else if (type == "BW")
            {
                int series = int.Parse(_parameters[2]);
                int reps = int.Parse(_parameters[3]);
                BodyWeight exercise = new BodyWeight(series, reps, _parameters[0], _parameters[1]);
                _exercises.Add(exercise);
            }

            else if (type == "R")
            {
                int duration = int.Parse(_parameters[3]);
                Running exercise = new Running(_parameters[2], duration, _parameters[0], _parameters[1]);
                _exercises.Add(exercise);
            }

            else if (type == "S")
            {
                int laps = int.Parse(_parameters[2]);
                Swimming exercise = new Swimming(laps, _parameters[0], _parameters[1]);
                _exercises.Add(exercise);
            }

            else if (type == "W")
            {
                int series = int.Parse(_parameters[2]);
                int reps = int.Parse(_parameters[3]);
                int weight = int.Parse(_parameters[4]);
                WeightLifting exercise = new WeightLifting(_parameters[0], _parameters[1], weight, series, reps, _parameters[5]);
                _exercises.Add(exercise);
            }
        }
    }
}