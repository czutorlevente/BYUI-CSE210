using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{

    
    public List<string> questions = new List<string>
    {"What was the most inspiring thing you experienced today?",
    "Did you meet someone new today?",
    "Was this a good or a bad day? Why?",
    "Was there anything you learned today?",
    "What was the most challenging experience you had today?"};

    Random randomGenerator = new Random();
    
    public string Prompt()
    {
        int theNumber = randomGenerator.Next(0,4);
        string question_1 = questions[theNumber];
        Console.WriteLine(question_1);
        string entry_1 = Console.ReadLine();

        string full_entry = $"{question_1} {entry_1}";
        return full_entry;
    }
}