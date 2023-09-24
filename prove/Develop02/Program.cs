using System;

class Program
{
    static void Main(string[] args)
    {
        Load_file load_1 = new Load_file();
        List<string> lines_1 = load_1.GetLines("Journal.txt");

        Entry entry = new Entry();


        string entry_1 = entry.Prompt();
        lines_1.Add(entry_1);

        foreach (string line in lines_1)
        {
            Console.WriteLine(line);
        }
    }
}