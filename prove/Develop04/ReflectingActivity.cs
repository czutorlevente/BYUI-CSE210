using System;
using System.Diagnostics;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you learned something important."

    };

    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        DisplayStartingMessage();
        DisplayPrompt();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        DisplayQuestions();
        Console.WriteLine("");
        DisplayEndingMessage();
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int _promptNumber = random.Next(0, _prompts.Count);
        return _prompts[_promptNumber];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int _QNumber = random.Next(0, _questions.Count);
        return _questions[_QNumber];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Consider the following prompt: \n{GetRandomPrompt()}");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience. \nYou may begin in: ");
        ShowCountDown(9);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write(GetRandomQuestion());
            ShowSpinner(13);
        }

    }
}