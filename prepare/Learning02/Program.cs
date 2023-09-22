using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software engineer";
        job1._company = "Apple";
        job1._startYear = 2015;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Microsoft";
        job2._startYear = 2013;
        job2._endYear = 2015;

        job1.Display();
        job2.Display();

        
    }
}