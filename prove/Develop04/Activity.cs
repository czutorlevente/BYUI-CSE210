using System;

class Activity
{
    protected string _name;
    protected string _description;
    protected string _duration;
    public void Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
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

    List<string> spinlist = new List<string>();
    spinlist.Add("|");
    spinlist.Add("/");
    spinlist.Add("-");
    spinlist.Add("\\");
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinlist[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= spinlist.Count)
            {
                i = 0;
            }
        }
    }
}