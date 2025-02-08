using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {   Console.WriteLine("Get Ready...");
            ShowPeriod(5);
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
   
}