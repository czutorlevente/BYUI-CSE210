using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> lines_1 = new List<string>();
        
        string response;

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            response = Console.ReadLine();
            Console.WriteLine("");

            if (response == "1")
            {
                Entry entry = new Entry();
                string entry_1 = entry.Prompt();
                lines_1.Add(entry_1);
            }

            else if (response == "2")
            {
                foreach (string line in lines_1)
                {
                    Console.WriteLine(line);
                }
            }

            else if (response == "3")
            {
                Load_file load_1 = new Load_file();
                lines_1 = load_1.GetLines("Journal.txt");
            }

            else if (response == "4")
            {
                Save saving = new Save();
                saving.Saving(lines_1, "Journal.txt");
            }

            else if (response == "5")
            {
                
            }
        } while (response != "5");

    }
}