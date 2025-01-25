using System;

public class Program
{
    public static void Main(string[] args)
    {
        //To exceed requirements, the program selects a random scripture from a list.
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them that are the called according to his purpose."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me.") 
        };

        Random random = new Random();
        int randomIndex = random.Next(0, scriptures.Count);
        Scripture scripture = scriptures[randomIndex];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nScripture is completely hidden.");
        Console.ReadLine();
    }
}
