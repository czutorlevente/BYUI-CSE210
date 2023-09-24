using System;
using System.IO;
public class Save
{
    public void Saving(List<string> input, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string item in input)
            {
                outputFile.WriteLine($"{item}");
            }
        }
    }

}