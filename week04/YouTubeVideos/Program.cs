using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create and add videos to the list
        Video video1 = new Video("Amazing Nature Scenes", "Thabang Brown", 300);
        video1.AddComment("Alice", "Wow, this is breathtaking!");
        video1.AddComment("Bob", "I love the music.");
        video1.AddComment("Charlie", "Can you share the location?");
        videos.Add(video1);

        Video video2 = new Video("Semonkong Trip", "John Van De Merwe", 540);
        video2.AddComment("Hannah", "Wow, this is beautiful!");
        video2.AddComment("Keke", "The mountains are so beautiful");
        video2.AddComment("Tsepo", "Talk about hidden gems");
        videos.Add(video2);

        Video video3 = new Video("Lesotho local Cuisines", "Idrid Ngongo", 900);
        video3.AddComment("Sarah", "The meat looks delicious!");
        video3.AddComment("Bob", "So many Delicacies");
        video3.AddComment("Nko", "Where in lesotho is this?");
        videos.Add(video3);

        

        // Iterate through the list of videos and display information
        foreach (var video in videos)
        {
            Console.WriteLine($"Video Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (var summary in video.GetCommentSummaries())
            {
                Console.WriteLine($"- {summary}");
            }

            Console.WriteLine();
        }
    }
}