using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} at {_company} from {_startYear} until {_endYear}.");
    }
}