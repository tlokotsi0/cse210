using System;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private static readonly Random random = new Random();

    private static readonly string[] Prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I grateful for today?",
        "What is one thing I learned today?",
        "What was a challenge I faced today and how did I overcome it?",
        "What made me smile today?",
        "What was the most beautiful thing I saw today?"
    };

    public void WriteNewEntry()
    {
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now });
        Console.WriteLine("Entry added successfully!\n");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.\n");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveJournalToFile(string filename)
    {
        try
        {
            File.WriteAllLines(filename, entries.Select(e => e.ToString()));
            Console.WriteLine($"Journal saved to {filename}.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadJournalFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            entries.Clear();
            int i = 0;
            while (i < lines.Length)
            {
                try
                {
                    DateTime date = DateTime.Parse(lines[i].Split(": ")[1]);
                    string prompt = lines[i + 1].Split(": ")[1];
                    string response = lines[i + 2].Split(": ")[1];
                    entries.Add(new Entry { Date = date, Prompt = prompt, Response = response });
                    i += 3;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine($"Journal loaded from {filename}.\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found: {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
