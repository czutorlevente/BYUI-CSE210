using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        bool guessedRight = false;

        do
        {

            Console.Write("What is your guess? ");
            string prompt2 = Console.ReadLine();
            int guessNumber = int.Parse(prompt2);

            if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed right!");
                guessedRight = true;
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        } while (guessedRight == false);
    }
}