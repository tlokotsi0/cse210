using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi!! This is the ExerciseTracking Project.");

        Activity cycling = new Cycling(45, 15.0);
        Activity running = new Running(30, 3.0);
        Activity swimming = new Swimming(60, 40);

        List<Activity> activites = new List<Activity>();
        activites.Add(cycling);
        activites.Add(running);
        activites.Add(swimming);

        foreach (var activity in activites)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}