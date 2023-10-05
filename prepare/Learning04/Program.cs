using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assignment_1 = new Assignment("Levente Czutor", "something");
        Console.WriteLine(Assignment_1.GetSummary());
        Math math_1 = new Math("Levi", "matek", "7.1", "3-18");
        Console.WriteLine($"{math_1.GetSummary()} - {math_1.GetHomeworkList()}");


        WritingAssignment history = new WritingAssignment("Levente Czutor", "20th century history", "The phony fall of the Soviet Union");

    Console.WriteLine($"{history.GetWritingInformation()}");
    }
}