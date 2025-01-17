using System;
using System.Security.Cryptography.X509Certificates;

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
        job2._jobTitle = "Manager";
        job2._company = "Econet";
        job2._startYear = 2018;
        job2._endYear = 2020;

        job2.DisplayJob();


        Resume cv = new Resume();
        cv._name ="Tlokotsi Foulo";

        cv._jobs.Add(job1);
        cv._jobs.Add(job2);
        
        cv.Display();

    }
}