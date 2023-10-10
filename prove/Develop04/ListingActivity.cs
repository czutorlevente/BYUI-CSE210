using System;

class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string> {
        "Who are people that you like the most?",
        "What are some personal strengths of yours?",
        "Who are people that you have helped recently?",
        "When have you felt the Holy Ghost today?",
        "Who are some of your best examples?"
    };

    
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(9);
        _count = GetListFromUser().Count;
        ShowSpinner(5);
        Console.WriteLine($"You listed {_count} things.");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int _promptNumber = random.Next(0, _prompts.Count);
        return _prompts[_promptNumber];
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> _responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            _responses.Add(Console.ReadLine());
        }
        return _responses;

    }
}