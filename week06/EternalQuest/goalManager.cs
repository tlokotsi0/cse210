using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }

     private void CalculateBonusPoints()
    {
        int goalsRecordedToday = _goals.Count(g => g.GetLastRecordedDate().Date == DateTime.Today);
        if (goalsRecordedToday > 1)
        {
            int bonusPoints = (goalsRecordedToday - 1) * 50;
            _score += bonusPoints;
            Console.WriteLine($"You earned {bonusPoints} bonus points for completing {goalsRecordedToday} goals today!");
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("=== Goal Manager ===");
        Console.WriteLine("1. Display Player Status");
        Console.WriteLine("2. List Your Goal Names");
        Console.WriteLine("3. List Your Goals Descriptions");
        Console.WriteLine("4. Create a Goal");
        Console.WriteLine("5. Record an Event");
        Console.WriteLine("6. Save your Goals");
        Console.WriteLine("7. Load your Goals");
        Console.WriteLine("8. Close Program");
        Console.WriteLine("=== Goal Manager ===");
        Console.Write("Enter your choice: ");
    }

    private void DisplayPlayerInfo()
    {
        Console.Clear();
        Console.WriteLine($"=== Player Info ===");
        Console.WriteLine($"Your Score: {_score}");
        Console.WriteLine($"=== Player Info ===");
    }

    private void ListGoalNames()
    {
        Console.Clear();
        Console.WriteLine("=== Goal Names ===");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
        Console.WriteLine($"=== Player Info ===");
    }

    private void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("=== Goal Details ===");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine("=== Goal Details ===");
    }
    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("=== Create Goal ===");
        Console.WriteLine("Enter your Goal Type");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("");
        string type = Console.ReadLine();
        Console.WriteLine("Write your Goal Name");
        string name = Console.ReadLine();
        Console.WriteLine("Write your Goal Description");
        string description = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Enter the amount of Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter target number:");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points:");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Wrong Input!, try again.");
                break;
        }
        Console.WriteLine("=== Create Goal ===");


    }

    private void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("=== Record Event ===");
        Console.WriteLine("Enter the goal name you want to record: ");
        string name = Console.ReadLine()?.Trim();
        var goal = _goals.Find(g => g.GetDetailsString().Contains(name));
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.GetPoints();
            CalculateBonusPoints();
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
        Console.WriteLine("=== Record Event ===");
    }

    private void SaveGoals()
     {
        Console.Clear();
        Console.WriteLine("=== Save Goals ===");
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
        Console.WriteLine("=== Save Goals ===");
    }


    private void LoadGoals()
    {
        Console.Clear();
        Console.WriteLine("=== Load Goals ===");
        if (File.Exists("myGoals.txt"))
        {
            _goals = new List<Goal>();
            using (StreamReader reader = new StreamReader("myGoals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    string[] details = parts[1].Split(',');
                    Goal goal = type switch
                    {
                        "SimpleGoal" => new SimpleGoal(
                            details[0], 
                            details[1], 
                            int.Parse(details[2]), 
                            bool.Parse(details[3]) 
                        ),
                        "EternalGoal" => new EternalGoal(
                            details[0], 
                            details[1], 
                            int.Parse(details[2]) 
                        ),
                        "ChecklistGoal" => new ChecklistGoal(
                            details[0], 
                            details[1], 
                            int.Parse(details[2]), 
                            int.Parse(details[3]), 
                            int.Parse(details[4]), 
                            int.Parse(details[5]) 
                        ),
                        _ => throw new NotSupportedException($"Unknown goal type: {type}")
                    };
                    _goals.Add(goal);
                }
            }

        }
    }
}