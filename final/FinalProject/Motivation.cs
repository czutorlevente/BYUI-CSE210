using System;

class Motivation
{

    public string GiveQuote()
    {
        Random random = new Random();
        int index = random.Next(0, _quotes.Count);
        return _quotes[index];

    }
    List<string> _quotes = new List<string>
    {
        "Your body is a temple, take good care of it!",
        "Having a physical body is a privilege. Show your gratitude for it!",
        "Your can do all things through His strenght!",
        "Self-control is the basis of self-esteem",
        "Run in such a way as to get the prize!"
    };
    List<string> spinlist = new List<string>{"|", "/", "-", "\\"};
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string s = spinlist[i];
            Console.Write(s);
            Thread.Sleep(170);
            Console.Write("\b \b");
            i++;
            Console.ResetColor();

            if (i >= spinlist.Count)
            {
                i = 0;
            }
        }
    }
}