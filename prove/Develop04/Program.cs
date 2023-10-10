using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity breathing = new BreathingActivity();
        ListingActivity listing = new ListingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();

        int answer = 0;
        while (answer != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Quit\n");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                breathing.Run();
                Console.Write("Click enter to continue! ");
                Console.ReadLine();
            }

            else if (answer == 2)
            {
                reflecting.Run();
                Console.Write("Click enter to continue! ");
                Console.ReadLine();
            }

            else if (answer == 3)
            {
                listing.Run();
                Console.Write("Click enter to continue! ");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Thank you for your time!");
            }

        }
    }
}