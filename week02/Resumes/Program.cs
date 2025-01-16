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


        Console.WriteLine($"Job title: {job1._jobTitle}");
        Console.WriteLine($"Company: {job1._company}");
        Console.WriteLine($"Start Year: {job1._startYear}");
        Console.WriteLine($"End Year: {job1._endYear}");


        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Econet";
        job2._startYear = 2018;
        job2._endYear = 2020;


        Console.WriteLine($"Job title: {job2._jobTitle}");
        Console.WriteLine($"Company: {job2._company}");
        Console.WriteLine($"Start Year: {job2._startYear}");
        Console.WriteLine($"End Year: {job2._endYear}");

    }
}