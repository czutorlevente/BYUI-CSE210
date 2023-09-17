using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        List<int> numbers = new List<int>();
        bool numberIsZero = false;

        do
        {
            Console.Write("Enter number: ");
            string number2 = Console.ReadLine();
            int number1 = int.Parse(number2);

            if (number1 == 0)
            {
                numberIsZero = true;
            }

            else
            {
                numbers.Add(number1);
            }
        } while (numberIsZero == false);

        int sum1 = 0;
        foreach (int number3 in numbers)
        {
            sum1 = sum1 + number3;
        }
        Console.WriteLine($"The sum is: {sum1}");

        float average1 = sum1/numbers.Count;
        Console.WriteLine($"The average is: {average1}");

        int largest1 = numbers[0];
        foreach (int number4 in numbers)
        {
            if (number4 > largest1)
            {
                largest1 = number4;
            }
        }
        Console.WriteLine($"The largest is: {largest1}");
    }
}