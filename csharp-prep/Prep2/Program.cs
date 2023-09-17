using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string prompt = Console.ReadLine();
        int gradePrompt = int.Parse(prompt);

        string letter = "";

        if (gradePrompt >= 90)
        {
            letter = "A";
        }

        else if (gradePrompt >= 80)
        {
            letter = "B";
        }

        else if (gradePrompt >= 70)
        {
            letter = "C";
        }

        else if (gradePrompt >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradePrompt >= 70)
        {
            Console.WriteLine("You passed the class.");
        }

        else
        {
            Console.WriteLine("You did not pass the class. Try again next semester!");
        }
    }
}