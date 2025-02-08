using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{

    private List<string> _prompts;


    public ListingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    

    private List<string> GetListFromUser()
    {   
        int duration = GetDuration();
        
        List<string> answers = new List<string>();
        Console.WriteLine("List as many responses you can to the following prompt");
        DateTime finale = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < finale)
        {
            string userInput = Console.ReadLine();
            answers.Add(userInput);
        }
        return answers;
    }

    public void Run()
    {
        
        
        DisplayStartingMessage();
        Console.WriteLine("Get Ready");
        ShowPeriod(5);
        Console.WriteLine(GetRandomPrompt());
        List<string> answersList = GetListFromUser();
        Console.WriteLine($"You listed {answersList.Count} items.");
        DisplayEndingMessage();

    }

}