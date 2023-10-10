using System;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity breathing = new BreathingActivity();
        ListingActivity listing = new ListingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        reflecting.Run();
    }
}