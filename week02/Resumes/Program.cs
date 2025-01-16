using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Vodacom";
        job1._startYear = 2020;
        job1._endYear = 2023;

        job1.DisplayJob();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Econet";
        job2._startYear = 2018;
        job2._endYear = 2020;

        job2.DisplayJob();

    }
}