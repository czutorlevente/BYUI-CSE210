using System;

class Math : Assignment
{
    private string _textbookSection;
    private string _problems;

    public Math(string name, string topic, string section, string problem) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}