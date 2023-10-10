using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing activity", "This activity will help you relax by walking you through breathing in and out.")
    {
    
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);
        Console.WriteLine("Breath in and out following the animation:");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Breathing_1();
        }
        Thread.Sleep(1000);
        DisplayEndingMessage();
    }

    public void Breathing_1()
    {
        Console.Write("6");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(".5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(".4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(".3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(".2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(".1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(". ");
        ShowSpinner(4);

        Console.Write("\b \b\b \b");
        Console.Write("6");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        ShowSpinner(3);
        Console.Write("\b \b");
    }
}