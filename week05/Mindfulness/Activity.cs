using System;
using System.Threading;

public class Activity
{
    private string _name;

    private string _description;

    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine(_description);

        Console.WriteLine("How long in seconds, would you like for your session?: ");
        string choice = Console.ReadLine();
        if (int.TryParse(choice, out int choiceInt))
        {
             _duration = choiceInt; 
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            // You could handle the invalid input here, 
            // such as prompting the user for input again.
        }
        _duration = choiceInt;
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed the {_name} in {_duration} seconds!");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "    ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowPeriod(int seconds)
    {
        Console.Write("Processing");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}