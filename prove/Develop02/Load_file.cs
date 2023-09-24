using System;

public class Load_file
{

    public List<string> GetLines(string filename)
    {
        string [] lines_1 = System.IO.File.ReadAllLines(filename);
        List<string> lines = lines_1.ToList();
        return lines;
    }

}