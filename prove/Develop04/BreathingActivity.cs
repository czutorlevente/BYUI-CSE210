using System;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing activity", "This activity will help you relax by walking you through breathing in and out.", duration)
    {
    
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);
        Console.WriteLine("Breath in and out following the animation:");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int i = 0;

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
        Console.Write(".*");
        Thread.Sleep(2000);

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
        Console.Write("*");
        Thread.Sleep(3000);
        Console.Write("\b \b");
    }
}