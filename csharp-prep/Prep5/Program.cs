using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberFavorite = Console.ReadLine();
            int number = int.Parse(numberFavorite);
            return number;
        }

        static int SquareNumber(int number1)
        {
            int number2 = number1*number1;
            return number2;
        }

        DisplayWelcome();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int square1 = SquareNumber(usernumber);
        string square = square1.ToString();


        static void DisplayResult(string s, string na)
        {
            Console.WriteLine($"{na}, the square of your number is: {s}");
        }

        DisplayResult(square, username);

    }
}