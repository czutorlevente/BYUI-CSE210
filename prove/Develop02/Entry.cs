using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{

    
    public List<string> questions = new List<string>
    {"What made this day challenging?",
    "Did you do something that made you feel bad?",
    "Do you think this day was out of your control?",
    "What do you think you can do to avoid days like this?",
    "How could you have a positive attitude despite the bad experiences that you had today?"};

    public List<string> questions_2 = new List<string>
    {"What was the most inspiring thing you experienced today?",
    "Did you meet someone new today?",
    "What made this day so good?",
    "Was there anything cool you learned today?",
    "What was the most useful part of this day?"};

    Random randomGenerator = new Random();
    
    public string Prompt()
    {
        int theNumber = randomGenerator.Next(0,4);
        string question_1 = questions[theNumber];
        Console.WriteLine(question_1);
        string entry_1 = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string full_entry = $"{dateText}{Environment.NewLine}{question_1}{Environment.NewLine}{entry_1}{Environment.NewLine}";
        return full_entry;
    }

    public string Prompt2()
    {
        int theNumber = randomGenerator.Next(0,4);
        string question_1 = questions_2[theNumber];
        Console.WriteLine(question_1);
        string entry_1 = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string full_entry = $"{dateText}{Environment.NewLine}{question_1}{Environment.NewLine}{entry_1}{Environment.NewLine}";
        return full_entry;
    }
}