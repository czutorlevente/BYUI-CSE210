using System;

public class Load_file
{

    public string [] GetLines(string filename)
    {
        string [] lines = System.IO.File.ReadAllLines(filename);
        return lines;
    }

}