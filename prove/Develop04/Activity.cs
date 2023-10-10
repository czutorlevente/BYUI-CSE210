using System;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string des)
    {
        _name = name;
        _description = des;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed {_duration} seconds of {_name}!");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
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