using System;

class Motivation
{
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